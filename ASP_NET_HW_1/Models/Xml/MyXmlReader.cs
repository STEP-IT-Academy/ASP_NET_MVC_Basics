using ASP_NET_HW_1.Models.Bets.Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ASP_NET_HW_1.Models.Xml
{
    public static class MyXmlReader
    {
        public static IEnumerable<GameSchedule> GetGamesSchedule(string filePath) =>
            XElement.Load(filePath).Elements("game").Select(element => new GameSchedule
            {
                Id = Convert.ToInt32(element.Attribute("id")?.Value),
                GameDate = Convert.ToDateTime(element.Attribute("gameDate")?.Value),
                HomeTeamName = element.Element("homeTeam")?.Value,
                GuestTeamName = element.Element("guestTeam")?.Value,
                StadiumName = element.Element("stadium")?.Value,
                HomeTeamCoefficient = Convert.ToDouble(element.Element("homeTeamCoeff")?.Value),
                DrawCoefficient = Convert.ToDouble(element.Element("drawCoeff")?.Value),
                GuestTeamCoefficient = Convert.ToDouble(element.Element("guestTeamCoeff")?.Value)
            });

        public static GameSchedule GetGameScheduleById(int? id, string filePath)
        {
            var element = XElement.Load(filePath).Elements("game").FirstOrDefault(e => Convert.ToInt32(e.Attribute("id")?.Value) == id);
            if (element != null)
                return new GameSchedule
                {
                    Id = Convert.ToInt32(element.Attribute("id")?.Value),
                    GameDate = Convert.ToDateTime(element.Attribute("gameDate")?.Value),
                    HomeTeamName = element.Element("homeTeam")?.Value,
                    GuestTeamName = element.Element("guestTeam")?.Value,
                    StadiumName = element.Element("stadium")?.Value,
                    HomeTeamCoefficient = Convert.ToDouble(element.Element("homeTeamCoeff")?.Value),
                    DrawCoefficient = Convert.ToDouble(element.Element("drawCoeff")?.Value),
                    GuestTeamCoefficient = Convert.ToDouble(element.Element("guestTeamCoeff")?.Value)
                };
            return null;
        }
    }
}