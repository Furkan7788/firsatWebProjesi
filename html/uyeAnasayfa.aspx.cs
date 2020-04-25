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

        public string listelemeTuru = "null"; // ARAMA MOTORU ICIN;
        protected void Page_Load(object sender, EventArgs e)
        {

            setList();
            
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
                            where yeniFirsatlar.onayDurumu == "onaylandi"
                            select yeniFirsatlar;
                var firsatlar = query.ToList();
                foreach (var item in firsatlar)
                {
                    // HER FIRSAT ICIN BI SATIR OLUSTURDU.
                    TableRow row = new TableRow();
                    TableCell kampanyaNo = new TableCell();
                    kampanyaNo.CssClass = "kNo";
                    TableCell firmaAdi = new TableCell();
                    firmaAdi.CssClass = "fAdi";
                    TableCell firmaSektoru = new TableCell();
                    firmaSektoru.CssClass = "fSektoru";
                    TableCell adres = new TableCell();
                    adres.CssClass = "fAdres";
                    TableCell mahalle = new TableCell();
                    mahalle.CssClass = "fMahalle";
                    TableCell sehir = new TableCell();
                    TableCell urun = new TableCell();
                    TableCell fiyat = new TableCell();
                    TableCell indirimliFiyat = new TableCell();
                    TableCell kisiSayisi = new TableCell();
                    TableCell neZaman = new TableCell();
                    neZaman.CssClass = "neZmn";

                    if (listelemeTuru == "firsatTuru")
                    { // FIRSAT TURUNE GORE LISTELEME YAPARSA 

                        // KULLANICININ SECTIGI FIRSAT TURU ILE BIZE GELEN FIRSATLARDAN FIRSAT TURU AYNI OLANLAR LISTELENIR
                        if (item.firmaSektoru == hdnFirsatTuru.Value)
                        {
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

                    else if (listelemeTuru == "mahalle")
                    {
                        System.Diagnostics.Debug.WriteLine(12);
                        if (item.mahalle == hdnMahalle.Value)
                        {
                            System.Diagnostics.Debug.WriteLine(13);
                            System.Diagnostics.Debug.WriteLine(4);
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

                    else if (listelemeTuru == "ikiside")
                    {
                        System.Diagnostics.Debug.WriteLine(5);
                        if (item.mahalle == hdnMahalle.Value && item.firmaSektoru == hdnFirsatTuru.Value)
                        {
                            System.Diagnostics.Debug.WriteLine(6);
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
                    else if (listelemeTuru == "null")
                    {
                        System.Diagnostics.Debug.WriteLine(7);
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
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        { // ARAMA CESITLERININ SET EDILDIGI BUTTON
            var isession = NHibernateHelper.CreateSessionFactory();
            if (hdnFirsatTuru.Value == "null" && hdnMahalle.Value != "null")
            {
                System.Diagnostics.Debug.WriteLine(11);
                listelemeTuru = "mahalle";
                
                setList();
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null;";
            }
            else if (hdnFirsatTuru.Value != "null" && hdnMahalle.Value == "null")
            {
                listelemeTuru = "firsatTuru";
               
                setList();
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null";
            }
            else if (hdnFirsatTuru.Value != "null" && hdnMahalle.Value != "null")
            {
                listelemeTuru = "ikiside";
              
                setList();
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null";
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("secim yap");
                setList();
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            // TUMUNU LISTELE BUTONU
            listelemeTuru = "null";
        }
  

    protected void firsatiOnayla_Click(object sender, EventArgs e)
        {
            var sayac = 0;
            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.id.ToString() == hdnKampanyaNo.Value
                            select yeniFirsatlar;

                var firsat = query.ToList();
                foreach (var item in firsat)
                {
                    System.Diagnostics.Debug.WriteLine(item.id);
                    var kisiSayisi = Int32.Parse(item.kisiSayisi);
                    kisiSayisi--;
                    item.kisiSayisi = kisiSayisi.ToString();
                    yeniFirsatlarController.update(item);
                }
                // ayni firsata uye olmamasi icin alt sorgu
                var firsatQuery = from firsatLog in session.Query<firsatLog>()
                                  where firsatLog.uyeTcNo == services.uyeService.uye.tcNo && firsatLog.firsatId == hdnKampanyaNo.Value && firsatLog.firsatDurumu == "firsata gidecek"
                                  select firsatLog;
                var firsatLogs = firsatQuery.ToList();
                
                foreach (var item in firsatLogs)
                {
                    // listede item varsa
                    sayac++;
                    System.Diagnostics.Debug.WriteLine(sayac);
                }
            }
            if (sayac > 0) {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Bu Firsata Zaten Gidiyorsunuz')", true);
                sayac = 0;

            }
            else
            {
                firsatLog log = new firsatLog();
                log.firsatId = hdnKampanyaNo.Value;
                log.uyeTcNo = services.uyeService.uye.tcNo;
                log.firsatDurumu = "firsata gidecek";
                firsatLogController.add(log); // TRIGER YAZCAN AYNI FIRSATA TEKRAR KATILAMAYCAK
            }


}
    }
}
  