using la5.Models;
using Microsoft.EntityFrameworkCore;


namespace la5.Models
{
    public class RoleDb : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<RoleModel> Roles { get; set; }
        public RoleDb(DbContextOptions<RoleDb> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "admin@mail.ru";
            string adminPassword = "123456";

            RoleModel adminRole = new RoleModel { ID = 1, Name = adminRoleName };
            RoleModel userRole = new RoleModel { ID = 2, Name = userRoleName };
            UserModel adminUser = new UserModel { ID = 1, Email = adminEmail, Password = adminPassword, RoleModelID = adminRole.ID };

            modelBuilder.Entity<RoleModel>().HasData(new RoleModel[] { adminRole, userRole });
            modelBuilder.Entity<UserModel>().HasData(new UserModel[] { adminUser });
            base.OnModelCreating(modelBuilder);
        }
    }
}
