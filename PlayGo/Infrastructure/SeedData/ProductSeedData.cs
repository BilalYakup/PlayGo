using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlayGo.Models.Concrete;

namespace PlayGo.Infrastructure.SeedData
{
    public class ProductSeedData : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData
                (
                    new Product { Id = 1, Name = "Counter-Strike: Global Offensive",Description= "Counter-Strike: Global Offensive (CS: GO), 19 yıl önce ilk çıktığında öncülük ettiği takım tabanlı aksiyon oyununu bir üst seviyeye taşıyor. CS:GO yeni haritalar, karakterler, silahlar ve oyun modları, ayrıca klasik CS içeriğinin (de_dust2 vb.) güncellenmiş sürümlerini sunuyor.",UnitPrice=99,Image= "csgo.jpg", CategoryId=1},

                    new Product { Id = 2, Name = "Fifa23", Description = "FIFA 23, HyperMotion2 Teknolojisi, erkekler ve kadınlar FIFA World Cup™’ın sezon sırasında gelmesi, kadın kulüp takımları, çapraz oyun özellikleri* ve daha fazlası ile Dünyanın Oyunu'nu sahaya çıkarıyor.", UnitPrice = 359, Image = "fifa23.jpg", CategoryId = 2 },

                    new Product { Id = 3, Name = "WWE 2K22", Description = "\r\nYENİDEN TASARLANAN OYUN MOTORU. YENİ KONTROLLER. KULLANIMA AÇIK TÜM ÖZELLİKLER. Tribünlerden sıyrıl ve WWE Evreni'nin tam kontrolünü ele geçirip vur gitsin. Bu kadar sert vurmak hiç bu kadar kolay olmamıştı. WWE 2K22: IT HITS DIFFERENT", UnitPrice = 429, Image = "WWE2K22.jpg", CategoryId = 3 },

                    new Product { Id = 4, Name = "Euro Truck Simulator 2", Description = "\r\nÖnemli yüklerinizi kamyonunuzla akıl almaz mesafelere teslim edin, Avrupa'yı bir uçtan uca dolaşırken yolların kralı olun! İngiltere, Belçika, Almanya, İtalya, Hollanda, Polonya ve pek çok diğer ülkede keşfedilecek düzinelerce şehir var. Dayanıklılık, beceri ve hız sınırlarınız zorlanacak.", UnitPrice = 149, Image = "eurotrucksimulator2.jpg", CategoryId = 4 },

                    new Product { Id = 5, Name = "Total War: WARHAMMER III", Description = "\r\nTotal War: WARHAMMER üçlemesinin dehşet verici son oyunu burada. Kuvvetlerinizi toplayın ve dünyanın kaderinin belirleneceği, akıl almaz bir dehşet boyutu olan Kaos Diyarı’na adım atın. Ya iblislerinizi fethedin ya da onları komuta edin!", UnitPrice = 799, Image = "totalwarwahammer.jpg", CategoryId = 5 }
                );
        }
    }
}
