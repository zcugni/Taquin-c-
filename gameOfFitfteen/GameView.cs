using System;
using System.Drawing;
using System.Windows.Forms;

namespace gameOfFifteen {
    /// <summary>
    /// View of the game, where the player can play
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public partial class GameView<T> : Form {
        GameOfFifteen<T> _game;
        double width;
        double height;
        const int SPACE_BETWEEN_PANEL = 20;

        public GameOfFifteen<T> Game {
            get { return _game; }
            set { _game = value; }
        }

        public GameView(GameOfFifteen<T> game) {
            InitializeComponent();
            Game = game;
        }

        private void Form1_Load(object sender, EventArgs e) {
            width = 35;
            height = 35;

            updatePanelView();

            //Fill the victory state panel (similar to what is done in updatePanelView, but yet different on some important point (click event for exemple)
            for (int i = 0; i < Game.NbLine; i++)
                for (int j = 0; j < Game.NbCol; j++) {
                    //always the same
                    Button btn = new Button();
                    btn.BackColor = Color.Transparent;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.UseVisualStyleBackColor = false;

                    //different for each button
                    btn.Size = new Size((int)width, (int)height);
                    btn.Location = new Point(j * (int)Math.Round(width, 0), i * (int)Math.Round(height, 0));

                    //Fill tile with either number or image (from the game victory state)
                    if (typeof(T) == typeof(Int32))
                        btn.Text = Game.VictoryState[(i * Game.TilePerCol) + j].ToString();
                    else if (typeof(T) == typeof(Bitmap)) {
                        Bitmap tileImg = (Bitmap)Game.VictoryState[(i * Game.TilePerCol) + j];
                        if (tileImg != null)
                            btn.BackgroundImage = tileImg;
                    }

                    pnlVictoryStateArea.Controls.Add(btn);
                }

            //Calculate the height and width of the panel and the form from the number of tiles and their dimension
            pnlVictoryStateArea.Width = (int)width * Game.TilePerCol;
            pnlVictoryStateArea.Location = new Point(pnlGameArea.Location.X + pnlGameArea.Width + SPACE_BETWEEN_PANEL, pnlVictoryStateArea.Location.Y);
            pnlGameArea.Height = Game.NbLine * (int)height;
            pnlVictoryStateArea.Height = pnlGameArea.Height;
            lblVictoryState.Location = new Point(pnlVictoryStateArea.Location.X + (pnlVictoryStateArea.Width / 2) - (lblVictoryState.Width / 2), lblVictoryState.Location.Y);
            this.Width = pnlGameArea.Width + pnlVictoryStateArea.Width + 3 * SPACE_BETWEEN_PANEL;
            this.Height = pnlGameArea.Location.Y + pnlGameArea.Height + 80;
        }

        /// <summary>
        /// Update the gameAreaPanel from the GameOfFifteen model
        /// </summary>
        private void updatePanelView() {
            pnlGameArea.Controls.Clear();
            int cpt = 0;
            for (int i = 0; i < Game.NbLine; i++)
                for (int j = 0; j < Game.NbCol; j++) {
                    cpt++; //use to keep track of the current tile
                    //always the same
                    Button btn = new Button();
                    btn.BackColor = Color.Transparent;
                    btn.UseVisualStyleBackColor = false;

                    //different for each button
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Size = new Size((int)width, (int)height);
                    btn.Location = new Point(j * (int)Math.Round(width, 0), i * (int)Math.Round(height, 0));

                    //Fill tile with either number or image (from the game victory state)
                    if (typeof(T) == typeof(Int32))
                        btn.Text = Game.TileList[(i * Game.TilePerCol) + j].ToString();
                    else if (typeof(T) == typeof(Bitmap)) {
                        Bitmap tileImg = (Bitmap)Game.TileList[(i * Game.TilePerCol) + j];
                        if (tileImg != null)
                            btn.BackgroundImage = tileImg;
                    }

                    btn.Click += new System.EventHandler(Swap);

                    bool swappable = Game.tileSwapable(cpt);

                    if (!swappable)
                        btn.Enabled = false;
                    else if (swappable)
                        btn.FlatAppearance.BorderColor = Color.Red;

                    pnlGameArea.Controls.Add(btn);
                }

            pnlGameArea.Width = (int)width * Game.TilePerCol;
        }

        /// <summary>
        /// Ask the GameOfFifteen model to swap the clicked tile with the empty one and update the panel with the new TileList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Swap(object sender, EventArgs e) {
            Button btn = sender as Button;
            int btnIndex = pnlGameArea.Controls.IndexOf(btn);
            Game.swapTileWithEmpty(btnIndex);

            updatePanelView();
        }
    }
}
