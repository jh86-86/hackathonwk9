using System.Collections.Generic;
using System.Threading.Tasks;

namespace RecipeAPI
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        void Delete(long id);
        Task<T> Get(long id);
        T Update(T t);
        T Insert(T t);
        IEnumerable<T> Search(string s);
    }
}