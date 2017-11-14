using System;
using System.Drawing;
using System.Windows.Forms;

namespace gameOfFifteen {
    /// <summary>
    /// Second part of the menu, where the player specify what his/her victory state should look like
    /// </summary>
    /// <typeparam name="T">Int32 or Bitmap</typeparam>
    public partial class MenuSecondPart<T> : Form {
        GameOfFifteen<T> _game;
        double width;
        double height;

        public GameOfFifteen<T> Game {
            get { return _game; }
            set { _game = value; }
        }

        public MenuSecondPart(GameOfFifteen<T> game) {
            InitializeComponent();
            Game = game;

            width = 35;
            height = 35;

            Game.TileSize = new Size((int)width, (int)height);
            raBtnEmptyEnd.Checked = true;

            if(typeof(T) == typeof(Bitmap)){
                gBoxSort.Enabled = false;
                gBoxEmptyPos.Enabled = false;
            }
        }

        /// <summary>
        /// Update the gameAreaPanel from the GameOfFifteen model (similar to the GameView updatePanelView method)
        /// </summary>
        private void updatePanelView() {
            pnlGameArea.Controls.Clear();

            for (int i = 0; i < Game.NbLine; i++)
                for (int j = 0; j < Game.NbCol; j++) {
                    //always the same
                    Button btn = new Button();
                    btn.BackColor = Color.Transparent;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.UseVisualStyleBackColor = false;

                    //different for each button
                    btn.Name = "btnTile" + (i * j);
                    btn.Size = new Size((int)width, (int)height);
                    btn.Location = new Point(j * (int)Math.Round(width, 0), i * (int)Math.Round(height, 0));

                    ////Fill tile with either number or image (from the game victory state)
                    if (typeof(T) == typeof(Int32))
                        btn.Text = Game.VictoryState[(i * Game.TilePerCol) + j].ToString();
                    else if (typeof(T) == typeof(Bitmap)) {
                        Bitmap tileImg = (Bitmap)Game.VictoryState[(i * Game.TilePerCol) + j];
                        if (tileImg != null)
                            btn.BackgroundImage = tileImg;
                    }

                    pnlGameArea.Controls.Add(btn);
                }

            pnlGameArea.Width = (int)width * Game.TilePerCol;
            pnlGameArea.Location = new Point((this.ClientRectangle.Width - pnlGameArea.Width) / 2, pnlGameArea.Location.Y);
        }

        private void sortRadioButtons_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked)
                Game.changeVictoryState((sender as RadioButton).Tag.ToString());

            updatePanelView();
        }

        private void raBtnEmptyTileToBeg_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked)
                Game.emptyTileToBeginning();

            updatePanelView();
        }

        private void raBtnEmptyEnd_CheckedChanged(object sender, EventArgs e) {
            if ((sender as RadioButton).Checked)
                Game.emptyTileToEnd();

            updatePanelView();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            GameView<T> gameView = new GameView<T>(Game);
            gameView.Show();
            this.Close();
        }
    }
}
