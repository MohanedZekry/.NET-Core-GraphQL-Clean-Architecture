using AnimeGraphQL.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimeGraphQL.Persistence.Context
{
    public class AnimeContext : DbContext
    {
        public AnimeContext(DbContextOptions<AnimeContext> options) : base(options)
        {
        }

        public DbSet<Anime> Animes { get; set; }
    }
}
