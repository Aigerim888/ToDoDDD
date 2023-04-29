using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.BLL.Repositories;
using ToDoDDD.DAL.Datas;

namespace ToDoDDD.BLL.UOW
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext context;
        public UnitOfWork(AppDbContext _context)
        {
            context = _context;   
        }

        private IssueRepository issueRepository;   
        private PriorityRepository PriorityRepository;
        private StatusRepository statusRepository;


        public IssueRepository IssueRepository
        {
            get
            {
                if(issueRepository == null)
                {
                    issueRepository = new IssueRepository(context);
                }
                return issueRepository;
            }
        }
        public PriorityRepository PriorityRepository
        {
            get
            {
                if(PriorityRepository == null)
                {
                    PriorityRepository=new PriorityRepository(context);
                }
                return PriorityRepository;
            }
        }
        public StatusRepository StatusRepository
        {
            get
            {
                if(statusRepository == null)
                {
                    statusRepository=new StatusRepository(context);
                }
                return statusRepository;
            }
        }
        
        public void Save()
        {
            context.SaveChanges();
        }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }
    }
}
