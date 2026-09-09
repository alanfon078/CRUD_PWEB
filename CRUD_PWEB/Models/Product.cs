using System.ComponentModel.DataAnnotations;

namespace CRUD_PWEB.Models
{
    public partial class Product
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        [Display(Name = "Nombre del Producto")]
        [StringLength(50, ErrorMessage = "El nombre no puede exceder 50 caracteres.")]
        public string? ProductName { get; set; }

        [Display(Name = "Proveedor")]
        public int? SupplierId { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "Debe seleccionar una categoría.")]
        public int? CategoryId { get; set; }

        [Display(Name = "Unidad")]
        public string? Unit { get; set; }

        [Display(Name = "Precio")]
        [DataType(DataType.Currency)]
        [Range(0.01, 10000, ErrorMessage = "El precio debe ser mayor a 0.")]
        public decimal? Price { get; set; }

        [Display(Name = "Categoría")]
        public virtual Category? Category { get; set; }

        [Display(Name = "Proveedor")]
        public virtual Supplier? Supplier { get; set; }

        public virtual ICollection<Orderdetail> Orderdetails { get; set; } = new List<Orderdetail>();
    }
}