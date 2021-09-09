using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Linq;
using TarotApi.Domain.Domains;
using TarotApi.Domain.Models;
using TarotApi.Domain.Providers;

namespace TarotApi.Domain.Tests
{
    [TestClass]
    public class ReadingDomainTests
    {
        private Mock<IReader> _readingProvider;
        private ReadingDomain _readingDomain;

        [TestInitialize]
        public void Initialize()
        {
            _readingProvider = new Mock<IReader>();
            _readingDomain = new ReadingDomain(_readingProvider.Object);
        }

        [TestMethod]
        public void Do_Valid_Reading_Test()
        {
            var cards = new List<Card>();
            var reading = new Dictionary<ReadingType, List<Draw>>();

            reading.Add(ReadingType.MindBodySpirit, new List<Draw>());
            for(int i = 0; i < 78; i++)
            {
                var draw = Fakers.DrawFaker.Generate();
                reading[ReadingType.MindBodySpirit].Add(draw);

                cards.Add(Fakers.CardFaker.Generate());
            }

            _readingProvider.Setup(moq => moq.Mat)
                .Returns(reading);
            _readingProvider.Setup(moq => moq.Deck)
                .Returns(cards);

            var result = _readingDomain.DoTarotReading(ReadingType.MindBodySpirit);

            result.Count().Should().Be(3);
            result.Select(d => d.Card).Should().Contain(cards);                
            result.Select(d => d.Card).Should().NotContainInOrder(cards);                
        }
    }
}
