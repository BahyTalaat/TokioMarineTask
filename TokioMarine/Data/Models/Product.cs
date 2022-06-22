using Data.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Product", Schema = "Tokio")]
    public class Product: BaseEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Double Price { get; set; }
        public int Count { get; set; }

        [ForeignKey("Category")]
        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<BillProduct> BillProducts { get; set; }

    }
}
