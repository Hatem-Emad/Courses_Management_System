using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDay02_DAL.Repo
{
    public interface IRepo<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public void Insert (T item);
        public void Update (T item);
        public void Delete (int id);
    }
}
