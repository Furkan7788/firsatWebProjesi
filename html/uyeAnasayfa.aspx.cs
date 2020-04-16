using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using webProjesi.services;
namespace webProjesi.html
{
    public partial class uyeAnasayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.uyeIsimSoyisim.InnerHtml = services.uyeService.uye.isimSoyisim.ToString();
            this.uyeTcno.InnerHtml = services.uyeService.uye.tcNo.ToString();
        }
    }
}