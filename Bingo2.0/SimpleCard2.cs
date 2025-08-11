using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo2._0
{
    public class SimpleCard2 : Panel
    {
        public SimpleCard2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void InitializeComponent()
        {
            #region Sizing
            if (this.Size == new Size(500, 590)) return;

            int X = 0;
            pnlLetters.Size = new Size(this.Width - 20, (int)(this.Height * (12.71 / 100)));
            pnlLetters.BackColor = Color.BlueViolet;
            foreach (Label letter in pnlLetters.Controls.OfType<Label>())
            {
                letter.Size = new Size(pnlLetters.Width / 5, pnlLetters.Height);
                letter.Location = new Point(X, 0);
                letter.BackColor = Color.FromArgb(X / 3, 100, 100);
                X = X + pnlLetters.Width / 5;
            }

            pnlGame.Size = new Size(this.Width - 20, this.Height - 100);
            pnlGame.Location = new Point(10, pnlLetters.Location.Y + pnlLetters.Height + 3);
            #endregion
        }


        // remake the desing from code


    }
}
