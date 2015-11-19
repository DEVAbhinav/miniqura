using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Data.SqlTypes;
public partial class after_login : System.Web.UI.Page
{
   
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {


            string dob = null;
            database q = new database();
            DataTable t,d;
            t = q.select("select name,email from reg_login where email='" + Session["emailID"].ToString().Trim() + "'");
            d = q.select("select *from detail where email='" + Session["emailID"].ToString().Trim() + "'");
            if (t.Rows.Count > 0)
            {
                txtname.Text = t.Rows[0][0].ToString();
                 txtemail.Text = t.Rows[0][1].ToString();
                 if (d.Rows[0][1].ToString() == "Male")
                     Male.Checked = true;
                 if (d.Rows[0][1].ToString() == "Female")
                   Female.Checked = true;
                   txtadd.Text = d.Rows[0][2].ToString();
                 txtstate.Text = d.Rows[0][3].ToString();
                 txtcity.Text = d.Rows[0][4].ToString();
                 txtpin.Text = d.Rows[0][5].ToString();
                 txtmobile.Text = d.Rows[0][6].ToString();
            }
        }
    }


   protected void btn_home(object sender, EventArgs e)
    {

        int userId = 0;
        String gen=null;
        string conblog = ConfigurationManager.ConnectionStrings["conblog"].ConnectionString;
        using (SqlConnection con = new SqlConnection(conblog))
        {
            using (SqlCommand cmd = new SqlCommand("Proc_detail"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    
                    if (Male.Checked)
                        gen = "Male";
                    if (Female.Checked)
                        gen = "Female";


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "UPDATE");
                    cmd.Parameters.AddWithValue("@email", txtemail.Text.ToString());
                    cmd.Parameters.AddWithValue("@gender", gen.ToString());
                    cmd.Parameters.AddWithValue("@address",txtadd.Text.ToString());
                     cmd.Parameters.AddWithValue("@state",txtstate.Text.ToString());
                     cmd.Parameters.AddWithValue("@city",txtcity.Text.ToString());
                     cmd.Parameters.AddWithValue("@pin_no",txtpin.Text.ToString());
                     cmd.Parameters.AddWithValue("@mobile_no", txtmobile.Text.ToString());
                    
                    cmd.Connection = con;
                    con.Open();

                    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    if (userId == 0)
                    {

                        Response.Redirect("http://localhost:16100/jobsearch.rjsjob.com/profile_js.aspx?v=Education Record successfully updated!");
                    }
                }
            }

        }
    }
    

    
}