using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoDDD.DAL.Entitities
{
    public class Issue : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; } 
        public Guid PriorityId { get; set; } 
        public Priority? Priority { get; set; } 
        public Guid StatusId { get; set; }
        public Status? Status { get; set; }
    }
}

