using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.DAL.Datas;
using ToDoDDD.DAL.Entitities;

namespace ToDoDDD.BLL.Repositories
{
    public class PriorityRepository : Repository<Priority>
    {
        private readonly AppDbContext _db;
        public PriorityRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
