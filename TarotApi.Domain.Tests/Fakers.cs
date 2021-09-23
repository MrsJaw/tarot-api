using Bogus;
using TarotApi.Domain.Models;

namespace TarotApi.Domain.Tests
{
    public class Fakers
    {
        private static readonly int _seed = 19191165;

        public static Faker<Draw> DrawFaker = new Faker<Draw>()
            .StrictMode(true)
            .UseSeed(_seed)
            .Ignore(d => d.Card)
            .Ignore(d => d.IsReversed)
            .RuleFor(d => d.Index, p => p.IndexFaker++)
            .RuleFor(d => d.Role, p => p.Lorem.Sentence())
            ;

        public static Faker<Card> CardFaker = new Faker<Card>()
            .StrictMode(true)
            .UseSeed(_seed)
            .RuleFor(c => c.ImgSrc, p => p.Image.LoremFlickrUrl())
            .RuleFor(c => c.Meanings, p => p.Lorem.Sentence())
            .RuleFor(c => c.Name, p => p.Name.JobTitle())
            .RuleFor(c => c.ReverseMeanings, p => p.Lorem.Sentence())
            ;
    }
}
