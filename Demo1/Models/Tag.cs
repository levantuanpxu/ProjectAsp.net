using System;
using System.Collections.Generic;

namespace Demo1.Models
{
    public class Tag
    {
        public int Id { get; set; }       
        public string Name { get; set; }      
        public string Description { get; set; }          
       public List<ProductTag> ProductTags { get; set; }
    }
}
