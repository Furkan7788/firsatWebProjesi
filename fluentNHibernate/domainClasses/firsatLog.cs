using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webProjesi.fluentNHibernate.domainClasses
{
    public class firsatLog
    {
        public virtual int id { set; get; }
        public virtual string uyeTcNo { set; get; }
        public virtual string firsatId { set; get; }
        public virtual string firsatDurumu { set; get; }

    }
}