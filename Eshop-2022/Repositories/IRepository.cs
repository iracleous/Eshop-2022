using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public interface IRepository<T> where T : Entity
    {
        //CRUD create read update delete
        public int Create(T t);
        public T? Read(int id);
        public List<T> Read();
        public bool Update(int id, T t);
        public bool Delete(int id);   

    }
}
