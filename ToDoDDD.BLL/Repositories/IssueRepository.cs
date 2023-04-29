using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.DAL.Datas;
using ToDoDDD.DAL.Entitities;

namespace ToDoDDD.BLL.Repositories
{
    public class IssueRepository : Repository<Issue>
    {
        private readonly AppDbContext _db;
        public IssueRepository(AppDbContext db) : base(db)
        {
            _db=db;
        }

        public void GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
