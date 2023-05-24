using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PlayGo.Infrastructure.SeedData;
using PlayGo.Models.Concrete;

namespace PlayGo.Infrastructure.Context
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
       

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
            //Database.Migrate();
           
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /////////////admin giriş//////////////////////////////////////
            string adminId = "02174cf0–9412–4cfe-afbf-59f706d72cf6";
            string roleId = "341743f0-asd2–42de-afbf-59kmkkmk72cf6";

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp=roleId
            });
            var hasher = new PasswordHasher<IdentityUser>();

            var appUser = new AppUser
            {
                Id = adminId,
                UserName = "Admin",
                Email = "admin@playgo.com",
                EmailConfirmed = false,
                NormalizedUserName = "ADMIN"
            };

            PasswordHasher<AppUser> passwordHas=new PasswordHasher<AppUser>();
            appUser.PasswordHash = passwordHas.HashPassword(appUser, "123");

            modelBuilder.Entity<AppUser>().HasData(appUser);

            modelBuilder.Entity<IdentityUserRole<string>>().HasData
                (new IdentityUserRole<string>
                {
                    RoleId = roleId,
                    UserId = adminId
                });
            ///////////////////////////////////////////////////////////////
            
            modelBuilder.Entity<Product>().Property(x => x.UnitPrice).HasColumnType("decimal").HasPrecision(8,2);
            modelBuilder.ApplyConfiguration(new CategorySeedData());
            modelBuilder.ApplyConfiguration(new ProductSeedData());
            base.OnModelCreating(modelBuilder);

        }
    }
}
