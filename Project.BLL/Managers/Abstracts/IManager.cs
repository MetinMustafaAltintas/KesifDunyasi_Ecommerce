using Project.ENTITIES.CoreInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Managers.Abstracts
{
    public interface IManager<T> where T : IEntity
    {
        //List Command

        List<T> GetAll();
        List<T> GetActives();

        //Todo: GetActivesAsync
        Task<List<T>> GetActivesAsync();
        List<T> GetPassives();
        List<T> GetModifieds();

        //Modify Commands
        string Add(T item);
        Task AddAsync(T item);
        void Delete(T item);
        Task UpdateAsync(T item);
        string Destroy(T item);

        //Linq Commands
        List<T> Where(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> exp);

        object Select(Expression<Func<T, object>> exp);
        IQueryable<X> Select<X>(Expression<Func<T, X>> exp);

        //Find Command

        Task<T> FindAsync(int id);

        List<T> GetLastDatas(int count);
        List<T> GetFirstDatas(int count);

        void Updated(T item, T originalEntity);

    }
}
