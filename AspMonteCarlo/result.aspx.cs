using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspMonteCarlo
{
    public partial class result : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime czasStart = Convert.ToDateTime(Session["czas"]);
            TimeSpan roznica = DateTime.Now - czasStart;

            Label2.Text = Convert.ToString(Session["wynik"]);
            Label3.Text = roznica.TotalSeconds + " sek";
        }
    }
}