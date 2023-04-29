using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.DAL.Datas;
using ToDoDDD.DAL.Entitities;

namespace ToDoDDD.BLL.Repositories
{
    public class StatusRepository : Repository<Status>
    {
        private readonly AppDbContext _db;
        public StatusRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
