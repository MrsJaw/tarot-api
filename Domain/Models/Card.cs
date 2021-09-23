namespace TarotApi.Domain.Models
{
    public class Card
    {
        public string Name { get; set; }
        public string ImgSrc { get; set; }
        public string Meanings { get; set; }
        public string ReverseMeanings { get; set; }

        public Card() { }

        public Card(string name, string imgSrc, string meanings, string reverseMeanings)
        {
            Name = name;
            ImgSrc = imgSrc;
            Meanings = meanings;
            ReverseMeanings = reverseMeanings;
        }
    }
}
