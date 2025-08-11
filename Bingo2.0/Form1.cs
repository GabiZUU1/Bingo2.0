using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AmericanCard c1 = new AmericanCard();
            AmericanCard c2 = new AmericanCard();
            this.Controls.Add(c1);
            c2.Location = new Point(c1.Location.X + c1.Width + 5, 0);
            this.Controls.Add(c2);
        }
    }
}
