using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Bingo2._0
{
    internal class AmericanCard : SimpleCard
    {
        public SimpleCell[,] Cells { get; set; } = new SimpleCell[5, 5];

        private static Random _rnd = new Random();
        private List<int> _generatedNumbers = new List<int>();

        public AmericanCard()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Cells[i,j] = new SimpleCell();
                    SimpleCell c = Cells[i, j];
                    c.Location = new Point(i * c.Width, j * c.Height);

                    if (i == 2 && j == 2)
                    {
                        c.Content = "FREE";
                    }
                    else
                    {
                        int n;
                        do
                        {
                            n = GenerateNumber(i);
                        } while (_generatedNumbers.Contains(n));
                        _generatedNumbers.Add(n);
                        c.Content = n;
                    }

                    this.pnlGame.Controls.Add(c);
                }
            }
        }

        private int GenerateNumber(int column)
        {
            switch(column)
            {
                case 0:
                    return _rnd.Next(1, 16);
                case 1:
                    return _rnd.Next(16, 31);
                case 2:
                    return _rnd.Next(31, 46);
                case 3:
                    return _rnd.Next(46, 61);
                case 4:
                    return _rnd.Next(61, 76);
                default:
                    return 0;
            }
        }
    }
}
