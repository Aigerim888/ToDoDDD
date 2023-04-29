using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoDDD.DAL.Datas;
using ToDoDDD.DAL.Interfaces;

namespace ToDoDDD.BLL.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;
        private readonly DbSet<T> dbset;

        public Repository(AppDbContext db)
        {
            _db = db;
            dbset = _db.Set<T>();
        }
        public IEnumerable<T> Get()
        {
            return dbset.ToList();
        }

        public T GetByID(Guid id)
        {
            return dbset.Find(id);
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);  
        }
        public void Delete(Guid id)
        {
            T entityToDelete=dbset.Find(id);    
            Delete(entityToDelete);
        }
        public void Delete(T entity)
        {
            if(_db.Entry(entity).State== EntityState.Detached)
            {
                dbset.Attach(entity);
            }
            dbset.Remove(entity);
           
        }
        public void Update(T entity)
        {
            dbset.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
        }
        

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
