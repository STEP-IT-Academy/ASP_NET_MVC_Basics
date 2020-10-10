using System.Data.Entity;
using ASP_NET_HW_1.Models.Bets.Football;

namespace ASP_NET_HW_1.Models
{
    public class FootballBetContext : DbContext
    {
        public DbSet<FootballBet> FootballBets { get; set; }
    }
}