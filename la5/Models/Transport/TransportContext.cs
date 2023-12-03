using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace tr.Models.Transport
{
    public class TransportContext : DbContext
    {
        public DbSet<TransportModel> Transports { get; set; }
        public TransportContext(DbContextOptions<TransportContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            TransportModel testData1 = new TransportModel
            {
                ID = 1,
                Brand = "Бмв",
                Country = "Германия",
                Date = new DateTime(2001, 4, 7),
                Price = 60000
            };

            TransportModel testData2 = new TransportModel
            {
                ID = 2,
                Brand = "Лада",
                Country = "Россия",
                Date = new DateTime(2006, 4, 26),
                Price = 50000
            };

            TransportModel testData3 = new TransportModel
            {
                ID = 3,
                Brand = "Ламборгини",
                Country = "Италия",
                Date = new DateTime(2010, 4, 9),
                Price = 2000000
            };

            modelBuilder.Entity<TransportModel>().HasData(new TransportModel[] { testData1, testData2, testData3 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
