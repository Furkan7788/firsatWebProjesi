using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using webProjesi.fluentNHibernate.domainClasses;

namespace webProjesi.fluentNHibernate.mappingClasses
{
    public class yeniFirsatlarMap : ClassMap<yeniFirsatlar>
    {
       public yeniFirsatlarMap()
        {
            Id(x => x.id).GeneratedBy.Increment();
            Map(x => x.firmaAdi);
            Map(x => x.firmaSektoru);
            Map(x => x.adres);
            Map(x => x.mahalle);
            Map(x => x.sehir);
            Map(x => x.urun);
            Map(x => x.normalFiyat);
            Map(x => x.indirimliFiyat);
            Map(x => x.kisiSayisi);
            Map(x => x.neZaman);
            Map(x => x.yayinciTcNo);
            Map(x => x.yayinciIsimSoyisim);
            Map(x => x.onayDurumu);
        }
    }
}