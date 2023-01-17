using System.ComponentModel.DataAnnotations;

namespace ihalee.Models
{
    public class Boyama
    {
        [Key]
        public int BoyamaID { get; set; }
        public string Renk { get; set; }
        public String OdaSayisi { get; set; }
        public int MetreKare { get; set; }
        public string BaslamaTarihi { get; set; }
        public string BoyamaNiteligi { get; set; }
        




    }
}
