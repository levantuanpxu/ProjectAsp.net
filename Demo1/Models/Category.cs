using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Demo1.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Tên Thể Loại")]
        [Required(ErrorMessage = "Tên thể loại không được bỏ trống")]
        [MinLength(3, ErrorMessage = "Tên thể loại tối thiểu phải có 3 ký tự")]

        public string CategoryName { get; set; }
        [DisplayName("Mô tả thể loại")]
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }
}
