using ihalee.Models;
using Microsoft.EntityFrameworkCore;

namespace ihalee.Data
{
    public class ihaleeDBContext : DbContext
    {
        public ihaleeDBContext(DbContextOptions<ihaleeDBContext> options)
       : base(options)
        {
        }

        public DbSet<Buzdolabı> Buzdolapları { get; set; }
        public DbSet<Boyama> Boyamalar { get; set; }
        public DbSet<Renk> Renkler { get; set; }
        public DbSet<Araba> Arabalar { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Buzdolabı>().HasData(
new Buzdolabı { BuzdolabıID = 1, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 240, KapıSayısı = 1, Marka = "Beko", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 2, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 480, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 3, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 560, KapıSayısı = 4, Marka = "Arçelik", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 4, EnerjiSınıfı = "C", BuzlukTürü = "alttan kapı", Hacim = 420, KapıSayısı = 1, Marka = "Beko", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 5, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 560, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 6, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 280, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 7, EnerjiSınıfı = "C", BuzlukTürü = "dolap tipi", Hacim = 460, KapıSayısı = 3, Marka = "Samsung", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 8, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 260, KapıSayısı = 3, Marka = "Vestel", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 9, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 380, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 10, EnerjiSınıfı = "C", BuzlukTürü = "dolap tipi", Hacim = 460, KapıSayısı = 4, Marka = "Beko", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 11, EnerjiSınıfı = "A", BuzlukTürü = "dolap tipi", Hacim = 600, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 12, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 400, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 13, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 200, KapıSayısı = 3, Marka = "LG", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 14, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 440, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 15, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 220, KapıSayısı = 2, Marka = "LG", NoFrostMu = true, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 16, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 480, KapıSayısı = 2, Marka = "Arçelik", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 17, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 240, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 18, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 480, KapıSayısı = 1, Marka = "LG", NoFrostMu = true, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 19, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 3, Marka = "Bosch", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 20, EnerjiSınıfı = "A++", BuzlukTürü = "üstten kapı", Hacim = 400, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 21, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 200, KapıSayısı = 3, Marka = "LG", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 22, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 360, KapıSayısı = 1, Marka = "LG", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 23, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 280, KapıSayısı = 3, Marka = "Beko", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 24, EnerjiSınıfı = "C", BuzlukTürü = "dolap tipi", Hacim = 260, KapıSayısı = 3, Marka = "Beko", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 25, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 260, KapıSayısı = 1, Marka = "Bosch", NoFrostMu = false, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 26, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 27, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 220, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 28, EnerjiSınıfı = "A+", BuzlukTürü = "üstten kapı", Hacim = 500, KapıSayısı = 1, Marka = "Bosch", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 29, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 560, KapıSayısı = 2, Marka = "Beko", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 30, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 420, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 31, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 580, KapıSayısı = 3, Marka = "Vestel", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 32, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 280, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 33, EnerjiSınıfı = "A++", BuzlukTürü = "üstten kapı", Hacim = 340, KapıSayısı = 2, Marka = "Beko", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 34, EnerjiSınıfı = "A+", BuzlukTürü = "üstten kapı", Hacim = 560, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 35, EnerjiSınıfı = "A++", BuzlukTürü = "üstten kapı", Hacim = 280, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 36, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 200, KapıSayısı = 3, Marka = "Samsung", NoFrostMu = false, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 37, EnerjiSınıfı = "A", BuzlukTürü = "dolap tipi", Hacim = 540, KapıSayısı = 4, Marka = "Samsung", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 38, EnerjiSınıfı = "A", BuzlukTürü = "üstten kapı", Hacim = 400, KapıSayısı = 1, Marka = "Beko", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 39, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 200, KapıSayısı = 4, Marka = "Beko", NoFrostMu = false, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 40, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 320, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 41, EnerjiSınıfı = "C", BuzlukTürü = "üstten kapı", Hacim = 320, KapıSayısı = 2, Marka = "Beko", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 42, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 560, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 43, EnerjiSınıfı = "A", BuzlukTürü = "üstten kapı", Hacim = 320, KapıSayısı = 2, Marka = "LG", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 44, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 4, Marka = "Bosch", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 45, EnerjiSınıfı = "C", BuzlukTürü = "alttan kapı", Hacim = 380, KapıSayısı = 3, Marka = "LG", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 46, EnerjiSınıfı = "C", BuzlukTürü = "alttan kapı", Hacim = 400, KapıSayısı = 4, Marka = "Vestel", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 47, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 240, KapıSayısı = 3, Marka = "Beko", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 48, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 49, EnerjiSınıfı = "C", BuzlukTürü = "dolap tipi", Hacim = 320, KapıSayısı = 4, Marka = "Vestel", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 50, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 340, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 51, EnerjiSınıfı = "A++", BuzlukTürü = "üstten kapı", Hacim = 380, KapıSayısı = 4, Marka = "Arçelik", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 52, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 460, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 53, EnerjiSınıfı = "C", BuzlukTürü = "yok", Hacim = 520, KapıSayısı = 4, Marka = "Samsung", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 54, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 280, KapıSayısı = 1, Marka = "Beko", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 55, EnerjiSınıfı = "C", BuzlukTürü = "yok", Hacim = 340, KapıSayısı = 4, Marka = "Bosch", NoFrostMu = false, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 56, EnerjiSınıfı = "A", BuzlukTürü = "üstten kapı", Hacim = 540, KapıSayısı = 3, Marka = "Bosch", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 57, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 560, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = true, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 58, EnerjiSınıfı = "B", BuzlukTürü = "yok", Hacim = 400, KapıSayısı = 3, Marka = "Bosch", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 59, EnerjiSınıfı = "C", BuzlukTürü = "üstten kapı", Hacim = 260, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 60, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 480, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 61, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 580, KapıSayısı = 2, Marka = "Arçelik", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 62, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 360, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 63, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 240, KapıSayısı = 3, Marka = "Samsung", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 64, EnerjiSınıfı = "C", BuzlukTürü = "alttan kapı", Hacim = 380, KapıSayısı = 2, Marka = "LG", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 65, EnerjiSınıfı = "A+", BuzlukTürü = "üstten kapı", Hacim = 440, KapıSayısı = 4, Marka = "Bosch", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 66, EnerjiSınıfı = "A", BuzlukTürü = "üstten kapı", Hacim = 540, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 67, EnerjiSınıfı = "C", BuzlukTürü = "dolap tipi", Hacim = 460, KapıSayısı = 3, Marka = "Beko", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 68, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 340, KapıSayısı = 4, Marka = "Arçelik", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 69, EnerjiSınıfı = "B", BuzlukTürü = "yok", Hacim = 460, KapıSayısı = 3, Marka = "Bosch", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 70, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 300, KapıSayısı = 1, Marka = "LG", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 71, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 520, KapıSayısı = 2, Marka = "Samsung", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 72, EnerjiSınıfı = "A++", BuzlukTürü = "üstten kapı", Hacim = 420, KapıSayısı = 2, Marka = "Arçelik", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 73, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 300, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 74, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 480, KapıSayısı = 3, Marka = "Beko", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 75, EnerjiSınıfı = "C", BuzlukTürü = "yok", Hacim = 500, KapıSayısı = 2, Marka = "LG", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 76, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 340, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 77, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 220, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 78, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 380, KapıSayısı = 2, Marka = "LG", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 79, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 480, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = true, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 80, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 240, KapıSayısı = 4, Marka = "Arçelik", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 81, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 4, Marka = "Bosch", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 82, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 520, KapıSayısı = 2, Marka = "Arçelik", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 83, EnerjiSınıfı = "C", BuzlukTürü = "üstten kapı", Hacim = 560, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 84, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 440, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 85, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 3, Marka = "Bosch", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 86, EnerjiSınıfı = "C", BuzlukTürü = "yok", Hacim = 460, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 87, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 540, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 88, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 220, KapıSayısı = 2, Marka = "Bosch", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 89, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 600, KapıSayısı = 3, Marka = "Vestel", NoFrostMu = false, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 90, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 600, KapıSayısı = 2, Marka = "Samsung", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 91, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 520, KapıSayısı = 2, Marka = "Vestel", NoFrostMu = false, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 92, EnerjiSınıfı = "A++", BuzlukTürü = "alttan kapı", Hacim = 320, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 93, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 520, KapıSayısı = 3, Marka = "Vestel", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 94, EnerjiSınıfı = "A+", BuzlukTürü = "üstten kapı", Hacim = 240, KapıSayısı = 4, Marka = "Beko", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 95, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 340, KapıSayısı = 3, Marka = "LG", NoFrostMu = false, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 96, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 560, KapıSayısı = 1, Marka = "Beko", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 97, EnerjiSınıfı = "A", BuzlukTürü = "üstten kapı", Hacim = 300, KapıSayısı = 4, Marka = "Arçelik", NoFrostMu = false, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 98, EnerjiSınıfı = "A++", BuzlukTürü = "yok", Hacim = 600, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 99, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 300, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 100, EnerjiSınıfı = "B", BuzlukTürü = "yok", Hacim = 300, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 101, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 260, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 102, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 400, KapıSayısı = 3, Marka = "Vestel", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 103, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 220, KapıSayısı = 1, Marka = "Bosch", NoFrostMu = true, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 104, EnerjiSınıfı = "A", BuzlukTürü = "dolap tipi", Hacim = 320, KapıSayısı = 4, Marka = "Bosch", NoFrostMu = false, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 105, EnerjiSınıfı = "B", BuzlukTürü = "yok", Hacim = 520, KapıSayısı = 1, Marka = "Beko", NoFrostMu = true, Renk = "kırmızı" },
new Buzdolabı { BuzdolabıID = 106, EnerjiSınıfı = "A+", BuzlukTürü = "alttan kapı", Hacim = 240, KapıSayısı = 3, Marka = "Samsung", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 107, EnerjiSınıfı = "C", BuzlukTürü = "üstten kapı", Hacim = 280, KapıSayısı = 1, Marka = "LG", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 108, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 440, KapıSayısı = 3, Marka = "Arçelik", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 109, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 520, KapıSayısı = 1, Marka = "Bosch", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 110, EnerjiSınıfı = "A", BuzlukTürü = "dolap tipi", Hacim = 600, KapıSayısı = 2, Marka = "Samsung", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 111, EnerjiSınıfı = "B", BuzlukTürü = "dolap tipi", Hacim = 260, KapıSayısı = 4, Marka = "LG", NoFrostMu = false, Renk = "kahverengi" },
new Buzdolabı { BuzdolabıID = 112, EnerjiSınıfı = "B", BuzlukTürü = "alttan kapı", Hacim = 480, KapıSayısı = 1, Marka = "Vestel", NoFrostMu = false, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 113, EnerjiSınıfı = "A+", BuzlukTürü = "yok", Hacim = 500, KapıSayısı = 1, Marka = "Bosch", NoFrostMu = true, Renk = "yeşil" },
new Buzdolabı { BuzdolabıID = 114, EnerjiSınıfı = "A", BuzlukTürü = "alttan kapı", Hacim = 560, KapıSayısı = 2, Marka = "Samsung", NoFrostMu = true, Renk = "turuncu" },
new Buzdolabı { BuzdolabıID = 115, EnerjiSınıfı = "B", BuzlukTürü = "üstten kapı", Hacim = 440, KapıSayısı = 1, Marka = "Samsung", NoFrostMu = true, Renk = "beyaz" },
new Buzdolabı { BuzdolabıID = 116, EnerjiSınıfı = "A++", BuzlukTürü = "dolap tipi", Hacim = 580, KapıSayısı = 2, Marka = "Arçelik", NoFrostMu = true, Renk = "siyah" },
new Buzdolabı { BuzdolabıID = 117, EnerjiSınıfı = "A+", BuzlukTürü = "dolap tipi", Hacim = 200, KapıSayısı = 1, Marka = "Arçelik", NoFrostMu = true, Renk = "pembe" },
new Buzdolabı { BuzdolabıID = 118, EnerjiSınıfı = "A", BuzlukTürü = "yok", Hacim = 320, KapıSayısı = 4, Marka = "LG", NoFrostMu = true, Renk = "turuncu" }
                                           );




            modelBuilder.Entity<Boyama>().HasData(
new Boyama { BoyamaID = 1, BaslamaTarihi = "1 Hafta içinde", BoyamaNiteligi = "Kaliteli", OdaSayisi = "2+1", MetreKare = 55, Renk = "pembe" },
new Boyama { BoyamaID = 2, BaslamaTarihi = "4 Hafta içinde", BoyamaNiteligi = "Normal", OdaSayisi = "1+1", MetreKare = 90, Renk = "sarı" },
new Boyama { BoyamaID = 3, BaslamaTarihi = "5 Hafta içinde", BoyamaNiteligi = "Karışık", OdaSayisi = "1+0", MetreKare = 120, Renk = "yeşil" },
new Boyama { BoyamaID = 4, BaslamaTarihi = "6 Ay içinde", BoyamaNiteligi = "Kaliteli", OdaSayisi = "4+1", MetreKare = 60, Renk = "beyaz" },
new Boyama { BoyamaID = 5, BaslamaTarihi = "16 Hafta içinde", BoyamaNiteligi = "Normal", OdaSayisi = "3+1", MetreKare = 50, Renk = "mavi" },
new Boyama { BoyamaID = 6, BaslamaTarihi = "3 gün içinde", BoyamaNiteligi = "Kaliteli", OdaSayisi = "3+1", MetreKare = 75, Renk = "kırmızı" }
            );


            modelBuilder.Entity<Renk>().HasData(
new Renk { RenkID = 1, RenkAdı = "Kırmızı" },
new Renk { RenkID = 2, RenkAdı = "Yeşil" },
new Renk { RenkID = 3, RenkAdı = "Mavi" },
new Renk { RenkID = 4, RenkAdı = "Turuncu" },
new Renk { RenkID = 5, RenkAdı = "Kahverengi" },
new Renk { RenkID = 6, RenkAdı = "Gri" },
new Renk { RenkID = 7, RenkAdı = "Beyaz" },
new Renk { RenkID = 8, RenkAdı = "Sarı" },
new Renk { RenkID = 9, RenkAdı = "Siyah" }
          );



            modelBuilder.Entity<Araba>().HasData(
new Araba { ArabaID = 1, AraçTipi = "Sedan", Marka = "Renault", Model = "Megan", ModelYılı = 2017, YakıtTipi = "Dizel", VitesTipi = "Otomatik", MotorHacmi = 1500, Renk = "Beyaz" },
new Araba { ArabaID = 2, AraçTipi = "Sedan", Marka = "Opel", Model = "Astra", ModelYılı = 2016, YakıtTipi = "Benzin", VitesTipi = "Otomatik", MotorHacmi = 1400, Renk = "Kırmızı" },
new Araba { ArabaID = 3, AraçTipi = "Hatchback", Marka = "Renault", Model = "Clio", ModelYılı = 2017, YakıtTipi = "Dizel", VitesTipi = "Otomatik", MotorHacmi = 1500, Renk = "Beyaz" },
new Araba { ArabaID = 4, AraçTipi = "Sedan", Marka = "Renault", Model = "Sedan", ModelYılı = 2017, YakıtTipi = "Dizel", VitesTipi = "Otomatik", MotorHacmi = 1500, Renk = "Siyah" },
new Araba { ArabaID = 5, AraçTipi = "Sedan", Marka = "Renault", Model = "Sedan", ModelYılı = 2017, YakıtTipi = "Dizel", VitesTipi = "Otomatik", MotorHacmi = 1500, Renk = "Turuncu" },
new Araba { ArabaID = 6, AraçTipi = "Bus", Marka = "Mercedes", Model = "Kamyonet", ModelYılı = 2017, YakıtTipi = "Dizel", VitesTipi = "Otomatik", MotorHacmi = 1500, Renk = "Sarı" }
          );



        }





        
    }
}