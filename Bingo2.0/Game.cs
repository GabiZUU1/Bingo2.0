using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo2._0
{
    internal class Game
    {
        private List<SimpleCard> cards = new List<SimpleCard>();
        public int numberOfCards { get; set; } = 1;

        public Game(GameType type, int cardsNumber = 1)
        {
            numberOfCards = cardsNumber;

            switch(type)
            {
                case GameType.American:
                    break;
                case GameType.British:
                    new Exception("Not implemented yet");
                    return;
            }
        }
    }

    public enum GameType
    {
        American,
        British
    }
}
