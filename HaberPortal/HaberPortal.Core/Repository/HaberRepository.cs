using HaberPortal.Core.Infrastructure;
using HaberPortal.Data.DataContext;
using HaberPortal.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations; //addorupdate için gerekli.
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Core.Repository
{
    public class HaberRepository : IHaberRepository
    {

        private readonly HaberContext _context = new HaberContext();
        public int Count()
        {
            return _context.Haber.Count(); //haber tablosundaki kayıt sayısını verir.
        }

        public void Delete(int id)
        {
            var Haber = GetById(id);
            if (Haber != null)
            {
                _context.Haber.Remove(Haber); //Silme işlemi.
            }
        }

        public Haber Get(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haber.FirstOrDefault(expression); // expression sonucu tek bir değer dönecek.
        }

        public IEnumerable<Haber> GetAll()
        {
            return _context.Haber.Select(x => x);  // Tüm haberler dönecek.
        }

        public Haber GetById(int id)
        {
            return _context.Haber.FirstOrDefault(x => x.ID == id); //Sadece gelen ID ye göre dönecek. Modelden gelen ID ile gelen id eşit ise sonuç döndürecek.
        }

        public IQueryable<Haber> GetMany(Expression<Func<Haber, bool>> expression)
        {
            return _context.Haber.Where(expression); //expression sonucu BİRDEN FAZLA değer dönecek.
        }

        public void Insert(Haber obj)
        {
            _context.Haber.Add(obj); //Insert metodumuz.
        }

        public void Save()
        {
            _context.SaveChanges(); //kaydetme metodu.
        }

        public void Update(Haber obj)
        {
           _context.Haber.AddOrUpdate(); //ekle ya da güncelle metodu.
        }
    }
}
