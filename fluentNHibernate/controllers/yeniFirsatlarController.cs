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
    public class yeniFirsatlarController
    {
        public static void add(yeniFirsatlar firsat)
        {

            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.SaveOrUpdate(firsat);
                    trans.Commit();
                }
            }

        }
        public static void update(yeniFirsatlar firsat)
        {
          
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.Update(firsat);
                    trans.Commit();
                }
            }

        }
        public static void delete(int firsatId)
        {

            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {
                    yeniFirsatlar deleted = new yeniFirsatlar();
                    deleted.id = firsatId;
                    session.Delete(deleted);
                    trans.Commit();
                }
            }

        }
    }

}
