using System.ComponentModel.DataAnnotations;

namespace QlySanPham.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên sản phẩm là bắt buộc.")]
        [MinLength(3, ErrorMessage = "Tên phải có ít nhất 3 ký tự.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Giá là bắt buộc.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Giá phải lớn hơn 0.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Stock là bắt buộc.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock phải >= 0.")]
        public int Stock { get; set; }

        public string Description { get; set; }
    }
}