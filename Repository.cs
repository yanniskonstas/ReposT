using System;
using System.Collections.Generic;

namespace ReposT
{
    class Repository<T> : IRepository<T> where T : IStoreable 
    {

        List<T> _storableList;
        public Repository(){
            _storableList = new List<T>();
        }
        public IEnumerable<T> All() {
            return _storableList;
        }
        public void Delete(IComparable id) {
            _storableList.Remove(FindById(id));
        }
        public void Save(T item) {
            _storableList.Add(item);
        }
        public T FindById(IComparable id) {
            return _storableList.Find(item => item.Id.Equals(id));
        }

    }
}
