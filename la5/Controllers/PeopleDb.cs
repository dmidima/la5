
using Microsoft.EntityFrameworkCore;
using la5.Models;

namespace la5.Data
{
    public class PeopleDb : DbContext
    {
        public PeopleDb(DbContextOptions<PeopleDb> options) : base(options)
        {
        }

        public DbSet<PeopleModel> Peoples { get; set; }
    }
}
