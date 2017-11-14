namespace gameOfFifteen {
    partial class MenuSecondPart<T> {
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
            this.raBtnMinToMax = new System.Windows.Forms.RadioButton();
            this.raBtnMaxToMin = new System.Windows.Forms.RadioButton();
            this.gBoxSort = new System.Windows.Forms.GroupBox();
            this.gBoxEmptyPos = new System.Windows.Forms.GroupBox();
            this.raBtnEmptyTileToBeg = new System.Windows.Forms.RadioButton();
            this.raBtnEmptyEnd = new System.Windows.Forms.RadioButton();
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.gBoxSort.SuspendLayout();
            this.gBoxEmptyPos.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choississez l\'état de victoire désiré :";
            // 
            // raBtnMinToMax
            // 
            this.raBtnMinToMax.AutoSize = true;
            this.raBtnMinToMax.Checked = true;
            this.raBtnMinToMax.Location = new System.Drawing.Point(16, 33);
            this.raBtnMinToMax.Name = "raBtnMinToMax";
            this.raBtnMinToMax.Size = new System.Drawing.Size(135, 17);
            this.raBtnMinToMax.TabIndex = 1;
            this.raBtnMinToMax.TabStop = true;
            this.raBtnMinToMax.Tag = "minToMax";
            this.raBtnMinToMax.Text = "Plus petit au plus grand";
            this.raBtnMinToMax.UseVisualStyleBackColor = true;
            this.raBtnMinToMax.CheckedChanged += new System.EventHandler(this.sortRadioButtons_CheckedChanged);
            // 
            // raBtnMaxToMin
            // 
            this.raBtnMaxToMin.AutoSize = true;
            this.raBtnMaxToMin.Location = new System.Drawing.Point(157, 33);
            this.raBtnMaxToMin.Name = "raBtnMaxToMin";
            this.raBtnMaxToMin.Size = new System.Drawing.Size(135, 17);
            this.raBtnMaxToMin.TabIndex = 2;
            this.raBtnMaxToMin.Tag = "maxToMin";
            this.raBtnMaxToMin.Text = "Plus grand au plus petit";
            this.raBtnMaxToMin.UseVisualStyleBackColor = true;
            this.raBtnMaxToMin.CheckedChanged += new System.EventHandler(this.sortRadioButtons_CheckedChanged);
            // 
            // gBoxSort
            // 
            this.gBoxSort.Controls.Add(this.raBtnMinToMax);
            this.gBoxSort.Controls.Add(this.raBtnMaxToMin);
            this.gBoxSort.Location = new System.Drawing.Point(26, 51);
            this.gBoxSort.Name = "gBoxSort";
            this.gBoxSort.Size = new System.Drawing.Size(305, 68);
            this.gBoxSort.TabIndex = 4;
            this.gBoxSort.TabStop = false;
            this.gBoxSort.Text = "Arrangement";
            // 
            // gBoxEmptyPos
            // 
            this.gBoxEmptyPos.Controls.Add(this.raBtnEmptyTileToBeg);
            this.gBoxEmptyPos.Controls.Add(this.raBtnEmptyEnd);
            this.gBoxEmptyPos.Location = new System.Drawing.Point(359, 51);
            this.gBoxEmptyPos.Name = "gBoxEmptyPos";
            this.gBoxEmptyPos.Size = new System.Drawing.Size(179, 68);
            this.gBoxEmptyPos.TabIndex = 5;
            this.gBoxEmptyPos.TabStop = false;
            this.gBoxEmptyPos.Text = "Position de la case vide";
            // 
            // raBtnEmptyTileToBeg
            // 
            this.raBtnEmptyTileToBeg.AutoSize = true;
            this.raBtnEmptyTileToBeg.Location = new System.Drawing.Point(20, 33);
            this.raBtnEmptyTileToBeg.Name = "raBtnEmptyTileToBeg";
            this.raBtnEmptyTileToBeg.Size = new System.Drawing.Size(54, 17);
            this.raBtnEmptyTileToBeg.TabIndex = 1;
            this.raBtnEmptyTileToBeg.Text = "Début";
            this.raBtnEmptyTileToBeg.CheckedChanged += new System.EventHandler(this.raBtnEmptyTileToBeg_CheckedChanged);
            // 
            // raBtnEmptyEnd
            // 
            this.raBtnEmptyEnd.AutoSize = true;
            this.raBtnEmptyEnd.Location = new System.Drawing.Point(83, 33);
            this.raBtnEmptyEnd.Name = "raBtnEmptyEnd";
            this.raBtnEmptyEnd.Size = new System.Drawing.Size(39, 17);
            this.raBtnEmptyEnd.TabIndex = 3;
            this.raBtnEmptyEnd.Text = "Fin";
            this.raBtnEmptyEnd.UseVisualStyleBackColor = true;
            this.raBtnEmptyEnd.CheckedChanged += new System.EventHandler(this.raBtnEmptyEnd_CheckedChanged);
            // 
            // pnlGameArea
            // 
            this.pnlGameArea.Location = new System.Drawing.Point(42, 149);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(477, 317);
            this.pnlGameArea.TabIndex = 6;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(200, 494);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 31);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Lancer la partie !";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MenuSecondPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 547);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlGameArea);
            this.Controls.Add(this.gBoxEmptyPos);
            this.Controls.Add(this.gBoxSort);
            this.Controls.Add(this.label1);
            this.Name = "MenuSecondPart";
            this.Text = "Deuxième partie du menu ";
            this.gBoxSort.ResumeLayout(false);
            this.gBoxSort.PerformLayout();
            this.gBoxEmptyPos.ResumeLayout(false);
            this.gBoxEmptyPos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton raBtnMinToMax;
        private System.Windows.Forms.RadioButton raBtnMaxToMin;
        private System.Windows.Forms.GroupBox gBoxSort;
        private System.Windows.Forms.GroupBox gBoxEmptyPos;
        private System.Windows.Forms.RadioButton raBtnEmptyTileToBeg;
        private System.Windows.Forms.RadioButton raBtnEmptyEnd;
        private System.Windows.Forms.Panel pnlGameArea;
        private System.Windows.Forms.Button btnStart;
    }
}