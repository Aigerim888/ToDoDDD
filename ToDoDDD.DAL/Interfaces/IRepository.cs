using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoDDD.DAL.Interfaces
{
        public interface IRepository<T> where T : class
        {
            IEnumerable<T> Get();
            T GetByID(int id);
            void Insert(T entity);
            void Delete(int id);
            void Delete(T entity);
            void Update(T entity);
            void Save();
        }
    
}
