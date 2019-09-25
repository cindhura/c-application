using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace vehicleRouting
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string con = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog =vehicleRouting;Integrated Security=True";
            SqlConnection db = new SqlConnection(con);
            db.Open();
            string insert = "insert into Customers(Name,EmailAddress,Address,Packages,DeliveryDate,DueDate) values ('" + name.Text + "','" + emailAddress.Text + "','" + address.Text + "','" + packages.Text + "','" + deliveryDate.Text + "','" + dueDate.Text + "')";
    
            SqlCommand cmd = new SqlCommand(insert, db);
            int m = cmd.ExecuteNonQuery();
            if (m != 0)
            {
                Response.Write("<script> alert('Data Inserted !!') </script>");
                Response.Redirect("Retrieve.aspx");
            }
            else
            {
                Response.Write("<script> alert('Data Inserted !!') </script>");
            }
            db.Close();
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}