using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoDDD.DAL.Entitities
{
    public class Status:BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Issue> Issues { get; set; }
    }
}
