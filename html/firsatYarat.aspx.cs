using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.fluentNHibernate.domainClasses;
using webProjesi.fluentNHibernate.controllers;
using webProjesi.services;


namespace webProjesi.html
{
    public partial class firsatYarat : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void firsatGonder_Click(object sender, EventArgs e)
        {
            
            var yeniFirsat = new yeniFirsatlar();
            yeniFirsat.firmaAdi= String.Format("{0}", Request.Form["firmaAdi"]);
            yeniFirsat.firmaSektoru = String.Format("{0}", Request.Form["firmaSektoru"]);
            yeniFirsat.adres = String.Format("{0}", Request.Form["adres"]);
            yeniFirsat.mahalle = hdnResultValue.Value;
            yeniFirsat.sehir = hdnResultValue2.Value;
            yeniFirsat.urun = String.Format("{0}", Request.Form["urun"]);
            yeniFirsat.normalFiyat = String.Format("{0}", Request.Form["normalFiyat"]);
            yeniFirsat.indirimliFiyat = String.Format("{0}", Request.Form["indirimliFiyat"]);
            yeniFirsat.kisiSayisi = String.Format("{0}", Request.Form["kisiSayisi"]);
            yeniFirsat.neZaman = String.Format("{0}", Request.Form["neZaman"]);
            yeniFirsat.yayinciTcNo = services.uyeService.uye.tcNo;
            yeniFirsat.yayinciIsimSoyisim =  services.uyeService.uye.isimSoyisim;
            yeniFirsat.onayDurumu = "Onay Bekliyor";
            yeniFirsatlarController.add(yeniFirsat);
            ikaz.InnerHtml = "Fırsatınız en kısa sürede onaylanıp yayına girekcektir. TEŞEKKÜRLER " + yeniFirsat.yayinciIsimSoyisim;


        }
    }
}