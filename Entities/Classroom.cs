using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMigrationIssue.Entities
{
    public class Classroom
    {
        [StringLength(32)] // GUID LENGTH = 32
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public string Name { get; set; }

        //public virtual ICollection<Teacher> Teachers { get; set; }
        
        public string Teachers { get; set; }
    }
}
