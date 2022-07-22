using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShopizonProject
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox3.Text!=null && TextBox4.Text != null && TextBox2.Text!=null && TextBox1.Text!=null)
            {
                Response.Write("Your order has been placed successfully!");
            }
            else
            {
                Response.Write("Please make sure that all of your data was entered correctly");
            }
        }
    }
}