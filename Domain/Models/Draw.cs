using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarotApi.Domain.Models
{
    public class Draw
    {
        private Card _card;
        private Random _rand = new Random();

        public int Index { get; set; }
        public string Role { get; set; }       
        public bool IsReversed { get; set; }
        public Card Card
        {
            get { return _card; }
            set
            {
                _card = value;
                IsReversed = _rand.NextDouble() > 0.5;
            }
        }

        public Draw() { }

        public Draw(int index, string role)
        {
            Index = index;
            Role = role;
        }
    }
}
