using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Primeclass_Airport.Domain.Entities;

[Table("users")] // Nombre de la tabla en plural
public class User
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } // Faltaba definir el ID como clave primaria

    [Required]
    [MaxLength(50)] // Máximo definido en la base de datos
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = null!;

    [Required]
    [MaxLength(15)]
    public string Phone { get; set; } = null!;

    public bool Active { get; set; } = true;

    [ForeignKey("UserRole")]
    public int UserRoleId { get; set; }

    public UserRole? UserRole { get; set; } // Relación con la tabla UserRole
}