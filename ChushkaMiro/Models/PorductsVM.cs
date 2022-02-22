using ChushkaMiro.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChushkaMiro.Models
{
    public class PorductsVM
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "This is mandatory")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "This is mandatory")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "This is mandatory")]
        public TypeProduct Type { get; set; }
        public virtual ICollection<SelectListItem>Orders { get; set; }

    }
}
