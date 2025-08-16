using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Markup;

namespace Bingo2._0
{
    internal class SimpleCell : Label
    {
        private object _content;
        public object Content
        {
            get
            {
                if (_content is string) return _content.ToString();
                else if (_content is int) return Convert.ToInt32(_content);
                else return new Exception("Content is neither string or int");
            }
            set
            {
                if (value is string)
                {
                    _content = value.ToString();
                    this.Text = _content.ToString();
                }
                else if (value is int)
                {
                    _content = Convert.ToInt32(value);
                    this.Text = _content.ToString();
                }
                else new Exception("Content is neither string or int");
                
            }
        }

        public SimpleCell()
        {
            this.AutoSize = false;
            this.Size = new Size(96, 100);
            this.BorderStyle = BorderStyle.FixedSingle;
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Microsoft Sans Serif", 20f);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.Parent == null) return;
        }
    }
}