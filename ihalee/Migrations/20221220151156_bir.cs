using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ihalee.Migrations
{
    /// <inheritdoc />
    public partial class bir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arabalar",
                columns: table => new
                {
                    ArabaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AraçTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModelYılı = table.Column<int>(type: "int", nullable: false),
                    YakıtTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VitesTipi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotorHacmi = table.Column<int>(type: "int", nullable: true),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arabalar", x => x.ArabaID);
                });

            migrationBuilder.CreateTable(
                name: "Boyamalar",
                columns: table => new
                {
                    BoyamaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OdaSayisi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MetreKare = table.Column<int>(type: "int", nullable: false),
                    BaslamaTarihi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoyamaNiteligi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boyamalar", x => x.BoyamaID);
                });

            migrationBuilder.CreateTable(
                name: "Buzdolapları",
                columns: table => new
                {
                    BuzdolabıID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hacim = table.Column<int>(type: "int", nullable: false),
                    EnerjiSınıfı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KapıSayısı = table.Column<int>(type: "int", nullable: false),
                    NoFrostMu = table.Column<bool>(type: "bit", nullable: false),
                    Renk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BuzlukTürü = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buzdolapları", x => x.BuzdolabıID);
                });

            migrationBuilder.CreateTable(
                name: "Renkler",
                columns: table => new
                {
                    RenkID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RenkAdı = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Renkler", x => x.RenkID);
                });

            migrationBuilder.InsertData(
                table: "Arabalar",
                columns: new[] { "ArabaID", "AraçTipi", "Marka", "Model", "ModelYılı", "MotorHacmi", "Renk", "VitesTipi", "YakıtTipi" },
                values: new object[,]
                {
                    { 1, "Sedan", "Renault", "Megan", 2017, 1500, "Beyaz", "Otomatik", "Dizel" },
                    { 2, "Sedan", "Opel", "Astra", 2016, 1400, "Kırmızı", "Otomatik", "Benzin" },
                    { 3, "Hatchback", "Renault", "Clio", 2017, 1500, "Beyaz", "Otomatik", "Dizel" },
                    { 4, "Sedan", "Renault", "Sedan", 2017, 1500, "Siyah", "Otomatik", "Dizel" },
                    { 5, "Sedan", "Renault", "Sedan", 2017, 1500, "Turuncu", "Otomatik", "Dizel" },
                    { 6, "Bus", "Mercedes", "Kamyonet", 2017, 1500, "Sarı", "Otomatik", "Dizel" }
                });

            migrationBuilder.InsertData(
                table: "Boyamalar",
                columns: new[] { "BoyamaID", "BaslamaTarihi", "BoyamaNiteligi", "MetreKare", "OdaSayisi", "Renk" },
                values: new object[,]
                {
                    { 1, "1 Hafta içinde", "Kaliteli", 55, "2+1", "pembe" },
                    { 2, "4 Hafta içinde", "Normal", 90, "1+1", "sarı" },
                    { 3, "5 Hafta içinde", "Karışık", 120, "1+0", "yeşil" },
                    { 4, "6 Ay içinde", "Kaliteli", 60, "4+1", "beyaz" },
                    { 5, "16 Hafta içinde", "Normal", 50, "3+1", "mavi" },
                    { 6, "3 gün içinde", "Kaliteli", 75, "3+1", "kırmızı" }
                });

            migrationBuilder.InsertData(
                table: "Buzdolapları",
                columns: new[] { "BuzdolabıID", "BuzlukTürü", "EnerjiSınıfı", "Hacim", "KapıSayısı", "Marka", "NoFrostMu", "Renk" },
                values: new object[,]
                {
                    { 1, "dolap tipi", "A+", 240, 1, "Beko", true, "siyah" },
                    { 2, "dolap tipi", "A+", 480, 1, "Arçelik", true, "pembe" },
                    { 3, "dolap tipi", "A++", 560, 4, "Arçelik", false, "kahverengi" },
                    { 4, "alttan kapı", "C", 420, 1, "Beko", true, "kırmızı" },
                    { 5, "alttan kapı", "A++", 560, 3, "Arçelik", true, "pembe" },
                    { 6, "alttan kapı", "B", 280, 1, "Arçelik", false, "beyaz" },
                    { 7, "dolap tipi", "C", 460, 3, "Samsung", true, "yeşil" },
                    { 8, "dolap tipi", "B", 260, 3, "Vestel", false, "pembe" },
                    { 9, "yok", "A", 380, 1, "Arçelik", false, "siyah" },
                    { 10, "dolap tipi", "C", 460, 4, "Beko", true, "pembe" },
                    { 11, "dolap tipi", "A", 600, 3, "Arçelik", false, "kahverengi" },
                    { 12, "dolap tipi", "B", 400, 1, "Vestel", false, "pembe" },
                    { 13, "alttan kapı", "B", 200, 3, "LG", false, "pembe" },
                    { 14, "alttan kapı", "A+", 440, 2, "Vestel", true, "kırmızı" },
                    { 15, "üstten kapı", "B", 220, 2, "LG", true, "kahverengi" },
                    { 16, "dolap tipi", "A++", 480, 2, "Arçelik", false, "pembe" },
                    { 17, "alttan kapı", "A+", 240, 1, "Samsung", true, "kırmızı" },
                    { 18, "alttan kapı", "B", 480, 1, "LG", true, "kahverengi" },
                    { 19, "alttan kapı", "A+", 540, 3, "Bosch", true, "yeşil" },
                    { 20, "üstten kapı", "A++", 400, 1, "Vestel", false, "siyah" },
                    { 21, "alttan kapı", "A++", 200, 3, "LG", true, "siyah" },
                    { 22, "yok", "A+", 360, 1, "LG", false, "kahverengi" },
                    { 23, "yok", "A+", 280, 3, "Beko", false, "pembe" },
                    { 24, "dolap tipi", "C", 260, 3, "Beko", true, "siyah" },
                    { 25, "dolap tipi", "A+", 260, 1, "Bosch", false, "kırmızı" },
                    { 26, "alttan kapı", "A++", 540, 1, "Arçelik", false, "beyaz" },
                    { 27, "üstten kapı", "B", 220, 4, "LG", true, "turuncu" },
                    { 28, "üstten kapı", "A+", 500, 1, "Bosch", false, "yeşil" },
                    { 29, "yok", "A+", 560, 2, "Beko", false, "pembe" },
                    { 30, "dolap tipi", "B", 420, 2, "Vestel", false, "siyah" },
                    { 31, "dolap tipi", "A++", 580, 3, "Vestel", true, "pembe" },
                    { 32, "yok", "A", 280, 3, "Arçelik", false, "beyaz" },
                    { 33, "üstten kapı", "A++", 340, 2, "Beko", false, "beyaz" },
                    { 34, "üstten kapı", "A+", 560, 4, "LG", true, "turuncu" },
                    { 35, "üstten kapı", "A++", 280, 1, "Samsung", true, "siyah" },
                    { 36, "yok", "A++", 200, 3, "Samsung", false, "kırmızı" },
                    { 37, "dolap tipi", "A", 540, 4, "Samsung", true, "siyah" },
                    { 38, "üstten kapı", "A", 400, 1, "Beko", false, "pembe" },
                    { 39, "alttan kapı", "A", 200, 4, "Beko", false, "kırmızı" },
                    { 40, "yok", "A+", 320, 2, "Vestel", true, "pembe" },
                    { 41, "üstten kapı", "C", 320, 2, "Beko", false, "yeşil" },
                    { 42, "dolap tipi", "B", 560, 1, "Vestel", false, "beyaz" },
                    { 43, "üstten kapı", "A", 320, 2, "LG", false, "yeşil" },
                    { 44, "alttan kapı", "B", 540, 4, "Bosch", false, "yeşil" },
                    { 45, "alttan kapı", "C", 380, 3, "LG", true, "siyah" },
                    { 46, "alttan kapı", "C", 400, 4, "Vestel", true, "kırmızı" },
                    { 47, "alttan kapı", "B", 240, 3, "Beko", true, "pembe" },
                    { 48, "alttan kapı", "B", 540, 3, "Arçelik", false, "siyah" },
                    { 49, "dolap tipi", "C", 320, 4, "Vestel", false, "siyah" },
                    { 50, "yok", "A", 340, 4, "LG", true, "kırmızı" },
                    { 51, "üstten kapı", "A++", 380, 4, "Arçelik", true, "turuncu" },
                    { 52, "yok", "A++", 460, 2, "Vestel", false, "turuncu" },
                    { 53, "yok", "C", 520, 4, "Samsung", true, "turuncu" },
                    { 54, "alttan kapı", "A+", 280, 1, "Beko", true, "pembe" },
                    { 55, "yok", "C", 340, 4, "Bosch", false, "kırmızı" },
                    { 56, "üstten kapı", "A", 540, 3, "Bosch", false, "siyah" },
                    { 57, "alttan kapı", "A+", 560, 3, "Arçelik", true, "kahverengi" },
                    { 58, "yok", "B", 400, 3, "Bosch", true, "pembe" },
                    { 59, "üstten kapı", "C", 260, 2, "Vestel", false, "turuncu" },
                    { 60, "alttan kapı", "A", 480, 2, "Vestel", false, "turuncu" },
                    { 61, "alttan kapı", "B", 580, 2, "Arçelik", true, "siyah" },
                    { 62, "dolap tipi", "B", 360, 3, "Arçelik", false, "beyaz" },
                    { 63, "alttan kapı", "A+", 240, 3, "Samsung", false, "siyah" },
                    { 64, "alttan kapı", "C", 380, 2, "LG", true, "turuncu" },
                    { 65, "üstten kapı", "A+", 440, 4, "Bosch", true, "yeşil" },
                    { 66, "üstten kapı", "A", 540, 2, "Vestel", true, "siyah" },
                    { 67, "dolap tipi", "C", 460, 3, "Beko", false, "yeşil" },
                    { 68, "dolap tipi", "B", 340, 4, "Arçelik", true, "kırmızı" },
                    { 69, "yok", "B", 460, 3, "Bosch", true, "turuncu" },
                    { 70, "alttan kapı", "A+", 300, 1, "LG", true, "turuncu" },
                    { 71, "yok", "A", 520, 2, "Samsung", false, "beyaz" },
                    { 72, "üstten kapı", "A++", 420, 2, "Arçelik", true, "yeşil" },
                    { 73, "dolap tipi", "A++", 300, 1, "Samsung", true, "kırmızı" },
                    { 74, "yok", "A++", 480, 3, "Beko", true, "kırmızı" },
                    { 75, "yok", "C", 500, 2, "LG", true, "kırmızı" },
                    { 76, "üstten kapı", "B", 340, 1, "Samsung", true, "pembe" },
                    { 77, "alttan kapı", "A", 220, 2, "Vestel", false, "yeşil" },
                    { 78, "yok", "A++", 380, 2, "LG", true, "turuncu" },
                    { 79, "alttan kapı", "A+", 480, 1, "Arçelik", true, "kahverengi" },
                    { 80, "alttan kapı", "A", 240, 4, "Arçelik", true, "turuncu" },
                    { 81, "alttan kapı", "A++", 540, 4, "Bosch", false, "kahverengi" },
                    { 82, "dolap tipi", "A+", 520, 2, "Arçelik", true, "yeşil" },
                    { 83, "üstten kapı", "C", 560, 2, "Vestel", false, "turuncu" },
                    { 84, "yok", "A++", 440, 1, "Vestel", false, "siyah" },
                    { 85, "alttan kapı", "A++", 540, 3, "Bosch", true, "siyah" },
                    { 86, "yok", "C", 460, 1, "Samsung", true, "beyaz" },
                    { 87, "alttan kapı", "A++", 540, 2, "Vestel", false, "pembe" },
                    { 88, "dolap tipi", "B", 220, 2, "Bosch", false, "siyah" },
                    { 89, "üstten kapı", "B", 600, 3, "Vestel", false, "beyaz" },
                    { 90, "dolap tipi", "A+", 600, 2, "Samsung", true, "siyah" },
                    { 91, "dolap tipi", "A++", 520, 2, "Vestel", false, "siyah" },
                    { 92, "alttan kapı", "A++", 320, 4, "LG", true, "siyah" },
                    { 93, "alttan kapı", "A+", 520, 3, "Vestel", false, "kahverengi" },
                    { 94, "üstten kapı", "A+", 240, 4, "Beko", true, "pembe" },
                    { 95, "üstten kapı", "B", 340, 3, "LG", false, "yeşil" },
                    { 96, "yok", "A++", 560, 1, "Beko", true, "yeşil" },
                    { 97, "üstten kapı", "A", 300, 4, "Arçelik", false, "pembe" },
                    { 98, "yok", "A++", 600, 4, "LG", true, "beyaz" },
                    { 99, "yok", "A", 300, 4, "LG", true, "kahverengi" },
                    { 100, "yok", "B", 300, 1, "Vestel", false, "kahverengi" },
                    { 101, "dolap tipi", "B", 260, 3, "Arçelik", true, "kırmızı" },
                    { 102, "yok", "A+", 400, 3, "Vestel", true, "siyah" },
                    { 103, "dolap tipi", "A++", 220, 1, "Bosch", true, "beyaz" },
                    { 104, "dolap tipi", "A", 320, 4, "Bosch", false, "kırmızı" },
                    { 105, "yok", "B", 520, 1, "Beko", true, "kırmızı" },
                    { 106, "alttan kapı", "A+", 240, 3, "Samsung", false, "kahverengi" },
                    { 107, "üstten kapı", "C", 280, 1, "LG", true, "siyah" },
                    { 108, "dolap tipi", "A++", 440, 3, "Arçelik", true, "siyah" },
                    { 109, "alttan kapı", "A", 520, 1, "Bosch", true, "siyah" },
                    { 110, "dolap tipi", "A", 600, 2, "Samsung", true, "turuncu" },
                    { 111, "dolap tipi", "B", 260, 4, "LG", false, "kahverengi" },
                    { 112, "alttan kapı", "B", 480, 1, "Vestel", false, "turuncu" },
                    { 113, "yok", "A+", 500, 1, "Bosch", true, "yeşil" },
                    { 114, "alttan kapı", "A", 560, 2, "Samsung", true, "turuncu" },
                    { 115, "üstten kapı", "B", 440, 1, "Samsung", true, "beyaz" },
                    { 116, "dolap tipi", "A++", 580, 2, "Arçelik", true, "siyah" },
                    { 117, "dolap tipi", "A+", 200, 1, "Arçelik", true, "pembe" },
                    { 118, "yok", "A", 320, 4, "LG", true, "turuncu" }
                });

            migrationBuilder.InsertData(
                table: "Renkler",
                columns: new[] { "RenkID", "RenkAdı" },
                values: new object[,]
                {
                    { 1, "Kırmızı" },
                    { 2, "Yeşil" },
                    { 3, "Mavi" },
                    { 4, "Turuncu" },
                    { 5, "Kahverengi" },
                    { 6, "Gri" },
                    { 7, "Beyaz" },
                    { 8, "Sarı" },
                    { 9, "Siyah" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arabalar");

            migrationBuilder.DropTable(
                name: "Boyamalar");

            migrationBuilder.DropTable(
                name: "Buzdolapları");

            migrationBuilder.DropTable(
                name: "Renkler");
        }
    }
}
