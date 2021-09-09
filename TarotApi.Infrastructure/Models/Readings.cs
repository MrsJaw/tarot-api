using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarotApi.Domain.Models;

namespace TarotApi.Infrastructure.Models
{
    public class Readings
    {
        public Dictionary<ReadingType, List<Draw>> Draws { get; set; }
        public Readings()
        {
            Draws = new Dictionary<ReadingType, List<Draw>>();
            Draws.Add(ReadingType.SingleCard, new List<Draw>()
                                              {
                                                  new Draw(0, "Your Answer")
                                              });
            Draws.Add(ReadingType.WaxingCrescent, new List<Draw>()
                                              {
                                                  new Draw(0, "What are your talents that will be called upon?"),
                                                  new Draw(1, "How does your environment influence your intention?"),
                                                  new Draw(2, "What resources are available to you to help you achieve your goal?"),
                                                  new Draw(3, "What are the things you cannot change?"),
                                                  new Draw(4, "What are the things you must change in order to succeed?"),
                                                  new Draw(5, "How do all of these influences come together?"),
                                              });
            Draws.Add(ReadingType.MindBodySpirit, new List<Draw>()
                                              {
                                                  new Draw(0, "The state of your Mind"),
                                                  new Draw(1, "The state of your Body"),
                                                  new Draw(1, "The state of your Spirit")
                                              });
            Draws.Add(ReadingType.BrickByBrick, new List<Draw>()
                                              {
                                                  new Draw(0, "What is your purpose in your job?"),
                                                  new Draw(1, "What is your motivation in your job?"),
                                                  new Draw(2, "What are your responsibilities in your job?"),
                                                  new Draw(3, "How are your projects going?"),
                                                  new Draw(4, "What will you gain from this job?"),
                                                  new Draw(5, "What is a possible future of this career path?"),
                                                  new Draw(6, "What is a possible future of this career path?"),
                                              });
        }
    }
}
