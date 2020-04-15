using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;

namespace webProjesi.fluentNHibernate.mappingClasses
{
    public class yeniUyeKayitMap : ClassMap<yeniUyeKayit>
    {
       public yeniUyeKayitMap()
        {
            Id(x => x.id).GeneratedBy.Increment();
            Map(x => x.tcNo);
            Map(x => x.isimSoyisim);
            Map(x => x.email);
            Map(x => x.telNo);
            Map(x => x.sifre);

        }
    }
}