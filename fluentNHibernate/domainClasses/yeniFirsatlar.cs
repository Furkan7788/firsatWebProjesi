using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webProjesi.fluentNHibernate.domainClasses
{
    public class yeniFirsatlar
    {
        public virtual int id { set; get; }
        public virtual string firmaAdi { set; get; }
        public virtual string firmaSektoru { set; get; }
        public virtual string adres { set; get; }
        public virtual string mahalle { set; get; }
        public virtual string sehir { set; get; }
        public virtual string normalFiyat { set; get; }
        public virtual string indirimliFiyat { set; get; }
        public virtual string kisiSayisi { set; get; }
        public virtual string neZaman { set; get; }
        public virtual string yayinciTcNo { set; get; }
        public virtual string yayinciIsimSoyisim { set; get; }
        public virtual string onayDurumu { set; get; }
    }

}