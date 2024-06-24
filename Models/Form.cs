using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Form
    {
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Required]
        public string Sexe { get; set; }
        [Required]
        public string Adresse { get; set; }
        [Required]
        [RegularExpression(@"^\d{5}")]
        public string CodePostal { get; set; }
        [Required]
        public string Ville { get; set; }
        [Required]
        [RegularExpression(@"^([\w]+)@([\w]+)\.( [\w]+)$")]
        public string Mail { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DebutDate { get; set; }
        [Required]
        public string Formation { get; set; }

        [Required]
        public string Cobol { get; set; }
        [Required]
        public string CS { get; set; }
    }
}
