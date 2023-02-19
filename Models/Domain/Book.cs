using System.ComponentModel.DataAnnotations;

namespace Film.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Zapomniałeś o Tytule")]
        public string Tytul { get; set; }

        [Required(ErrorMessage = "Zapomniałeś o Autorze")]
        public string Rezyser { get; set; }

        [Required(ErrorMessage = "Zapomniałeś o Opise")]
        public string Opis { get; set; }
    }

}
