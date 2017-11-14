namespace gameOfFifteen
{
    partial class GameView<T>
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlGameArea = new System.Windows.Forms.Panel();
            this.pnlVictoryStateArea = new System.Windows.Forms.Panel();
            this.lblVictoryState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlGameArea
            // 
            this.pnlGameArea.Location = new System.Drawing.Point(12, 40);
            this.pnlGameArea.Name = "pnlGameArea";
            this.pnlGameArea.Size = new System.Drawing.Size(308, 306);
            this.pnlGameArea.TabIndex = 0;
            // 
            // pnlVictoryStateArea
            // 
            this.pnlVictoryStateArea.Enabled = false;
            this.pnlVictoryStateArea.Location = new System.Drawing.Point(339, 40);
            this.pnlVictoryStateArea.Name = "pnlVictoryStateArea";
            this.pnlVictoryStateArea.Size = new System.Drawing.Size(307, 306);
            this.pnlVictoryStateArea.TabIndex = 1;
            // 
            // lblVictoryState
            // 
            this.lblVictoryState.AutoSize = true;
            this.lblVictoryState.Location = new System.Drawing.Point(446, 9);
            this.lblVictoryState.Name = "lblVictoryState";
            this.lblVictoryState.Size = new System.Drawing.Size(84, 13);
            this.lblVictoryState.TabIndex = 2;
            this.lblVictoryState.Text = "Etat de victoire :";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 379);
            this.Controls.Add(this.lblVictoryState);
            this.Controls.Add(this.pnlVictoryStateArea);
            this.Controls.Add(this.pnlGameArea);
            this.Name = "GameView";
            this.Text = "Jeu Taquin ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameArea;
        private System.Windows.Forms.Panel pnlVictoryStateArea;
        private System.Windows.Forms.Label lblVictoryState;
    }
}

