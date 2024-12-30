using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("logs")] // Nombre de la tabla en plural
public class Log
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Clave primaria añadida

    [Required]
    [MaxLength(20)]
    public string TableName { get; set; } = null!;

    [Required]
    [MaxLength(10)]
    public string Action { get; set; } = null!;

    [Required] // Obligatorio para registros consistentes
    public DateTime TimeStamp { get; set; }

    [Required]
    [MaxLength(100)]
    public string Description { get; set; } = null!;

    [ForeignKey("User")]
    public int UserId { get; set; }

    public User? User { get; set; } // Relación con la tabla User
}
