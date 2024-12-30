using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("order_details")] // Nombre de la tabla en plural
public class OrderDetail
{
    [ForeignKey("Order")]
    [Required]
    [MaxLength(50)] // Debe coincidir con el tamaño del ID de la tabla Orders
    public string OrderId { get; set; } = null!;
    public Order? Order { get; set; }

    [ForeignKey("Product")]
    [Required]
    public int ProductId { get; set; }
    public Product? Product { get; set; }

    [Required]
    public double Quantity { get; set; } // Cantidad del producto en el pedido

    [MaxLength(5)]
    public string Measurement { get; set; } = null!; // Unidad de medida

    public bool Active { get; set; } = true; // Activo por defecto
}