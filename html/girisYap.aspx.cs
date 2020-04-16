using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.fluentNHibernate;
using webProjesi.fluentNHibernate.controllers;
using webProjesi.fluentNHibernate.domainClasses;
using webProjesi.services;
namespace webProjesi.html
{
    public partial class WebForm1 : System.Web.UI.Page
    {   
        private yeniUyeKayit uye = new yeniUyeKayit();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGonder_Click(object sender, EventArgs e)
        {
            string enteredTcNo = String.Format("{0}", Request.Form["tcNo"]);
            string enteredSifre = String.Format("{0}", Request.Form["sifre"]);
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniUyeKayit in session.Query<yeniUyeKayit>()
                            where yeniUyeKayit.tcNo == enteredTcNo
                            && yeniUyeKayit.sifre == enteredSifre
                            select yeniUyeKayit;

                var uyeler = query.ToList();
                foreach (var item in uyeler)
                {
                    System.Diagnostics.Debug.WriteLine(3);
                    System.Diagnostics.Debug.WriteLine(item.tcNo+"sifre "+item.sifre+"isimsoyisim "+ item.isimSoyisim+"email"+item.email+"telno"+item.telNo);
                    uyeService.uye = item;
                    
                }
                if(uyeler.Count == 0)
                {
                    this.ikaz.InnerHtml = "BILGILERINIZI YANLIS GIRDINIZ";
                    this.tcNo.Style["background-color"] = " red";
                    this.sifre.Style["background-color"] = "red";
                       
                }
                else
                {

                    Response.Redirect("uyeAnasayfa.aspx");
                }
                


            }
        }
        public yeniUyeKayit getUye()
        {
            return uye;
        }
    }
}