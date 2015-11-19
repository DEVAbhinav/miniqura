using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
public class database
{
    SqlConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["conblog"].ConnectionString);
   
    DataSet DS;
    string conblog = ConfigurationManager.ConnectionStrings["conblog"].ConnectionString;
    
    public DataTable select(string query)
    {
        using (SqlConnection con = new SqlConnection(conblog))
        {
            using (SqlCommand cmd = new SqlCommand(query,con))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    sda.SelectCommand = cmd;
                    DS = new DataSet();
                    sda.Fill(DS);

                    return DS.Tables[0];


                }
            }
        }
    
    }
    public void update(string query)
    {
        using (SqlConnection con = new SqlConnection(conblog))
        {
            using (SqlCommand cmd = new SqlCommand(query,con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    
    }
}

	
	