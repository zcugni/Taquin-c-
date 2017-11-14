namespace gameOfFifteen {
    partial class MenuFirstPart {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raBtnNumber = new System.Windows.Forms.RadioButton();
            this.raBtnImg = new System.Windows.Forms.RadioButton();
            this.raBtn4x6 = new System.Windows.Forms.RadioButton();
            this.raBtn4x4 = new System.Windows.Forms.RadioButton();
            this.raBtn4x8 = new System.Windows.Forms.RadioButton();
            this.raBtnCustom = new System.Windows.Forms.RadioButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.nudWidth = new System.Windows.Forms.NumericUpDown();
            this.nudHeight = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gboxNbTile = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gboxNbTile.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(128, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenu sur le jeu du taquin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choississez un type de partie :";
            // 
            // raBtnNumber
            // 
            this.raBtnNumber.AutoSize = true;
            this.raBtnNumber.Location = new System.Drawing.Point(19, 26);
            this.raBtnNumber.Name = "raBtnNumber";
            this.raBtnNumber.Size = new System.Drawing.Size(62, 17);
            this.raBtnNumber.TabIndex = 2;
            this.raBtnNumber.TabStop = true;
            this.raBtnNumber.Tag = "1";
            this.raBtnNumber.Text = "Nombre";
            this.raBtnNumber.UseVisualStyleBackColor = true;
            // 
            // raBtnImg
            // 
            this.raBtnImg.AutoSize = true;
            this.raBtnImg.Location = new System.Drawing.Point(112, 26);
            this.raBtnImg.Name = "raBtnImg";
            this.raBtnImg.Size = new System.Drawing.Size(54, 17);
            this.raBtnImg.TabIndex = 3;
            this.raBtnImg.TabStop = true;
            this.raBtnImg.Tag = "2";
            this.raBtnImg.Text = "Image";
            this.raBtnImg.UseVisualStyleBackColor = true;
            // 
            // raBtn4x6
            // 
            this.raBtn4x6.AutoSize = true;
            this.raBtn4x6.Location = new System.Drawing.Point(72, 39);
            this.raBtn4x6.Name = "raBtn4x6";
            this.raBtn4x6.Size = new System.Drawing.Size(42, 17);
            this.raBtn4x6.TabIndex = 6;
            this.raBtn4x6.TabStop = true;
            this.raBtn4x6.Tag = "4";
            this.raBtn4x6.Text = "4x6";
            this.raBtn4x6.UseVisualStyleBackColor = true;
            // 
            // raBtn4x4
            // 
            this.raBtn4x4.AutoSize = true;
            this.raBtn4x4.Location = new System.Drawing.Point(6, 39);
            this.raBtn4x4.Name = "raBtn4x4";
            this.raBtn4x4.Size = new System.Drawing.Size(42, 17);
            this.raBtn4x4.TabIndex = 5;
            this.raBtn4x4.TabStop = true;
            this.raBtn4x4.Tag = "3";
            this.raBtn4x4.Text = "4x4";
            this.raBtn4x4.UseVisualStyleBackColor = true;
            // 
            // raBtn4x8
            // 
            this.raBtn4x8.AutoSize = true;
            this.raBtn4x8.Location = new System.Drawing.Point(131, 39);
            this.raBtn4x8.Name = "raBtn4x8";
            this.raBtn4x8.Size = new System.Drawing.Size(42, 17);
            this.raBtn4x8.TabIndex = 8;
            this.raBtn4x8.TabStop = true;
            this.raBtn4x8.Tag = "5";
            this.raBtn4x8.Text = "4x8";
            this.raBtn4x8.UseVisualStyleBackColor = true;
            // 
            // raBtnCustom
            // 
            this.raBtnCustom.AutoSize = true;
            this.raBtnCustom.Location = new System.Drawing.Point(188, 39);
            this.raBtnCustom.Name = "raBtnCustom";
            this.raBtnCustom.Size = new System.Drawing.Size(98, 17);
            this.raBtnCustom.TabIndex = 9;
            this.raBtnCustom.TabStop = true;
            this.raBtnCustom.Tag = "6";
            this.raBtnCustom.Text = "Personnalisé * :";
            this.raBtnCustom.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.Enabled = false;
            this.btnChooseFile.Location = new System.Drawing.Point(172, 23);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(111, 23);
            this.btnChooseFile.TabIndex = 10;
            this.btnChooseFile.Text = "Choisir le fichier";
            this.btnChooseFile.UseVisualStyleBackColor = true;
            this.btnChooseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // nudWidth
            // 
            this.nudWidth.Enabled = false;
            this.nudWidth.Location = new System.Drawing.Point(351, 27);
            this.nudWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudWidth.Name = "nudWidth";
            this.nudWidth.Size = new System.Drawing.Size(35, 20);
            this.nudWidth.TabIndex = 11;
            // 
            // nudHeight
            // 
            this.nudHeight.Enabled = false;
            this.nudHeight.Location = new System.Drawing.Point(351, 53);
            this.nudHeight.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudHeight.Name = "nudHeight";
            this.nudHeight.Size = new System.Drawing.Size(35, 20);
            this.nudHeight.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Largeur :";
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Longueur :";
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnNext.Location = new System.Drawing.Point(168, 288);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 23);
            this.btnNext.TabIndex = 15;
            this.btnNext.Text = "Etape Suivante";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.raBtnNumber);
            this.groupBox1.Controls.Add(this.raBtnImg);
            this.groupBox1.Controls.Add(this.btnChooseFile);
            this.groupBox1.Location = new System.Drawing.Point(20, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 69);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remplissage des tuiles";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(169, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "(Dimensions recommandées : 280px * 280px)";
            // 
            // gboxNbTile
            // 
            this.gboxNbTile.Controls.Add(this.label4);
            this.gboxNbTile.Controls.Add(this.raBtnCustom);
            this.gboxNbTile.Controls.Add(this.raBtn4x4);
            this.gboxNbTile.Controls.Add(this.raBtn4x6);
            this.gboxNbTile.Controls.Add(this.label6);
            this.gboxNbTile.Controls.Add(this.raBtn4x8);
            this.gboxNbTile.Controls.Add(this.label5);
            this.gboxNbTile.Controls.Add(this.nudWidth);
            this.gboxNbTile.Controls.Add(this.nudHeight);
            this.gboxNbTile.Location = new System.Drawing.Point(20, 173);
            this.gboxNbTile.Name = "gboxNbTile";
            this.gboxNbTile.Size = new System.Drawing.Size(418, 99);
            this.gboxNbTile.TabIndex = 17;
            this.gboxNbTile.TabStop = false;
            this.gboxNbTile.Text = "Nombre de tuiles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "* Largeur fois hauteur doit être inférieur ou égal à 64";
            // 
            // MenuFirstPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 320);
            this.Controls.Add(this.gboxNbTile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MenuFirstPart";
            this.Text = "Première partie du menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuFirstPart_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.nudWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHeight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gboxNbTile.ResumeLayout(false);
            this.gboxNbTile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton raBtnNumber;
        private System.Windows.Forms.RadioButton raBtnImg;
        private System.Windows.Forms.RadioButton raBtn4x6;
        private System.Windows.Forms.RadioButton raBtn4x4;
        private System.Windows.Forms.RadioButton raBtn4x8;
        private System.Windows.Forms.RadioButton raBtnCustom;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.NumericUpDown nudWidth;
        private System.Windows.Forms.NumericUpDown nudHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gboxNbTile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}