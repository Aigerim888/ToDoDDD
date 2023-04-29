using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoDDD.DAL.Entitities
{
    public class Issue:BaseEntity
    {
        public string Name { get;set; }
        public Priority? Priority { get;set; }   
        public Status? Status { get;set; }
    }
}
