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
    public class KategoriRepository : IKategoriRepository
    {
        private readonly HaberContext _context = new HaberContext();
        public int Count()
        {
            return _context.Kategori.Count(); //kategori tablosundaki kayıt sayısını verir.
        }

        public void Delete(int id)
        {
            var Kategori = GetById(id);
            if (Kategori != null)
            {
                _context.Kategori.Remove(Kategori); //Silme işlemi.
            }
        }

        public Kategori Get(Expression<Func<Kategori, bool>> expression)
        {
            return _context.Kategori.FirstOrDefault(expression); // expression sonucu tek bir değer dönecek.
        }

     

        public IEnumerable<Kategori> GetAll()
        {
            return _context.Kategori.Select(x => x);  // Tüm kategoriler dönecek.
        }

        public Kategori GetById(int id)
        {
            return _context.Kategori.FirstOrDefault(x => x.ID == id); //Sadece gelen ID ye göre dönecek. Modelden gelen ID ile gelen id eşit ise sonuç döndürecek.
        }

        public IQueryable<Kategori> GetMany(Expression<Func<Kategori, bool>> expression)
        {
            return _context.Kategori.Where(expression); //expression sonucu BİRDEN FAZLA değer dönecek.
        }

       

        public void Insert(Kategori obj)
        {
            _context.Kategori.Add(obj); //Insert metodumuz.
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Kategori obj)
        {
            _context.Kategori.AddOrUpdate();
        }
    }
}
