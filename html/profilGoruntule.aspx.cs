using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.services;
using webProjesi.fluentNHibernate.controllers;

namespace webProjesi.html
{
    public partial class profilGoruntule : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            hprofilTcNo.Value = services.uyeService.uye.tcNo;
            hprofilAdiSoyadi.Value = services.uyeService.uye.isimSoyisim;
            hprofilEmail.Value = services.uyeService.uye.email;
            hprofilTelNo.Value = services.uyeService.uye.telNo;
            hprofilSifre.Value = services.uyeService.uye.sifre;
        }

        protected void uyeKaydiGuncelle_Click(object sender, EventArgs e)
        {
           
            services.uyeService.uye.tcNo = String.Format("{0}", Request.Form["profilTcNo"]);
            services.uyeService.uye.isimSoyisim = String.Format("{0}", Request.Form["profilAdiSoyadi"]);
            services.uyeService.uye.email = String.Format("{0}", Request.Form["profilEmail"]);
            services.uyeService.uye.telNo = String.Format("{0}", Request.Form["profilTelNo"]);
            services.uyeService.uye.sifre = String.Format("{0}", Request.Form["profilSifre"]);
            yeniUyeKayitController.update(services.uyeService.uye);
            profilIkaz.InnerHtml = "GUNCELLEME BASARILI";
        }

        protected void uyeKaydiSil_Click(object sender, EventArgs e)
        {
            services.uyeService.uye.tcNo = String.Format("{0}", Request.Form["profilTcNo"]);
            services.uyeService.uye.isimSoyisim = String.Format("{0}", Request.Form["profilAdiSoyadi"]);
            services.uyeService.uye.email = String.Format("{0}", Request.Form["profilEmail"]);
            services.uyeService.uye.telNo = String.Format("{0}", Request.Form["profilTelNo"]);
            services.uyeService.uye.sifre = String.Format("{0}", Request.Form["profilSifre"]);
            yeniUyeKayitController.delete(services.uyeService.uye);
            profilIkaz.InnerHtml = "HESABINIZ SILINDI :(";
            Response.Redirect("girisYap.aspx");
        }
        
    }
}