using NHibernate;
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
    public partial class benimFirsatlarim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                // UYENIN GIDECEGI FIRSATLARI LISTELEME
                var joinQuery = from firsatLog in session.Query<firsatLog>()
                                join yeniFirsatlar in session.Query<yeniFirsatlar>() on firsatLog.firsatId equals yeniFirsatlar.id.ToString()
                                where firsatLog.uyeTcNo == services.uyeService.uye.tcNo && firsatLog.firsatDurumu == "firsata gidecek"
                                select yeniFirsatlar ;

                var firsatlar = joinQuery.ToList();
                foreach (var item in firsatlar)
                {
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    TableCell firmaSektoru = new TableCell();
                    TableCell adres = new TableCell();
                    TableCell mahalle = new TableCell();
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    TableCell onayDurumu = new TableCell();
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
                    onayDurumu.Text = item.onayDurumu;
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
                    myTable.Rows.Add(row);


                }
                // Gecmis FIRSATLARIM
                joinQuery = from firsatLog in session.Query<firsatLog>()
                            join yeniFirsatlar in session.Query<yeniFirsatlar>() on firsatLog.firsatId equals yeniFirsatlar.id.ToString()
                            where firsatLog.uyeTcNo == services.uyeService.uye.tcNo && firsatLog.firsatDurumu == "gecmisFirsat"
                            select yeniFirsatlar;
                firsatlar = joinQuery.ToList();
                foreach (var item in firsatlar)
                {
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    TableCell firmaSektoru = new TableCell();
                    TableCell adres = new TableCell();
                    TableCell mahalle = new TableCell();
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    TableCell onayDurumu = new TableCell();
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
                    onayDurumu.Text = item.onayDurumu;
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
                    Table1.Rows.Add(row);


                }
                //onay bekleyen firsatlar
                joinQuery = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.yayinciTcNo == services.uyeService.uye.tcNo &&
                            yeniFirsatlar.onayDurumu == "Onay Bekliyor"
                            select yeniFirsatlar;
                firsatlar = joinQuery.ToList();
                foreach (var item in firsatlar)
                {
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    TableCell firmaSektoru = new TableCell();
                    TableCell adres = new TableCell();
                    TableCell mahalle = new TableCell();
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    TableCell onayDurumu = new TableCell();
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
                    onayDurumu.Text = item.onayDurumu;
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
                    Table2.Rows.Add(row);


                }
                //Reddedilen firsatlar
                joinQuery = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.yayinciTcNo == services.uyeService.uye.tcNo &&
                            yeniFirsatlar.onayDurumu == "reddedildi"
                            select yeniFirsatlar;
                firsatlar = joinQuery.ToList();
                foreach (var item in firsatlar)
                {
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    TableCell firmaSektoru = new TableCell();
                    TableCell adres = new TableCell();
                    TableCell mahalle = new TableCell();
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    TableCell onayDurumu = new TableCell();
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
                    onayDurumu.Text = item.onayDurumu;
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
                    Table3.Rows.Add(row);


                }



            }

           


        }

        protected void bekleyenFirsat_Click(object sender, EventArgs e)
        {   
            
            yeniFirsatlarController.delete(Convert.ToInt32( hdnBekleyenKampanyaNo.Value));
        }

        protected void vazgec_Click(object sender, EventArgs e)
        {
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.id.ToString() == hdnGidelecekFirsatId.Value
                            select yeniFirsatlar;
               
                var firsat = query.ToList();
                foreach (var item in firsat)
                {
                    System.Diagnostics.Debug.WriteLine(item.id);
                    var kisiSayisi = Int32.Parse(item.kisiSayisi);
                    kisiSayisi++;
                    item.kisiSayisi = kisiSayisi.ToString();
                    yeniFirsatlarController.update(item);
                }

                var updateQuery = session.CreateQuery("Update firsatLog set firsatdurumu = 'Gitmekten Vazgecti' where uyetcno =:uyeTcNo and firsatid =:firsatId  ");
                updateQuery.SetParameter("firsatId", hdnGidelecekFirsatId.Value);
                updateQuery.SetParameter("uyeTcNo", services.uyeService.uye.tcNo);
                updateQuery.ExecuteUpdate();
             }
        }
    }
}