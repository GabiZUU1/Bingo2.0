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
    public partial class SimpleCell : UserControl
    {
        private object _content = null;
        public object Content
        {
            get
            {
                if (_content is string) return _content.ToString();
                else return Convert.ToInt32(_content);
            }

            set
            {
                if(value is string) _content = value.ToString();
                else _content = Convert.ToInt32(value);

                lblContent.Text = _content.ToString();
            }
        }

        public SimpleCell()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.UserPaint, true);
        }

        private void SimpleCell_Load(object sender, EventArgs e)
        {
            if (this.Parent?.Size != new Size(480, 500)) return;

            this.Size = new Size(this.Parent.Width / 5, this.Parent.Height / 5);
        }
    }
}
