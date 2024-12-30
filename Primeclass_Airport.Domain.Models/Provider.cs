using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primeclass_Airport.Domain.Entities;

[Table("providers")] // Nombre de la tabla en plural
public class Provider
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; } = null!;
    [Required]
    [MaxLength(15)]
    public string Phone { get; set; } = null!;
    public bool Active { get; set; } = true;
}
