using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;
namespace webProjesi.fluentNHibernate.controllers
{
    public class firsatLogController
    {
        public static void add(firsatLog log)
        {

            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.SaveOrUpdate(log);
                    trans.Commit();
                }
            }

        }
        public static void update(firsatLog log)
        {

            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                using (var trans = session.BeginTransaction())
                {

                    session.Update(log);
                    trans.Commit();
                }
            }

        }
    }
}