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

public partial class Default5 : System.Web.UI.Page
{     int id;
    protected void Page_Load(object sender, EventArgs e)
{
    if (Session["Email"] == null)
        Response.Redirect("Default.aspx");
    Label1.Text = Session["Email"].ToString();
        if (!IsPostBack)
        {


            
            //database q = new database();
            //DataTable t,d;
            //t = q.select("select max(ID) from ques");

            //if (t.Rows.Count > 0)
            //{
            //    id = Convert.ToInt32(t.Rows[0][0].ToString()) + 1;

            //}
        }
    }
    protected void btn_post(object sender, EventArgs e)
    {

        string conblog = ConfigurationManager.ConnectionStrings["conblog"].ConnectionString;
        int userId = 0;

        using (SqlConnection con = new SqlConnection(conblog))
        {

            using (SqlCommand cmd = new SqlCommand("proc_questions"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT".ToString());
                    //cmd.Parameters.AddWithValue("@QuestionID", 1);
                    cmd.Parameters.AddWithValue("@email", Session["Email"].ToString());
                    cmd.Parameters.AddWithValue("@Text", TextBox.Text.Trim());
                    cmd.Parameters.AddWithValue("@hits", 0);

                    SqlParameter outputparameter = new SqlParameter();
                    outputparameter.ParameterName = "@QuestionID";
                    outputparameter.SqlDbType = System.Data.SqlDbType.Int;
                    outputparameter.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(outputparameter);

                    cmd.Connection = con;

                    con.Open();
                    cmd.ExecuteNonQuery();
                    String QuesID = outputparameter.Value.ToString();
                    label23.Text = "Ques ID = " + QuesID;
                   //    userId = Convert.ToInt32(cmd.ExecuteScalar());
                    con.Close();
                    Response.Redirect("home.aspx");
                    
                }
            }
        }
    }
}