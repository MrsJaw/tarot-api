using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TarotApi.Domain.Models;
using TarotApi.IntegrationTests.Controllers;
using TarotApi.ViewModels;

namespace TarotApi.IntegrationTests
{
    [TestClass]
    public class TarotTests
    {
        private HttpClient _client;

        [TestInitialize]
        public void TestInitialize()
        {
            var factory = new TestTarotApiFactory();
            _client = factory.CreateClient();
        }

        [TestMethod]
        public async Task GetReadingsTest()
        {
            var response = await TarotController.GET_GetReadingTypesAsync(_client);
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var readingTypes = await response.ReadJsonResponse<IEnumerable<string>>();
            readingTypes.Should().ContainInOrder(Enum.GetNames(typeof(ReadingType)));
        }

        [TestMethod]
        public async Task Do_Single_Card_Reading_Test()
        {
            var response = await TarotController.GET_DoReadingAsync(_client, ReadingType.SingleCard.ToString());
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var reading = await response.ReadJsonResponse<ReadingViewModel>();
            reading.Draws.Count().Should().Be(1);
            var firstReading = reading.Draws.Select(d => d.Card);

            response = await TarotController.GET_DoReadingAsync(_client, ReadingType.SingleCard.ToString());
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            reading = await response.ReadJsonResponse<ReadingViewModel>();
            reading.Draws.Count().Should().Be(1);
            var secondReading = reading.Draws.Select(d => d.Card);
            secondReading.Should().NotContainInOrder(firstReading);

        }
    }
}
