using System.Data.Entity;

namespace ASP_NET_HW_1.Models.Bets.Football
{
    public class FootballBetContext : DbContext
    {
        public DbSet<FootballBet> FootballBets { get; set; }
    }
}