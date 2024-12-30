using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("products_history")] // Nombre de la tabla en plural
public class ProductHistory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public double QuantityChange { get; set; }
    [Required]
    [MaxLength(30)]
    public string Reason { get; set; } = null!;
    [Required]
    public DateTime TimeStamp { get; set; }
    [ForeignKey("Product")]
    public int ProductId { get; set; }
    public Product? Product { get; set; }
    [ForeignKey("User")]
    public int UserId { get; set; }
    public User? User { get; set; }
}
