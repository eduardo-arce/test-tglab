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
        public RouletteService()
        {

        }

        public async Task<int> FullNumber(Bet bet)
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
            if (prizeDraw == bet.SelectedNumber)
            {
                return bet.Amount * 36;

            }
            return bet.Amount * 0;
        }

        public async Task<int> OneToTwelve(Bet bet)
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
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

        public async Task<int> ThirteenToTwentyFour(Bet bet)
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
            if (prizeDraw >= 13 && prizeDraw <= 24 &&
                bet.SelectedNumber >= 13 && bet.SelectedNumber <= 24)
            {
                return bet.Amount * 3;
            }
            return bet.Amount * 0;
        }

        public async Task<int> IsOdd(Bet bet)
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
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

        public async Task<int> IsEven(Bet bet)
        {
            Random rnd = new Random();
            int prizeDraw = rnd.Next(37);
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
