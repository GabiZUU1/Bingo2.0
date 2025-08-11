using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Bingo2._0
{
    public partial class SimpleCard : Panel
    {
        public SimpleCard()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void SimpleCard_Load(object sender, EventArgs e)
        {
            
        }
    }
}
