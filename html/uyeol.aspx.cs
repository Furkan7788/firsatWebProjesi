using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.fluentNHibernate.domainClasses;
using webProjesi.fluentNHibernate.controllers;

namespace webProjesi.html
{
    public partial class uyeol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void kayitOl_onClick(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Record Inserted Successfully')", true);
        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            var yeniUye = new yeniUyeKayit(); 
            var ctrl = new yeniUyeKayitController();
            yeniUye.tcNo = String.Format("{0}", Request.Form["tcNo"]);
            yeniUye.isimSoyisim = String.Format("{0}", Request.Form["isimSoyisim"]);
            yeniUye.telNo = String.Format("{0}", Request.Form["telNo"]);
            yeniUye.email = String.Format("{0}", Request.Form["email"]);
            yeniUye.sifre = String.Format("{0}", Request.Form["sifre"]);
            yeniUyeKayitController.add(yeniUye);
            
           
        }
    }
}