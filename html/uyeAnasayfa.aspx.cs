using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using webProjesi.fluentNHibernate;
using webProjesi.fluentNHibernate.controllers;
using webProjesi.fluentNHibernate.domainClasses;
using webProjesi.services;
namespace webProjesi.html
{
    public partial class uyeAnasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.onayDurumu == "onaylandi"
                            select yeniFirsatlar;
                var firsatlar = query.ToList();
                foreach (var item in firsatlar)
                {
                    
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    firmaAdi.ID = "fAdi";
                    TableCell firmaSektoru = new TableCell();
                    firmaSektoru.ID = "fSektoru";
                    TableCell adres = new TableCell();
                    adres.ID = "fAdres";
                    TableCell mahalle = new TableCell();
                    mahalle.ID = "fMahalle";
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    neZaman.ID = "neZmn";
                    kampanyaNo.Text = item.id.ToString();
                    firmaAdi.Text = item.firmaAdi;
                    firmaSektoru.Text = item.firmaSektoru;
                    adres.Text = item.adres;
                    mahalle.Text = item.mahalle;
                    sehir.Text = item.sehir;
                    urun.Text = item.urun;
                    fiyat.Text = item.normalFiyat;
                    indirimliFiyat.Text = item.indirimliFiyat;
                    kisiSayisi.Text = item.kisiSayisi;
                    neZaman.Text = item.neZaman;
                    row.Cells.Add(kampanyaNo);   
                    
                    row.Cells.Add(firmaAdi);                  
                    row.Cells.Add(firmaSektoru);                   
                    row.Cells.Add(adres);             
                    row.Cells.Add(mahalle);                 
                    row.Cells.Add(sehir);
                    row.Cells.Add(urun);
                    row.Cells.Add(fiyat);     
                    row.Cells.Add(indirimliFiyat);    
                    row.Cells.Add(kisiSayisi);
                    row.Cells.Add(neZaman);
                    row.ID = "myTableRow";
                     
                    //row.Attributes.Add("onClick",   TableClick() ) ;
                    //row.ID = kampanyaNo.ToString();
                    myTable.Rows.Add(row);
                    
                    

                }

            }
            
        }
       void LnkBtn_Click(Object sender , EventArgs e)
        {
            
        }

        protected void firsatiOnayla_Click(object sender, EventArgs e)
        {
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.id.ToString() ==  hdnKampanyaNo.Value
                            select yeniFirsatlar;
                
                 var firsat = query.ToList();
                foreach(var item in firsat)
                {
                    System.Diagnostics.Debug.WriteLine(item.id);
                    var kisiSayisi =  Int32.Parse( item.kisiSayisi);
                    kisiSayisi--;
                    item.kisiSayisi = kisiSayisi.ToString();
                    yeniFirsatlarController.update(item);
                }
            }
             firsatLog log = new firsatLog();
            log.firsatId = hdnKampanyaNo.Value;
            log.uyeTcNo = services.uyeService.uye.tcNo;
            log.firsatDurumu = "firsata gidecek";
            firsatLogController.add(log); // TRIGER YAZCAN AYNI FIRSATA TEKRAR KATILAMAYCAK

        }
    }
}