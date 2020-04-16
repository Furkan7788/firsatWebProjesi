using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;
using webProjesi.services;

namespace webProjesi.fluentNHibernate.controllers
{
    public class yeniUyeKayitController
    {
        private yeniUyeKayit uyem = new yeniUyeKayit();
        public static void add(yeniUyeKayit uye)
        {
  
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.SaveOrUpdate(uye);
                    trans.Commit();
                }
            }
        }
        public static void update(yeniUyeKayit uye)
        {
            uye.id = services.uyeService.uye.id;
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.Update(uye);
                    trans.Commit();
                }
            }

        }
        public static void delete(yeniUyeKayit uye)
        {
            uye.id = services.uyeService.uye.id;
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.Delete(uye);
                    trans.Commit();
                }
            }

        }
       
    }
}