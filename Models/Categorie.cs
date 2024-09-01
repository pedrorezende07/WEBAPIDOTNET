using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("categories")] //nao precisaria pq mapiei no AppDbContext
    public class Categorie
    {   
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [StringLength(300) ]
        public string? Url { get; set; }


        public ICollection<Product> Products { get; set; }
    }

}

