using System;

namespace ASP_NET_HW_1.Models.Bets.Football
{
    public class GameSchedule
    {
        public int Id { get; set; }

        public DateTime GameDate { get; set; }

        public string HomeTeamName { get; set; }

        public string GuestTeamName { get; set; }

        public string StadiumName { get; set; }

        public double HomeTeamCoefficient { get; set; }

        public double DrawCoefficient { get; set; }

        public double GuestTeamCoefficient { get; set; }
    }
}