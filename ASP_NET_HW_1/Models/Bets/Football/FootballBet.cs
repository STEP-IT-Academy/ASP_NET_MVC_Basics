namespace ASP_NET_HW_1.Models.Bets.Football
{
    public class FootballBet
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public double Coefficient { get; set; }

        public decimal Bet { get; set; }

        public int GameScheduleId { get; set; }
    }
}