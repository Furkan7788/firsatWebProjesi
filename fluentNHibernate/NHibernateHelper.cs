using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webProjesi.fluentNHibernate
{
    public class NHibernateHelper
    {
        public static ISessionFactory CreateSessionFactory()
        {
            string connectionStr = "Driver = {PostgreSQL}; Server=127.0.0.1;Port=5432;Database=postgres  ;Uid=postgres;Pwd=1903; ";
            return Fluently.Configure()
                .Database(PostgreSQLConfiguration.Standard.ConnectionString(
                    c =>
                    c.Host("localhost")
                    .Port(5432)
                    .Database("postgres")
                    .Username("postgres")
                    .Password("1903")))
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Program>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Create(false, false))
                .BuildSessionFactory();
        }
    }
}