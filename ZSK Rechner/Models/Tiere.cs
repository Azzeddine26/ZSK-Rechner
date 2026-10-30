using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ZSK_Rechner.Models
{
    public class Tiere
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name ist erforderlich")]
        [StringLength(50)]
        public string Name { get; set; } = string.Empty; // z. B. "Kuh", "Schaf", "Ziege"

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal WertInEuro { get; set; } // z. B. 2800.00
    }
}
