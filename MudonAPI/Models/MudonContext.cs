using Microsoft.EntityFrameworkCore;

namespace MudonAPI.Models
{
    public class MudonContext:DbContext
    {
        public MudonContext(DbContextOptions<MudonContext> options): base(options)
        {

        }

        public DbSet<Film> Films { get; set; }
    }
}
