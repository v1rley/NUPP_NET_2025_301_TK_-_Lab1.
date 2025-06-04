using System;
using System.Collections.Generic;
using System.Linq;

namespace Zoo.Common
{
    public interface ICrudService<T>
    {
        void Create(T element);
        T Read(Guid id);
        IEnumerable<T> ReadAll();
        void Update(T element);
        void Remove(T element);
    }

    public class CrudService<T> : ICrudService<T> where T : class
    {
        private List<T> _storage = new List<T>();

        public void Create(T element)
        {
            _storage.Add(element);
        }

        public T Read(Guid id)
        {
            return _storage.FirstOrDefault(e =>
                (Guid)e.GetType().GetProperty("Id").GetValue(e, null) == id);
        }

        public IEnumerable<T> ReadAll()
        {
            return _storage;
        }

        public void Update(T element)
        {
            Remove(element);
            Create(element);
        }

        public void Remove(T element)
        {
            Guid id = (Guid)element.GetType().GetProperty("Id").GetValue(element, null);
            _storage = _storage
                .Where(e => (Guid)e.GetType().GetProperty("Id").GetValue(e, null) != id)
                .ToList();
        }
    }
}
