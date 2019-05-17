using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication3.DataSet1TableAdapters;

namespace WebApplication3
{
    public partial class Data1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OrdersTableAdapter tableAdapter = new OrdersTableAdapter();

            TextBox1.Text = Convert.ToString(tableAdapter.Order_Count());
        }
    }
}