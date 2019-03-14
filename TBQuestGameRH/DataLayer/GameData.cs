using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TBQuestGameRH.Models;

namespace TBQuestGameRH.DataLayer
{
    public static class GameData
    {

        public static Player PlayerData()
        {
            return new Player()
            {
                ID = 1,
                Name = "Raoul Duke",
                CurrentLevel = Player.Level.One,
                CurrentStatus = Player.Status.Hallucinating,
                HP = 100,
                LocationId = 0,
            };
        }

        public static List<string> InitialMessages()
        {
            return new List<string>()
            {
                "We were somewhere around Barstow, near the edge of the desert, when the drugs began to take hold."
            };
        }
    }
}
