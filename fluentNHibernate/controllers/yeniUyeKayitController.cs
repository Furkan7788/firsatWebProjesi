using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;

namespace webProjesi.fluentNHibernate.controllers
{
    public class yeniUyeKayitController
    {
        
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
    }
}