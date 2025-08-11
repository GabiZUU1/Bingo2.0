namespace Bingo2._0
{
    partial class SimpleCard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.pnlLetters = new System.Windows.Forms.Panel();
            this.pnlGame = new System.Windows.Forms.Panel();
            this.pnlLetters.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(0, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(96, 75);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "B";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(96, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(96, 75);
            this.lbl2.TabIndex = 6;
            this.lbl2.Text = "I";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(192, 0);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(96, 75);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "N";
            this.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(288, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(96, 75);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "G";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Franklin Gothic Heavy", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(384, 0);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(96, 75);
            this.lbl5.TabIndex = 9;
            this.lbl5.Text = "O";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlLetters
            // 
            this.pnlLetters.Controls.Add(this.lbl1);
            this.pnlLetters.Controls.Add(this.lbl2);
            this.pnlLetters.Controls.Add(this.lbl3);
            this.pnlLetters.Controls.Add(this.lbl4);
            this.pnlLetters.Controls.Add(this.lbl5);
            this.pnlLetters.Location = new System.Drawing.Point(10, 0);
            this.pnlLetters.Name = "pnlLetters";
            this.pnlLetters.Size = new System.Drawing.Size(480, 75);
            this.pnlLetters.TabIndex = 10;
            // 
            // pnlGame
            // 
            this.pnlGame.BackColor = System.Drawing.Color.Khaki;
            this.pnlGame.Location = new System.Drawing.Point(10, 78);
            this.pnlGame.Name = "pnlGame";
            this.pnlGame.Size = new System.Drawing.Size(480, 500);
            this.pnlGame.TabIndex = 10;
            // 
            // SimpleCard
            // 
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.pnlGame);
            this.Controls.Add(this.pnlLetters);
            this.Name = "SimpleCard";
            this.Size = new System.Drawing.Size(500, 590);
            this.Resize += new System.EventHandler(this.SimpleCard_Load);
            this.pnlLetters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel pnlLetters;
        public System.Windows.Forms.Panel pnlGame;
    }
}
