using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webProjesi.fluentNHibernate.domainClasses
{
    public class yeniUyeKayit
    {
        public virtual int id { set; get; }
        public virtual string tcNo { set; get; }
        public virtual string isimSoyisim { set; get; }
        public virtual string email { set; get; }
        public virtual string telNo { set; get; }
        public virtual string sifre { set; get; }

    }
}