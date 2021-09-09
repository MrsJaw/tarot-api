using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarotApi.ViewModels
{
    public class CardViewModel
    {
        public string Name { get; set; }
        public string ImgSrc { get; set; }
        public string Meanings { get; set; }
        public string ReverseMeanings { get; set; }
    }
}
