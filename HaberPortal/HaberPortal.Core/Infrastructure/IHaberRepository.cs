using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HaberPortal.Data.Model;

namespace HaberPortal.Core.Infrastructure
{
    public interface IHaberRepository : IRepository<Haber> //IRepositor'den türeyecek ve haber modelimizi içerecek.
    {
    }
}
