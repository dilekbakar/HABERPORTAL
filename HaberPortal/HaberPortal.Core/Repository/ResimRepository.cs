using HaberPortal.Core.Infrastructure;
using HaberPortal.Data.DataContext;
using HaberPortal.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Core.Repository
{
    public class ResimRepository : IResimRepository
    {
        private readonly HaberContext _context = new HaberContext();
        public int Count()
        {
            return _context.Resim.Count(); //haber tablosundaki kayıt sayısını verir.
        }

        public void Delete(int id)
        {
            var Resim = GetById(id);
            if (Resim != null)
            {
                _context.Resim.Remove(Resim); //Silme işlemi.
            }
        }

        public Resim Get(Expression<Func<Resim, bool>> expression)
        {
            return _context.Resim.FirstOrDefault(expression); // expression sonucu tek bir değer dönecek.
        }

        public IEnumerable<Resim> GetAll()
        {
            return _context.Resim.Select(x => x);  // Tüm haberler dönecek.
        }

        public Resim GetById(int id)
        {
            return _context.Resim.FirstOrDefault(x => x.ID == id); //Sadece gelen ID ye göre dönecek. Modelden gelen ID ile gelen id eşit ise sonuç döndürecek.
        }

        public IQueryable<Resim> GetMany(Expression<Func<Resim, bool>> expression)
        {
            return _context.Resim.Where(expression); //expression sonucu BİRDEN FAZLA değer dönecek.
        }

        public void Insert(Resim obj)
        {
            _context.Resim.Add(obj); //Insert metodumuz.
        }

        public void Save()
        {
            _context.SaveChanges(); //kaydetme metodu.
        }

        public void Update(Resim obj)
        {
            _context.Resim.AddOrUpdate(); //ekle ya da güncelle metodu.
        }
    }
}
