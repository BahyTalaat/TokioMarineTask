using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Category
{
    public class UpdateCategoryDto
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
