using Eshop_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop_2022.Repositories
{
    public abstract class Repository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _list = new ();
        private int Index;



        public int Create(T t)
        {
            t.Id = Index;
            Index++;
            _list.Add(t);
            return t.Id;
        }

      
        public bool Delete(int id)
        {  
            T? t= Read(id);
            if (t != null) {  
                _list.Remove(t);
                return true;
            }
           return false;
        }

        public T? Read(int id)
        {
            foreach(T t in _list)
            {
                if (t.Id == id)
                    return t;
            }
            return null;
        }

        public List<T> Read()
        {
            return _list;
        }

        public abstract bool Update(int id, T otherT);
       
    }
}
