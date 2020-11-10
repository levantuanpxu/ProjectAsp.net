using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo1.ViewsModels
{
    public class HomeIndexVM
    {
 
        public List<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
  
}
}
