using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AspMonteCarlo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                double from = Convert.ToDouble(TextBox1.Text);
                double to = Convert.ToDouble(TextBox2.Text);
                int th = Convert.ToInt32(TextBox3.Text);
                int it = Convert.ToInt32(TextBox4.Text);

                DateTime czasStart = DateTime.Now;

                ThreadCounting tc = new ThreadCounting(from, to, th, it);
                Session["czas"] = Convert.ToString(czasStart);
                Session["wynik"] = Convert.ToString(tc.obliczMC());
                Response.Redirect("result.aspx");
                
            }
            catch{
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Wprowadzone dane są niepoprawne')", true);

            }
        }
    }
}