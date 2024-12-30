using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("lounges")] // Nombre de la tabla en plural
public class Lounge
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; } = null!;
    public bool Active { get; set; } = true;
}
