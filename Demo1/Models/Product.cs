using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Tên Sản Phẩm")]
        [Required(ErrorMessage = "Tên thể loại không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Tên thể loại tối thiểu phải có 3 ký tự")]
        public string Name { get; set; }
        [DisplayName("Mô Tả Sản Phẩm")]
        public string Description { get; set; }
        [DisplayName("Số Lượng")]
        public int Stock { get; set; }
        [DisplayName("Giá")]
        public decimal Price { get; set; }
        [DisplayName("Ảnh Sản Phẩm")]
        [Required(ErrorMessage = "Ảnh Sản Phẩm không được bỏ trống")]
        public string ImageUrl { get; set; }
       
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<ProductTag> ProductTags { get; set; } = new List<ProductTag>();
    }
}
