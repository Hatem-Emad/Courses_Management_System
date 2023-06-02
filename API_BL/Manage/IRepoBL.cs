using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIDay02_BL.Manage
{
    //same as IRepo... why not to use IRepo bdl dh ?!
    public interface IRepoBL<T>
    {
        public List<T> GetAll();
        public T Get(int id);
        public void Insert(T item);
        public void Update(T item);
        public void Delete(int id);
    }
}
