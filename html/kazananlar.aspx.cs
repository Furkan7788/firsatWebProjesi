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
    public partial class kazananlar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {

            var isession = NHibernateHelper.CreateSessionFactory();
            using (var session = isession.OpenSession())
            {
                var query = from yeniFirsatlar in session.Query<yeniFirsatlar>()
                            where yeniFirsatlar.onayDurumu == "gecmisFirsat"
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
}