﻿using HaberPortal.Core.Infrastructure;
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
    public class RolRepository : IRolRepository
    {
        private readonly HaberContext _context = new HaberContext();
        public int Count()
        {
            return _context.Rol.Count();
        }

        public void Delete(int id)
        {
            var Rol = GetById(id);
            if (Rol != null)
            {
                _context.Rol.Remove(Rol);
            }
        }

        public Rol Get(Expression<Func<Rol, bool>> expression)
        {
            return _context.Rol.FirstOrDefault(expression);
        }

       
        public IEnumerable<Rol> GetAll()
        {
            return _context.Rol.Select(x => x);
        }

        public Rol GetById(int id)
        {
            return _context.Rol.FirstOrDefault(x => x.ID == id);
        }

        public IQueryable<Rol> GetMany(Expression<Func<Rol, bool>> expression)
        {
            return _context.Rol.Where(expression);
        }

       
        public void Insert(Rol obj)
        {
            _context.Rol.Add(obj);
        }

      

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Rol obj)
        {
            _context.Rol.AddOrUpdate();
        }

       
        IEnumerable<Rol> IRepository<Rol>.GetAll()
        {
            throw new NotImplementedException();
        }

        Rol IRepository<Rol>.GetById(int d)
        {
            throw new NotImplementedException();
        }
    }
}
