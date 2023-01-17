using ihalee.Models;
using NuGet.Protocol.Core.Types;

namespace ihalee.ViewModel
{
    public class BuzdolabıViewModel
    {
        public List<Buzdolabı> BuzdolabıListesi { get; set; }

        public int AktifSayfa{ get; set; }

        public int SonSayfa { get; set; }

        public int BaşKayıtNO{ get; set; }

        public int SonKayıtNO{ get; set; }

        public int TotalKayıtNO{ get; set; }

    }
}
