using Autofac;
using Autofac.Integration.Mvc;
using HaberPortal.Core.Infrastructure;
using HaberPortal.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaberPortal.Admin.Class
{
    public class BootStrapper
    {
        //burası boot aşamasında çalışacak.
        //burası registerımız olacak. buraya kaydolmayan hiç bir şey çalışmayacak.
        public static void RunConfig()
        {
            BuildAutoFac();
        }
        private static void BuildAutoFac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterType <HaberRepository>().As <IHaberRepository>();
            builder.RegisterType <ResimRepository>().As <IResimRepository>();
            builder.RegisterType <KullaniciRepository>().As <IKullaniciRepository>();
            builder.RegisterType <RolRepository>().As <IRolRepository>();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}