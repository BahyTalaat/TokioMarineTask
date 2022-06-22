using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("BillProduct", Schema = "Tokio")]
    public class BillProduct
    {
        public long Id { get; set; }
        [ForeignKey("BillId")]
        public virtual Bill Bill { get; set; }
        public long BillId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public long ProductId { get; set; }

    }
}
