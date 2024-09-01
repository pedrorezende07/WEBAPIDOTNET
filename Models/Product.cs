using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Models
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public int CategorieId { get; set; }

        [JsonIgnore]
        public Categorie Categorie { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(300)]
        public string? Description { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Price { get; set; }

        [StringLength(300)]
        public string? Url { get; set; }
        public int Stock { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;


    }
}