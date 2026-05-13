using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouletteGame.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public string BetType { get; set; }
        public int Amount { get; set; }
        public int SelectedNumber { get; set; }
    }
}
