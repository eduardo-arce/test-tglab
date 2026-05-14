using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RouletteGame.Models;

namespace RouletteGame.Services
{
    public class RouletteService
    {
        public async Task<int> PrizeDraw()
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
            return prizeDraw;
        }

        public async Task<int> FullNumber(Bet bet, int prizeDraw)
        {
            if (prizeDraw == bet.SelectedNumber)
            {
                return bet.Amount * 36;
            }
            return bet.Amount * 0;
        }

        public async Task<int> OneToTwelve(Bet bet, int prizeDraw)
        {
            if (prizeDraw == 0)
            {
                return bet.Amount * 0;
            }
            if (prizeDraw <= 12 && bet.SelectedNumber <= 12)
            {
                return bet.Amount * 3;
            }
            return bet.Amount * 0;
        }

        public async Task<int> ThirteenToTwentyFour(Bet bet, int prizeDraw)
        {
            if (prizeDraw >= 13 && prizeDraw <= 24 &&
                bet.SelectedNumber >= 13 && bet.SelectedNumber <= 24)
            {
                return bet.Amount * 3;
            }
            return bet.Amount * 0;
        }

        public async Task<int> TwentyFiveToThirtySix(Bet bet, int prizeDraw)
        {
            if (prizeDraw >= 25 && prizeDraw <= 36 &&
                bet.SelectedNumber >= 25 && bet.SelectedNumber <= 36)
            {
                return bet.Amount * 3;
            }
            return bet.Amount * 0;
        }

        public async Task<int> IsOdd(Bet bet, int prizeDraw)
        {
            if (prizeDraw == 0)
            {
                return bet.Amount * 0;
            }
            if (prizeDraw % 2 != 0)
            {
                return bet.Amount * 2;
            }
            return bet.Amount * 0;
        }

        public async Task<int> IsEven(Bet bet, int prizeDraw)
        {
            if (prizeDraw == 0)
            {
                return bet.Amount * 0;
            }
            if (prizeDraw % 2 == 0)
            {
                return bet.Amount * 2;
            }
            return bet.Amount * 0;
        }
    }
}
