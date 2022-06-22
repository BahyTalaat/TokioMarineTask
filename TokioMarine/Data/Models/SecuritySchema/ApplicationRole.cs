using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DbModels.SecuritySchema
{
    public class ApplicationRole:IdentityRole<long>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // so you can insert role id from enum while seeding
        public override long Id { get; set; }
    }
}
