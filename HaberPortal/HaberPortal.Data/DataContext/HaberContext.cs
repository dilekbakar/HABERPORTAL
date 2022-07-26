﻿using HaberPortal.Data.Migrations;
using HaberPortal.Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HaberPortal.Data.DataContext
{
    public class HaberContext : DbContext
    {
        public HaberContext():base("HaberContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<HaberContext, Configuration>());
        }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Rol> Rol { get; set; }

        public DbSet<Haber> Haber { get; set; }

        public DbSet<Resim> Resim { get; set; }
        public DbSet<Kategori> Kategori { get; set; }
        


    }
}
