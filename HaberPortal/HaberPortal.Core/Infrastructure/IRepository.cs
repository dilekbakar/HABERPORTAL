using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Core.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        //bu bizim tüm datamızı çekecek.
        IEnumerable<T> GetAll();

        //tek bir nesne döndürür.
        T GetById(int d);

        //yine tek nesne döndürecek fakat expressionla.
        T Get(Expression<Func<T, bool>> expression);

        //birden fazla değer dönecek fakat expressionla.
        IQueryable<T> GetMany(Expression<Func<T, bool>> expression);

        void Insert(T obj);
        void Update(T obj);

        void Delete(int id);

        int Count();
        void Save();




    }
}
