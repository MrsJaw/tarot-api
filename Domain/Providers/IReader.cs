using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotApi.Domain.Models;

namespace TarotApi.Domain.Providers
{
    public interface IReader
    {
        public List<Card> Deck { get; }
        public Dictionary<ReadingType, List<Draw>> Mat { get; }
    }
}
