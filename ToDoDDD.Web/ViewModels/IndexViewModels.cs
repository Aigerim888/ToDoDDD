using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.DAL.Entitities;

namespace ToDoDDD.Web.ViewModels
{
    public class IndexViewModels
    {
        public Priority Priority { get; set; }
        public Status Status { get; set; }
        public Issue Issue { get; set; }
       
        
    }
}
