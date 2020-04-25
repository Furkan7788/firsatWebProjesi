using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webProjesi.html.admin
{
    public partial class adminGiris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if(kullaniciAdi.Value == "admin" && sifre.Value == "1234")
            {

                Response.Redirect("adminYonetim.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Yanlis Giris Bilgileri')", true);
            }

        }
    }
}