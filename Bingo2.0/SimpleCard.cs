using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Bingo2._0
{
    internal class SimpleCard : Panel
    {
        #region Children
        private Panel pnlLetters;
        public Panel pnlGame;
        private Label lbl1;
        private Label lbl2;
        private Label lbl3;
        private Label lbl4;
        private Label lbl5;
        #endregion

        private readonly Size DefSize = new Size(500, 590);

        public SimpleCard()
        {
            this.Size = DefSize;
            this.BackColor = Color.AntiqueWhite;

            pnlLetters = new Panel();
            pnlLetters.Location = new Point(10, 0);
            pnlLetters.Size = new Size(this.Width - 20, 75);

            pnlGame = new Panel();
            pnlGame.Location = new Point(10, pnlLetters.Location.Y + pnlLetters.Height + 3);
            pnlGame.Size = new Size(this.Width - 20, this.Height - 90);
            pnlGame.BackColor = Color.Khaki;

            lbl1 = new Label();
            lbl1.Text = "B";
            lbl1.Location = new Point(0, 0);

            lbl2 = new Label();
            lbl2.Text = "I";
            lbl2.Location = new Point(lbl1.Location.X + lbl1.Width, 0);
            
            lbl3 = new Label();
            lbl3.Text = "N";
            lbl3.Location = new Point(lbl2.Location.X + lbl2.Width, 0);

            lbl4 = new Label();
            lbl4.Text = "G";
            lbl4.Location = new Point(lbl3.Location.X + lbl3.Width, 0);

            lbl5 = new Label();
            lbl5.Text = "O";
            lbl5.Location = new Point(lbl4.Location.X + lbl4.Width, 0);

            lbl1.Size = lbl2.Size = lbl3.Size = lbl4.Size = lbl5.Size = new Size(pnlLetters.Width / 5, 75);
            lbl1.TextAlign = lbl2.TextAlign = lbl3.TextAlign = lbl4.TextAlign = lbl5.TextAlign = ContentAlignment.MiddleCenter;
            lbl1.Font = lbl2.Font = lbl3.Font = lbl4.Font = lbl5.Font = new Font("Franklin Gothic Heavy", 30, FontStyle.Bold);

            pnlLetters.Controls.Add(lbl1);
            pnlLetters.Controls.Add(lbl2);
            pnlLetters.Controls.Add(lbl3);
            pnlLetters.Controls.Add(lbl4);
            pnlLetters.Controls.Add(lbl5);
            this.Controls.Add(pnlLetters);
            this.Controls.Add(pnlGame);
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            if (this.Parent == null) return;

            pnlLetters.Size = new Size(this.Width - 20, (int)(this.Height * (12.71/100)));
            pnlLetters.Location = new Point(10, 0);

            pnlGame.Size = new Size(this.Width - 20, (int)(this.Height * (84.74 / 100)));
            pnlGame.Location = new Point(10, pnlLetters.Location.Y + pnlLetters.Height + 3);

            int x = 0;
            foreach(Label l in pnlLetters.Controls.OfType<Label>())
            {
                l.Size = new Size(pnlLetters.Width / 5, pnlLetters.Height);
                l.Location = new Point(x, 0);
                x = x + pnlLetters.Width / 5;
            }
        }
    }
}
