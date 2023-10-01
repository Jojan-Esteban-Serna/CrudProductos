using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrudProductos.Models;

public class Producto
{
    public int Id { get; set; }
    
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Nombre { get; set; }
    [StringLength(120, MinimumLength = 3)]
    [Required]
    public string? Descripcion { get; set; }
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    public decimal Precio { get; set; }
}