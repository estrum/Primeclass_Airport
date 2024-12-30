using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("products")] // Nombre de la tabla en plural
public class Product
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = null!;
    public double Quantity { get; set; }
    [Required]
    [MaxLength(5)]
    public string Measurement { get; set; } = null!;
    public double MinStock { get; set; }
    public bool Active { get; set; } = true;
    [ForeignKey("Provider")]
    public int ProviderId { get; set; }

    public Provider? Provider { get; set; } // Relación con la tabla Provider
    [ForeignKey("ProductType")]
    public int ProductTypeId { get; set; }

    public ProductType? ProductType { get; set; } // Relación con la tabla Provider
}
