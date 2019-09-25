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
    public partial class RetrievePackage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        private void BindGrid()
        {
            string constr = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog =vehicleRouting;Integrated Security=True";
            var url = Request.QueryString["CustomerID"];
            string select = "select PackageID,PackageWidth,PackageHeight from Package where CustomerID="+ url;

            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(select))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView2.DataSource = dt;
                            GridView2.DataBind();
                        }
                    }
                }
            }

            SqlConnection db = new SqlConnection(constr);
            db.Open();
            string select1 = "select Name from Customers where CustomerID=" + url;
            SqlCommand cmd1 = new SqlCommand(select1, db);
            SqlDataReader dr = cmd1.ExecuteReader();
            //Building an HTML string.
            System.Text.StringBuilder html = new System.Text.StringBuilder();

            while (dr.Read())
            {
                html.Append("<div>" + dr["Name"] + "</div>");
                customerName.Controls.Add(new Literal { Text = html.ToString() });
            }
            db.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var url = Request.QueryString["CustomerID"];
            Response.Redirect("AddPackage.aspx?CustomerID="+url);
        }
    }
}