using Microsoft.EntityFrameworkCore;

namespace ConcertVenue.Models
{
  public class ConcertVenueContext : DbContext
  {
    public DbSet<Event> Events { get; set; }
    public DbSet<Band> Bands { get; set; }
    public DbSet<EventBand> EventBand { get; set; }

    public ConcertVenueContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}