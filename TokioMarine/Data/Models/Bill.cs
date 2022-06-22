using Data.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Bill", Schema = "Tokio")]
    public class Bill: BaseEntity
    {
        public long Id { get; set; }
        public virtual ICollection<BillProduct> BillProducts { get; set; }
        public Double TotalPrice { get; set; }
        public long UserID { get; set; }

    }
}
