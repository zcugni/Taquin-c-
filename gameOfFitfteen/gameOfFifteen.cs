using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace gameOfFifteen {
    public class GameOfFifteen<T> {
        #region variable

        /*** Variables ***/

        /** General **/

        //maximum number of tiles is 64
        //so for a square game, the max for either the columns or lines would be 8
        private const int MAX_NB_TILE_COL_LINE = 8; 
        private int _tilesNb;
        private int _nbCol;
        private int _nbLine;
        private Random rd = new Random();

        /// <summary>
        /// Position of the empty tile (index of empty tile + 1)
        /// </summary>
        private int _emptyTilePos; 
        private int _precedentEmptyTilePos;

        /// <summary>
        /// List of the tiles, used during play
        /// </summary>
        private List<object> _tileList;

        /// <summary>
        /// List of the tiles when they are ordered in the desired way. 
        /// The player must arrange the tiles in this way to win
        /// </summary>
        private List<object> _victoryState;

        /** Only for GameOfFifteen<Int32> **/
        private string _sortingType;

        /// <summary>
        /// Pre-sorted list of tile, from min to max
        /// </summary>
        private List<string> _minToMaxTileList;

        /// <summary>
        /// Pre-sorted list of tile, from max to min
        /// </summary>
        private List<string> _maxToMinTileList;

        /** Only for GameOfFifteen<Bitmap> **/
        private Bitmap _img;

        /// <summary>
        /// Dimension of the tile in the view (is given by the view).
        /// The way the _img is cut will depend on this
        /// </summary>
        private Size _tileSize;

        #endregion

        #region properties
        /*** Properties ***/

        /** General **/
        public int NbCol {
            get { return _nbCol; }
            set { _nbCol = value; }
        }

        public int NbLine {
            get { return _nbLine; }
            set { _nbLine = value; }
        }

        /// <summary>
        /// See corresponding private variable
        /// Position of the empty tile (index of empty tile + 1)
        /// </summary>
        public int EmptyTilePos {
            get { return _emptyTilePos; }
            set { _emptyTilePos = value; }
        }

        public List<object> TileList {
            get {
                if (_tileList == null) {
                    _tileList = new List<object>(VictoryState);
                    shuffleTile();
                }

                return _tileList;
            }
            set { _tileList = value; }
        }

        public List<object> VictoryState {
            get {
                if (_victoryState == null)
                    generateVictoryState();

                return _victoryState;
            }
            set {
                _victoryState = value;
            }
        }

        public int TilePerCol {
            get { return _tilesNb / NbLine; }
        }

        /** Only for GameOfFifteen<Int32> **/

        /// <summary>
        /// See corresponding private variable
        /// Pre-sorted list of tile, from min to max
        /// </summary>
        public List<string> MinToMaxTileList {
            get {
                if (_minToMaxTileList == null) {
                    List<Int32> tempListInt = new List<Int32>();
                    for (int i = 0; i < _tilesNb; i++)
                        tempListInt.Add(i);

                    List<string> tempListString = tempListInt.ConvertAll<string>(x => x.ToString());

                    tempListString[tempListInt.IndexOf(0)] = string.Empty; // transform the 0 tile in an empty tile
                    MinToMaxTileList = tempListString;
                }
                return _minToMaxTileList;
            }
            set { _minToMaxTileList = value; }
        }

        /// <summary>
        /// See corresponding private variable
        /// Pre-sorted list of tile, from max to min
        /// </summary>
        public List<string> MaxToMinTileList {
            get {
                if (_maxToMinTileList == null) {
                    List<Int32> tempListInt = new List<Int32>();
                    for (int i = _tilesNb - 1; i >= 0; i--)
                        tempListInt.Add(i);

                    List<string> tempListString = tempListInt.ConvertAll<string>(x => x.ToString());

                    tempListString[tempListInt.IndexOf(0)] = string.Empty; // transform the 0 tile in an empty tile
                    MaxToMinTileList = tempListString;
                }
                return _maxToMinTileList;
            }
            set { _maxToMinTileList = value; }
        }

        /** Only for GameOfFifteen<Bitmap> **/

        public Bitmap Image {
            get { return _img; }
            set { _img = value; }
        }

        /// <summary>
        /// See private variable
        /// Dimension of the tile in the view (is given by the view).
        /// The way the _img is cut will depend on this
        /// </summary>
        public Size TileSize {
            get { return _tileSize; }
            set { _tileSize = value; }
        }

        #endregion

        #region Constructor

        /*** Constructor ***/

        /// <summary>
        /// With this Game of Fifteen constructor, the tiles will be filled with numbers
        /// </summary>
        /// <param name="nbCol">Number of columns</param>
        /// <param name="nbLine">Number of lines</param>
        public GameOfFifteen(int nbCol, int nbLine) {
            NbCol = nbCol;
            NbLine = nbLine;
            _tilesNb = NbCol * NbLine;
            _sortingType = "minToMax"; //default
        }

        /// <summary>
        /// With this Game of Fifteen constructor, the tiles will be filled with part of the image
        /// </summary>
        /// <param name="img">Image to use to fill the part</param>
        public GameOfFifteen(Bitmap img) {
            Image = img;
        }

        #endregion

        #region Methods

        /*** Methods ***/


        /** General **/

        /* Generate the victory state, either for a Bitmap or Int32 game
         * Should only be called once 
         */
        private void generateVictoryState() {
            if (typeof(T) == typeof(Int32)) {
                VictoryState = choseSortTileList();
            } else if (typeof(T) == typeof(Bitmap)) {
                //Set the number of columns and lines from the dimension of a tile (given by the view) and the image
                //Warning: if the image is to big, it won't resize it, just take a part of it
                //Recommended image size: 280px by 280px

                if (Image.Width / TileSize.Width > MAX_NB_TILE_COL_LINE)
                    NbCol = MAX_NB_TILE_COL_LINE;
                else
                    NbCol = Image.Width / TileSize.Width;

                if (Image.Height / TileSize.Height > MAX_NB_TILE_COL_LINE)
                    NbLine = MAX_NB_TILE_COL_LINE;
                else
                    NbLine = Image.Height / TileSize.Height;

                _tilesNb = NbCol * NbLine;

                //Cut the image in part and make a list of all the part. This list represent the game tiles.

                Graphics graphics;
                int index = 0;
                List<Bitmap> imgTileList = new List<Bitmap>();

                for (int i = 0; i < NbLine; i++)
                    for (int j = 0; j < TilePerCol; j++) {
                        imgTileList.Add(new Bitmap(TileSize.Width, TileSize.Height));
                        graphics = Graphics.FromImage(imgTileList[index]);
                        graphics.DrawImage(Image, new Rectangle(0, 0, TileSize.Width, TileSize.Height), new Rectangle(j * TileSize.Width, i * TileSize.Height, TileSize.Width, TileSize.Height), GraphicsUnit.Pixel);
                        graphics.Dispose();
                        index++;
                    }

                //Remove the last image part and replace it with an empty one (null), in orden to have an empty tile
                imgTileList.RemoveAt(imgTileList.Count - 1);
                imgTileList.Add(null);
                VictoryState = imgTileList.ToList<object>();
            }
        }

        /// <summary>
        /// Shuffle the tile in the same way a human would (tile per tile, by swapping with the empty one) in order to play the game
        /// </summary>
        /// <returns>Shuffled tiled list, ready to be use to play</returns>
        public List<object> shuffleTile() {
            List<int> availableSwap;
            List<int> tempList;
            int newPos;

            for (int i = 0; i < 50; i++) {
                //The 4 tiles around the empty one that would be excheangeable if the empty one was in the middle
                availableSwap = new List<int>() { _emptyTilePos - TilePerCol, _emptyTilePos - 1, _emptyTilePos + 1, _emptyTilePos + TilePerCol };
                tempList = new List<int>(availableSwap); //needed because we can't modify a list we're running through 

                //Get rid of non-swappable tile (for when the empty one was on the edge of the game)
                //Including the precedent tile the empty one was on. We don't want the swapping to loop between two tiles
                for (int j = 0; j < tempList.Count(); j++) {
                    if (!tileSwapable(tempList.ElementAt(j)) || tempList.ElementAt(j) == _precedentEmptyTilePos)
                        availableSwap.Remove(tempList.ElementAt(j));
                }

                //Randomly choosen new position between the eligible one
                newPos = availableSwap.ElementAt(rd.Next(0, availableSwap.Count()));
                Utility.swapListVar(ref _tileList, newPos - 1, _emptyTilePos - 1); //swapListVar uses index, while i use position, so index + 1
                _emptyTilePos = newPos;
            }
            return TileList;
        }

        /// <summary>
        /// Check if a given tile is swappable with the empty one
        /// (And not on the next line or outside the game for example)
        /// </summary>
        /// <param name="tilePos">Position (index + 1) of the given tile</param>
        /// <returns>Boolean, true if swappable, false if not</returns>
        public bool tileSwapable(int tilePos) {
            if ((tilePos == _emptyTilePos - TilePerCol && tilePos > 0) || //Not outside the game (for the tile just under the empty one)
                (tilePos == _emptyTilePos + TilePerCol && tilePos <= TileList.Count()) || //Not outside the game (for the tile just above the empty one)
                (tilePos == _emptyTilePos - 1 && tilePos % TilePerCol != 0) || //Not on precedent line (for the tile just before the empty one)
                (tilePos == _emptyTilePos + 1 && tilePos % TilePerCol != 1)) //Not on next line (for the tile just after the empty one)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Swap the given tile with the empty one
        /// </summary>
        /// <param name="indexTileToSwap"></param>
        public void swapTileWithEmpty(int indexTileToSwap) {
            Utility.swapListVar(ref _tileList, indexTileToSwap, EmptyTilePos - 1);
            _precedentEmptyTilePos = EmptyTilePos;
            EmptyTilePos = indexTileToSwap + 1;
        }

        /// <summary>
        /// Move the empty tile to the end of the list
        /// </summary>
        public void emptyTileToEnd() {
            if (typeof(T) == typeof(Int32)) {
                VictoryState.Remove(string.Empty);
                VictoryState.Add(string.Empty);
            } else {
                VictoryState.Remove(null);
                VictoryState.Add(null);
            }

            _emptyTilePos = VictoryState.Count();
            _precedentEmptyTilePos = EmptyTilePos;
        }

        /** Only for GameOfFifteen<Int32> **/

        public void changeVictoryState(string newSortingType) {
            _sortingType = newSortingType;
            VictoryState = choseSortTileList();
        }

        private List<object> choseSortTileList() {
            switch (_sortingType) {
                case "maxToMin":
                    return MaxToMinTileList.ToList<object>();
                default: //minToMax
                    return MinToMaxTileList.ToList<object>();
            }
        }

        /// <summary>
        /// Move the empty tile to the beginning of the list
        /// </summary>
        public void emptyTileToBeginning() {
            VictoryState.Remove(string.Empty);
            VictoryState.Insert(0, string.Empty);
            _emptyTilePos = 1;
            _precedentEmptyTilePos = EmptyTilePos;
        }

        #endregion
    }
}
