
using System.ComponentModel.DataAnnotations;

namespace ihalee.Models
{
    public class Araba
    {
        [Key]
        public int ArabaID { get; set; }

        public string AraçTipi { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int ModelYılı{ get; set; }
        public string YakıtTipi{ get; set; }
        public string VitesTipi{ get; set; }
        public int? MotorHacmi{ get; set; }
        public string Renk{ get; set; }

    }
}
