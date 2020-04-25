using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.fluentNHibernate;
using webProjesi.fluentNHibernate.controllers;
using webProjesi.fluentNHibernate.domainClasses;

namespace webProjesi.html
{
    public partial class adminYonetim : System.Web.UI.Page
    {
        public string firsatDurumu;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void setList()
        {
            myTable.Rows.Clear(); // TABLO HER SEFERINDE GUNCELLENIRKEN  ESKI DEGERLERIN SILINMESI LAZIM
            // SILINIRKEN TABLONUN BASLIGIDA GIDIYO HALIYLE ONUDA YENIDEN YAZDIK.
            TableRow headerRow = new TableRow();
            headerRow.CssClass = "tableHeader";

            TableCell baslik1 = new TableCell();
            baslik1.Text = "Kampanya Numarasi";
            headerRow.Cells.Add(baslik1);

            TableCell baslik2 = new TableCell();
            baslik2.Text = "Firma Adi";
            headerRow.Cells.Add(baslik2);

            TableCell baslik3 = new TableCell();
            baslik3.Text = "Firma Sektoru";
            headerRow.Cells.Add(baslik3);

            TableCell baslik4 = new TableCell();
            baslik4.Text = "Adres";
            headerRow.Cells.Add(baslik4);

            TableCell baslik5 = new TableCell();
            baslik5.Text = "Mahalle";
            headerRow.Cells.Add(baslik5);

            TableCell baslik6 = new TableCell();
            baslik6.Text = "Sehir";
            headerRow.Cells.Add(baslik6);

            TableCell baslik7 = new TableCell();
            baslik7.Text = "Ürün";
            headerRow.Cells.Add(baslik7);

            TableCell baslik8 = new TableCell();
            baslik8.Text = "Normal Fiyat";
            headerRow.Cells.Add(baslik8);

            TableCell baslik9 = new TableCell();
            baslik9.Text = "Indirimli Fiyat";
            headerRow.Cells.Add(baslik9);

            TableCell baslik10 = new TableCell();
            baslik10.Text = "Kisi sayisi ";
            headerRow.Cells.Add(baslik10);

            TableCell baslik11 = new TableCell();
            baslik11.Text = "Ne zaman ? ";
            headerRow.Cells.Add(baslik11);

            myTable.Rows.Add(headerRow);
            // DATABASE SORGU ATIP TUM ONAYLI FIRSATLARI GETIRIDIK;
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.onayDurumu == firsatDurumu
                            select yeniFirsatlar;
                var firsatlar = query.ToList();
                foreach (var item in firsatlar)
                {
                    // HER FIRSAT ICIN BI SATIR OLUSTURDU.
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.ID = "kNo";
                    TableCell firmaAdi = new TableCell();
                    firmaAdi.ID = "firmaAdi";
                    TableCell firmaSektoru = new TableCell();
                    firmaSektoru.ID = "firmaSektoru";
                    TableCell adres = new TableCell();
                    adres.ID = "adres";
                    TableCell mahalle = new TableCell();
                    mahalle.ID = "mahalle";
                    TableCell sehir = new TableCell();
                    sehir.ID = "sehir";
                    TableCell urun = new TableCell();
                    urun.ID = "urun";
                    TableCell fiyat = new TableCell();
                    fiyat.ID = "normalFiyat";
                    TableCell indirimliFiyat = new TableCell();
                    indirimliFiyat.ID = "indirimliFiyat";
                    TableCell kisiSayisi = new TableCell();
                    kisiSayisi.ID = "kisiSayisi";
                    TableCell neZaman = new TableCell();
                    neZaman.ID = "neZaman";


                    System.Diagnostics.Debug.WriteLine(2);
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
                    myTable.Rows.Add(row);
                }
            }

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            firsatDurumu = "onaylandi";
            hdnGoruntulenenFirsatTuru.Value = "onaylandi";
            setList();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            firsatDurumu = "Onay Bekliyor";
            hdnGoruntulenenFirsatTuru.Value = "Onay Bekliyor";
            setList();
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            // firsat guncelle;
           
            guncellePanel.Attributes["visibility"] = "visible";
         
            //yeniFirsat
         
        }

        protected void Unnamed4_Click(object sender, EventArgs e)
        {
            // firsati sonlandir
            int kampanyaNo = Convert.ToInt32(hdnKampanyaNo.Value);
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var updateQuery = session.CreateQuery("Update yeniFirsatlar set onaydurumu = 'gecmisFirsat' where id =:firsatId  ");
                System.Diagnostics.Debug.WriteLine(kampanyaNo);
               
                updateQuery.SetParameter("firsatId", kampanyaNo);
                updateQuery.ExecuteUpdate();

                updateQuery = session.CreateQuery("Update firsatLog set firsatdurumu = 'gecmisFirsat' where  firsatid =:firsatId ");
                updateQuery.SetParameter("firsatId", kampanyaNo.ToString());
                updateQuery.ExecuteUpdate();
                
            }
        }

        protected void Unnamed5_Click(object sender, EventArgs e)
        {
            // FIRSATI ONAYLA BUTTONU

            int kampanyaNo = Convert.ToInt32(hdnKampanyaNo.Value);
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var updateQuery = session.CreateQuery("Update yeniFirsatlar set onaydurumu = 'onaylandi' where id =:firsatId  ");
                System.Diagnostics.Debug.WriteLine(kampanyaNo);

                updateQuery.SetParameter("firsatId", kampanyaNo);
                updateQuery.ExecuteUpdate();


            }
        }

        protected void Unnamed7_Click(object sender, EventArgs e)
        {
            // reddet butonu

            int kampanyaNo = Convert.ToInt32(hdnKampanyaNo.Value);
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var updateQuery = session.CreateQuery("Update yeniFirsatlar set onaydurumu = 'reddedildi' where id =:firsatId  ");
                System.Diagnostics.Debug.WriteLine(kampanyaNo);

                updateQuery.SetParameter("firsatId", kampanyaNo);
                updateQuery.ExecuteUpdate();


            }

        }

        protected void Unnamed8_Click(object sender, EventArgs e)
        {
            // Guncelle
            yeniFirsatlar guncelle = new yeniFirsatlar();
            guncelle.id = Convert.ToInt32( hdnKampanyaNo.Value);
            guncelle.firmaAdi = ifirmaAdi.Value;
            guncelle.firmaSektoru = ifirmaSektoru.Value;
            guncelle.adres = iadres.Value;
            guncelle.mahalle = imahalle.Value;
            guncelle.urun = iurun.Value;
            guncelle.normalFiyat = inormalFiyat.Value;
            guncelle.indirimliFiyat = iindirimliFiyat.Value;
            guncelle.kisiSayisi = ikisiSayisi.Value;
            guncelle.neZaman = ineZaman.Value;
            guncelle.sehir = "Ankara";
            guncelle.onayDurumu = "onaylandi";
            guncelle.yayinciIsimSoyisim = "Admin Guncellemesi ";
            guncelle.yayinciTcNo = "11111111111";
            yeniFirsatlarController.update(guncelle);


        }
    }
}

                
