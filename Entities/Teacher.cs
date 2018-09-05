using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMigrationIssue.Entities
{
    public class Teacher
    {
        [StringLength(32)] // GUID LENGTH = 32
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public string Name { get; set; }

        [StringLength(32)] // GUID LENGTH = 32
        public string ClassroomId { get; set; }

        public virtual Classroom Classroom { get; set; }
    }
}
