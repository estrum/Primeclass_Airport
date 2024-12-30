using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("product_types")] // Nombre de la tabla en plural
public class ProductType
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;
}
