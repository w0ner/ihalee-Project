using System.ComponentModel.DataAnnotations;
namespace ihalee.Models
{
    public class Buzdolabı
    {
        [Key]
        public int BuzdolabıID{ get; set; }
        public string Marka { get; set; }
        public int Hacim { get; set; }
        public string EnerjiSınıfı{ get; set; }
        public int KapıSayısı { get; set; }
        public bool NoFrostMu { get; set; }
        public string Renk { get; set; }
        public string BuzlukTürü { get; set; }
      


    }

}
