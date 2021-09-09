using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarotApi.ViewModels
{
    public class DrawViewModel
    {
        public int Index { get; set; }
        public string Role { get; set; }
        public bool IsReversed { get; set; }
        public CardViewModel Card { get; set; }
    }
}
