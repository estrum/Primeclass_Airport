using Primeclass_Airport.Domain.Entities.enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("orders")] // Nombre de la tabla en plural
public class Order
{
    [Key]
    [MaxLength(50)] // Ajuste para IDs únicos largos
    public string IdTicket { get; set; } = null!; // Identificador único personalizado

    [ForeignKey("Lounge")]
    public int LoungeId { get; set; } // Relación con la tabla Lounge
    public Lounge? Lounge { get; set; }

    [Required]
    public DateTime IssuedDate { get; set; } = DateTime.UtcNow;

    public DateTime? DeliveredDate { get; set; } // Puede ser nulo si aún no se ha entregado

    [ForeignKey("User")]
    public int IssuedById { get; set; } // Usuario que genera la orden
    public User? IssuedBy { get; set; }

    [ForeignKey("User")]
    public int? DeliveredById { get; set; } // Usuario que entrega la orden (puede ser nulo)
    public User? DeliveredBy { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending; // Default to Pending
    public ICollection<OrderDetail>? Details { get; set; }
}
