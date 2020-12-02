using Microsoft.EntityFrameworkCore;

namespace CloudCraftHistory.Data
{
    public class CloudCraftHistoryContext : DbContext
    {
        public CloudCraftHistoryContext (
            DbContextOptions<CloudCraftHistoryContext> options)
            : base(options)
        {
        }

        public DbSet<CloudCraftHistory.Models.Member> Member { get; set; }
    }
}