using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;
namespace webProjesi.fluentNHibernate.mappingClasses
{
    public class firsatLogMap: ClassMap<firsatLog>
    {
        public firsatLogMap()
        {
            Id(x => x.id).GeneratedBy.Increment();
            Map(x => x.uyeTcNo);
            Map(x => x.firsatId);
            Map(x => x.firsatDurumu);
        }
    }
}