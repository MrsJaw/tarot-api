using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotApi.Domain.Models;

namespace TarotApi.Infrastructure.Models
{
    public class RiderWaiteDeck
    {
        public List<Card> Cards { get; private set; }

        public RiderWaiteDeck()
        {
            Cards = new List<Card>()
            {
                //MAJOR ARCANA
                new Card("The Fool", 
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_00_Fool.jpg",
                         "Innocence, Beginnings, Adventure",
                         "Naiveté, Recklesness, Gullible"),
                new Card("The Magician",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_01_Magician.jpg",
                         "Willpower, Creation, Mastery",
                         "Manipulation, Destruction, Untapped Potential"),
                new Card("The High Priestess",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_02_High_Priestess.jpg",
                         "Intuition, Inner Voice, Spirituality",
                         "Confusion, Repressed Inner Voice, Superficiality"),
                new Card("The Empress",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_03_Empress.jpg",
                         "Fertility, Nurturing, Abundance",
                         "Negligence, Smothering"),
                new Card("The Emperor",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_04_Emperor.jpg",
                         "Stability, Authority, Protection",
                         "Rigid, Domineering, Tyranny"),
                new Card("The Hierophant",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_05_Hierophant.jpg",
                         "Tradition, Conformity, Knowledge",
                         "Rebellion, Non-conformity, Ignorance"),
                new Card("The Lovers",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_06_Lovers.jpg",
                         "Love, Partnerships, Unity",
                         "Detachment, Disharmony, Conflict"),
                new Card("The Chariot",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_07_Chariot.jpg",
                         "Victory, Ambition, Determination",
                         "Forceful, No control, Aggression"),
                new Card("Strength",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_08_Strength.jpg",
                         "Strength, Courage, Inner Power",
                         "Weakness, Self-Doubt, Cowardice"),
                new Card("The Hermit",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_09_Hermit.jpg",
                         "Introspection, Solitude, Contemplation",
                         "Isolation, Loneliness, Recluse"),
                new Card("The Wheel of Fortune",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_10_Wheel_of_Fortune.jpg",
                         "Important Changes, Cycles, Fate, Luck",
                         "Back Luck, Unwelcome Changes, Delays"),
                new Card("Justice",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_11_Justice.jpg",
                         "Justice, Karma, Consequence, Truth",
                         "Injustice, Retribution, Corruption"),
                new Card("The Hanged Man",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_12_Hanged_Man.jpg",
                         "Sacrifice",
                         "Selfishness, Apathy"),
                new Card("Death",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_13_Death.jpg",
                         "Transformation, Endings, Letting Go",
                         "Fear of Change, Stagnancy, Decay"),
                new Card("Temperance",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_14_Temperance.jpg",
                         "Balance, Moderation, Patience",
                         "Imbalance, Excess, Hastiness"),
                new Card("The Devil",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_15_Devil.jpg",
                         "Obsession, Oppression, Materialism",
                         "Independence, Freedom, Reclamation of Power"),
                new Card("The Tower",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_16_Tower.jpg",
                         "Destruction, Hubris, Disaster",
                         "Averting Disaster, Delaying the Inevitable"),
                new Card("The Star",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_17_Star.jpg",
                         "Hope, Inspiration, Rejuvenation",
                         "Hopelessness, Despair, Negativity"),
                new Card("The Moon",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_18_Moon.jpg",
                         "Illusion, Duality, Secrets",
                         "Misunderstanding, Anxiety, Confusion"),
                new Card("The Sun",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_19_Sun.jpg",
                         "Happiness, Vitality, Optimism",
                         "Unrealistic Expectations, Pessimism, Blocked Happiness"),
                new Card("Judgement",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_20_Judgement.jpg",
                         "Judgement, Self-evaluation, Reckoning",
                         "Lack of Self-Awareness, Failure to Learn Lessons"),
                new Card("The World",
                         "https://en.wikipedia.org/wiki/Rider%E2%80%93Waite_tarot_deck#/media/File:RWS_Tarot_21_World.jpg",
                         "Completion, Fulfillment, Belonging",
                         "Incompletion, Emptiness, Lack of Closure"),
            };
        }
    }
}
