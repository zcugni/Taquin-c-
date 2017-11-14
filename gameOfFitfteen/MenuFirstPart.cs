using System;
using System.Drawing;
using System.Windows.Forms;

namespace gameOfFifteen {
    /// <summary>
    /// First part of the menu, where the player decide what type of GameOfFifteen to play
    /// (number or image and dimension)
    /// </summary>
    public partial class MenuFirstPart : Form {
        bool radioGroupTwoCheck = false;
        bool fileChosen = false;
        int width;
        int height;
        Bitmap img;

        public MenuFirstPart() {
            InitializeComponent();
            addEvent(this);
        }

        /// <summary>
        /// Add an event to all the radio buttons inside the group box
        /// </summary>
        /// <param name="ctrl">List of controls</param>
        private void addEvent(Control ctrl) { 
            foreach(Control control in ctrl.Controls){
                if (control.HasChildren) {
                    addEvent(control);
                } else {
                    if (control is RadioButton) {
                        RadioButton raBtn = control as RadioButton;
                        raBtn.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                    }
                }

            }
        }

        /// <summary>
        /// Check if we can advanced to the next menu
        /// </summary>
        private void checkIfReady() {
            if (radioGroupTwoCheck && !raBtnImg.Checked) //The first radio button groups directly has focus so will always have one of it's radioButton chosen
                btnNext.Enabled = true;
            else if (raBtnImg.Checked && fileChosen) { 
                btnNext.Enabled = true;
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e) {
            RadioButton raBtn = sender as RadioButton;

            switch (raBtn.Tag.ToString()) { 
                case "1" :
                    btnChooseFile.Enabled = false;
                    gboxNbTile.Enabled = true;
                    break;
                case "2" :
                    btnChooseFile.Enabled = true;
                    gboxNbTile.Enabled = false;
                    break;
                case "3" :
                    radioGroupTwoCheck = true;
                    nudWidth.Enabled = false;
                    nudHeight.Enabled = false;
                    width = 4;
                    height = 4;
                    break;
                case "4" :
                    radioGroupTwoCheck = true;
                    nudWidth.Enabled = false;
                    nudHeight.Enabled = false;
                    width = 4;
                    height = 6;
                    break;
                case "5" :
                    radioGroupTwoCheck = true;
                    nudWidth.Enabled = false;
                    nudHeight.Enabled = false;
                    width = 4;
                    height = 8;
                    break;
                case "6" :
                    radioGroupTwoCheck = true;
                    nudHeight.Enabled = true;
                    nudWidth.Enabled = true;
                    break;
            }

            checkIfReady();
        }

        private void btnChooseFile_Click(object sender, EventArgs e) {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                fileChosen = true;
                img = new Bitmap(openFileDialog1.FileName);
                checkIfReady();
            }
        }

        private void btnNext_Click(object sender, EventArgs e) {
            if (raBtnCustom.Checked && nudHeight.Value * nudWidth.Value <= 64) {
                width = (int)nudWidth.Value;
                height = (int)nudHeight.Value;
                defineGameAndMenu();
            } else if (raBtnCustom.Checked && nudHeight.Value * nudWidth.Value > 64) {
                MessageBox.Show("Le produit de la largeur et la hauteur personnalisées doit être inférieur ou égal à 64");
            } else {
                defineGameAndMenu();
            }
        }

        private void defineGameAndMenu() {
            if (raBtnNumber.Checked) {
                GameOfFifteen<Int32> game = new GameOfFifteen<Int32>(width, height);
                MenuSecondPart<Int32> menu2 = new MenuSecondPart<Int32>(game);
                menu2.Show();
                this.Hide(); //I would prefer .Close() we can't because it would close the program, multi-thread needed
            } else {
                GameOfFifteen<Bitmap> game = new GameOfFifteen<Bitmap>(img);
                MenuSecondPart<Bitmap> menu2 = new MenuSecondPart<Bitmap>(game);
                menu2.Show();
                this.Hide(); //I would prefer .Close() we can't because it would close the program, multi-thread needed
            }
        }

        private void MenuFirstPart_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
    }
}
