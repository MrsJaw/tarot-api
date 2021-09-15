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
        public async Task Do_Reading_Tests()
        {
            await Do_Reading(ReadingType.SingleCard, 1);
            await Do_Reading(ReadingType.MindBodySpirit, 3);
            await Do_Reading(ReadingType.BrickByBrick, 7);
            await Do_Reading(ReadingType.WaxingCrescent, 6);
        }

        public async Task Do_Reading(ReadingType type, int expectedCardCount)
        {
            var response = await TarotController.GET_DoReadingAsync(_client, type.ToString());
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            var reading = await response.ReadJsonResponse<ReadingViewModel>();
            reading.Draws.Count().Should().Be(expectedCardCount);
            var firstReading = reading.Draws.Select(d => d.Card);

            response = await TarotController.GET_DoReadingAsync(_client, type.ToString());
            response.StatusCode.Should().Be(System.Net.HttpStatusCode.OK);
            reading = await response.ReadJsonResponse<ReadingViewModel>();
            reading.Draws.Count().Should().Be(expectedCardCount);
            var secondReading = reading.Draws.Select(d => d.Card);
            secondReading.Should().NotContainInOrder(firstReading);

        }
    }
}
