using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.fluentNHibernate;
using webProjesi.fluentNHibernate.domainClasses;

namespace webProjesi.html
{

     
    public partial class firsatlar : System.Web.UI.Page
    {
        public string listelemeTuru = "null";
        protected void Page_Load(object sender, EventArgs e)
        {
            setList();
        }
        // BURANIN ACIKLAMASI UYEANASAYFA DA YAZDILDI.
        protected void setList()
        {
            myTable.Rows.Clear();

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

                    if (listelemeTuru == "firsatTuru")
                    {

                        System.Diagnostics.Debug.WriteLine(1);
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
                        System.Diagnostics.Debug.WriteLine(3);
                        if (item.mahalle == hdnMahalle.Value)
                        {
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
                    else if(listelemeTuru == "null")
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
        {
            var isession = NHibernateHelper.CreateSessionFactory();
            if ( hdnFirsatTuru.Value == "null" && hdnMahalle.Value != "null")
            {
                listelemeTuru = "mahalle";
                setList();
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null";
            }
           else if ( hdnFirsatTuru.Value != "null" &&  hdnMahalle.Value == "null")
            {
                listelemeTuru = "firsatTuru";
                setList();
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null";
            }
            else if( hdnFirsatTuru.Value != "null" && hdnMahalle.Value != "null")
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
                hdnFirsatTuru.Value = "null";
                hdnMahalle.Value = "null";
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {
            listelemeTuru = "null";
        }
    }
}