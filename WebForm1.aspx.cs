using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BALclass;


namespace WebApplication2
{
    //
    public partial class WebForm1 : System.Web.UI.Page
    {
        BAL obj = new BAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //
      // 
        protected void Button1_Click(object sender, EventArgs e)
        {
            obj.InsertData(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text,Convert.ToDecimal(TextBox5.Text));
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            obj.DeleteData(Convert.ToInt32(TextBox1.Text));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            obj.UpdateData(Convert.ToInt32(TextBox1.Text), TextBox2.Text, TextBox3.Text, TextBox4.Text, Convert.ToDecimal(TextBox5.Text));
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            obj.SelectData();
        }

    }
}