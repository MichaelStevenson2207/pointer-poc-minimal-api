using Microsoft.EntityFrameworkCore;
using pointer_poc_minimal_api.Data.Entities;

namespace pointer_poc_minimal_api.Data
{
    public class PointerContext : DbContext
    {
        public PointerContext(DbContextOptions<PointerContext> options)
            : base(options)
        {
        }

        public DbSet<Pointer> Pointer => Set<Pointer>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pointer>()
                .HasData(
                    new Pointer
                    {
                        Id = 1,
                        BuildingNumber = "20",
                        BuildingStatus = "BUILT",
                        PrimaryThorfare = "DONEGALL QUAY",
                        Town = "BELFAST",
                        PostTown = "BELFAST",
                        LocalCouncil = "BELFAST",
                        TownLand = "TOWN PARKS",
                        County = "ANTRIM",
                        AddressStatus = "APPROVED",
                        Postcode = "BT1 1AA"
                    });
        }
    }
}