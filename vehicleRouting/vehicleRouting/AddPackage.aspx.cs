using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.HtmlControls;

namespace vehicleRouting
{
    public partial class AddPackage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog =vehicleRouting;Integrated Security=True";
            SqlConnection db = new SqlConnection(constr);
            db.Open();
            var url = Request.QueryString["CustomerID"];
            string select = "select Name from Customers where CustomerID="+url;
            SqlCommand cmd = new SqlCommand(select, db);
            SqlDataReader dr = cmd.ExecuteReader();
            //Building an HTML string.
            System.Text.StringBuilder html = new System.Text.StringBuilder();

            while (dr.Read()) {
                html.Append("<div>"+dr["Name"]+"</div>");
                customerName.Controls.Add(new Literal { Text = html.ToString() });
            }
            db.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string constr = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog =vehicleRouting;Integrated Security=True";
            SqlConnection db = new SqlConnection(constr);
            db.Open();
            var url = Request.QueryString["CustomerID"];
            string select = "select Packages from Customers where CustomerID=" + url;
            string selectPackageCount = "select CustomerID from Package where CustomerID=" + url;
            SqlCommand cmd = new SqlCommand(select, db);
            SqlDataReader dr = cmd.ExecuteReader();
            var counter = 0;
            int packages = 0;
            while (dr.Read())
            {
                packages = Convert.ToInt16 (dr["Packages"].ToString());
            }
            db.Close();

            db.Open();
            SqlCommand cmd1 = new SqlCommand(selectPackageCount, db);
            SqlDataReader dr1 = cmd1.ExecuteReader();

            while (dr1.Read())
            {
                var count = dr1["CustomerID"];
                counter++;
            }
            db.Close();

            if (counter < packages)
            {
                string con = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog =vehicleRouting;Integrated Security=True";
                SqlConnection db1 = new SqlConnection(con);
                db.Open();
                string insert = "insert into Package(PackageWidth,PackageHeight,CustomerID) values ('" + packageWidth.Text + "','" + packageHeight.Text + "','" + url + "')";

                SqlCommand cmd2 = new SqlCommand(insert, db);
                int m = cmd2.ExecuteNonQuery();
                if (m != 0)
                {
                    Response.Write("<script> alert('Data Inserted !!') </script>");
                    Response.Redirect("RetrievePackage.aspx?CustomerID="+url);
                }
                else
                {
                    Response.Write("<script> alert('Data Inserted !!') </script>");
                }
            }
            else {
                Response.Write("<script> alert('Exceeds packages count!!') </script>");
                Response.Redirect("RetrievePackage.aspx?CustomerID=" + url);
            }
        }
    }
}