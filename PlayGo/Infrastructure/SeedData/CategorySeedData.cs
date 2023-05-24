using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayGo.Models.Concrete;

namespace PlayGo.Infrastructure.SeedData
{
    public class CategorySeedData : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData
                (
                    new Category { Id = 1, Name = "Aksiyon", Image = "aksiyon.jpeg" },
                    new Category { Id = 2, Name = "Spor", Image = "spor.jpeg" },
                    new Category { Id = 3, Name = "Dövüş", Image = "dövüş.jpg" },
                    new Category { Id = 4, Name = "Simulasyon", Image = "simulasyon.jpg" },
                    new Category { Id = 5, Name = "Strateji", Image = "strateji.jpg" }
                );
        }
    }
}
