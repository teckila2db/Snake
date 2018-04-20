namespace WindowsFormsApp5
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.snakeScoreLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceBarLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.spaceBarLabel2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.snakeScoreLabel,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 423);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 25);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Crimson;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 20);
            this.toolStripStatusLabel1.Text = "Ton score est de : ";
            // 
            // snakeScoreLabel
            // 
            this.snakeScoreLabel.ForeColor = System.Drawing.Color.Crimson;
            this.snakeScoreLabel.Name = "snakeScoreLabel";
            this.snakeScoreLabel.Size = new System.Drawing.Size(17, 20);
            this.snakeScoreLabel.Text = "0";
            // 
            // spaceBarLabel
            // 
            this.spaceBarLabel.AutoSize = true;
            this.spaceBarLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.spaceBarLabel.Location = new System.Drawing.Point(88, 204);
            this.spaceBarLabel.Name = "spaceBarLabel";
            this.spaceBarLabel.Size = new System.Drawing.Size(295, 17);
            this.spaceBarLabel.TabIndex = 1;
            this.spaceBarLabel.Text = "Appuis sur la barre espace pour commencer !";
            this.spaceBarLabel.Click += new System.EventHandler(this.spaceBarLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(164, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(0, 20);
            // 
            // spaceBarLabel2
            // 
            this.spaceBarLabel2.AutoSize = true;
            this.spaceBarLabel2.ForeColor = System.Drawing.Color.Black;
            this.spaceBarLabel2.Location = new System.Drawing.Point(88, 232);
            this.spaceBarLabel2.Name = "spaceBarLabel2";
            this.spaceBarLabel2.Size = new System.Drawing.Size(286, 17);
            this.spaceBarLabel2.TabIndex = 3;
            this.spaceBarLabel2.Text = "Press sur \"H\" = Dur, \"E\"= Facile \"N\"= normal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 448);
            this.Controls.Add(this.spaceBarLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.spaceBarLabel);
            this.Controls.Add(this.statusStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Snake Game";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel snakeScoreLabel;
        private System.Windows.Forms.Label spaceBarLabel;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Label spaceBarLabel2;
    }
}

