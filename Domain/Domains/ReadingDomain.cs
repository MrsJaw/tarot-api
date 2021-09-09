using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotApi.Domain.Models;
using TarotApi.Domain.Providers;

namespace TarotApi.Domain.Domains
{

    public interface IReadingDomain
    {
        public IEnumerable<Draw> DoTarotReading(ReadingType type);
    }

    public class ReadingDomain : IReadingDomain
    {
        private IReader _reader;
        private Random _rando = new Random();

        public ReadingDomain(IReader readingProvider) => _reader = readingProvider;

        public IEnumerable<Draw> DoTarotReading(ReadingType type)
        {
            if (!_reader.Mat.ContainsKey(type))
                return null;

            var mat =  _reader.Mat[type];
            Stack<Card> shuffle = new Stack<Card>( _reader.Deck.OrderBy(x => _rando.NextDouble()));
            mat.ForEach(d => d.Card = shuffle.Pop());

            return mat;
        }
    }
}
