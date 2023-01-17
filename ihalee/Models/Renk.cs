using System.ComponentModel.DataAnnotations;

namespace ihalee.Models
{
    public class Renk
    {
        [Key]
        public int RenkID { get; set; }
        public string RenkAdı { get; set; }


    }
}
