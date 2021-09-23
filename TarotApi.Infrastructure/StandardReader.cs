using System.Collections.Generic;
using TarotApi.Domain.Models;
using TarotApi.Domain.Providers;
using TarotApi.Infrastructure.Models;

namespace TarotApi.Infrastructure
{
    public class StandardReader : IReader
    {
        private RiderWaiteDeck _deck;
        private Readings _readings;

        public StandardReader()
        {
            _deck = new RiderWaiteDeck();
            _readings = new Readings();
        }

        public List<Card> Deck => _deck.Cards;

        public Dictionary<ReadingType, List<Draw>> Mat => _readings.Draws;
    }
}
