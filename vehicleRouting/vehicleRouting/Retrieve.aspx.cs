﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace vehicleRouting
{
    public partial class Retrieve : System.Web.UI.Page
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
            string select = "select CustomerID,Name,EmailAddress,Address,Packages,DeliveryDate,DueDate from Customers";

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
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }
    }
}