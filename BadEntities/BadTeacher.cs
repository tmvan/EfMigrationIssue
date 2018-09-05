using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfMigrationIssue.BadEntities
{
    public class BadTeacher
    {
        public string Id { get; set; } = Guid.NewGuid().ToString("N");

        public string Name { get; set; }

        public string ClassroomId { get; set; }

        public virtual BadClassroom Classroom { get; set; }
    }
}
