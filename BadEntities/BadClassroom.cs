using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMigrationIssue.BadEntities
{
    public class BadClassroom
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public string Name { get; set; }

        //public virtual ICollection<BadTeacher> Teachers { get; set; }
        
        public string Teachers { get; set; }
    }
}
