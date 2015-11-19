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
using System.Net.Mail;
public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btn_reg(object sender, EventArgs e)
    {
        string conblog = ConfigurationManager.ConnectionStrings["conblog"].ConnectionString;
        int userId = 0;
        string body;

        // js login reg
        using (SqlConnection con = new SqlConnection(conblog))
        {

            using (SqlCommand cmd = new SqlCommand("Proc_reg_login"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter())
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "INSERT".ToString());
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", TextBox2.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", TextBox3.Text.Trim());
                    cmd.Connection = con;
                    con.Open();
                   // try
                    {
                        userId = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                    //catch
                    //{
                    //    Response.Write ( "User allready registered");
                      //Response.Redirect("regn.aspx");

//                    }
                    //finally { 
                    
                    //}

                    con.Close();
                    Session["Email"] = TextBox2.Text.Trim();
                    Response.Redirect("home.aspx");
                    //if (userId == -1)
                    //{
                    //    Response.Redirect("http://localhost:13753/details.aspx?msg=User exist! Please Login.");

                    //}

                }
            }
            //using (SqlConnection con1 = new SqlConnection(conblog))
            //{
            //    using (SqlCommand cmd = new SqlCommand("Proc_detail"))
            //    {
            //        using (SqlDataAdapter sda = new SqlDataAdapter())
            //        {
            //            //cmd.CommandType = CommandType.StoredProcedure;
            //            //cmd.Parameters.AddWithValue("@Action", "INSERT".ToString());

            //            //cmd.Parameters.AddWithValue("@email", TextBox2.Text.Trim());
            //            //cmd.Parameters.AddWithValue("@gender", "NA");
            //            //cmd.Parameters.AddWithValue("@address", "NA");
            //            //cmd.Parameters.AddWithValue("@state", "NA");
            //            //cmd.Parameters.AddWithValue("@city", "NA");
            //            //cmd.Parameters.AddWithValue("@pincode", "NA");
            //            //cmd.Parameters.AddWithValue("@mobile_no", "NA");
            //            //cmd.Connection = con1;
            //            //con1.Open();

            //            //userId = Convert.ToInt32(cmd.ExecuteScalar());
            //            //con1.Close();

            //         //   if (userId == 1)
            //            {
            //                
                       
            //            }
                   
         body ="hey "+TextBox1.Text+ "! you just have registerd with GuruJi";
        }
        SendEmail(body);
        Response.Redirect("home.aspx");


                }
    protected void SendEmail(String emailbody)
    {
        MailMessage mailMessage = new MailMessage("abhinavpandey.1996@gamil.com", TextBox2.Text.ToString());
        mailMessage.Subject = "Registration Email";
        mailMessage.Body = emailbody;
        
        
        SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
        smtpClient.Credentials = new System.Net.NetworkCredential()
        { 
            UserName = "abhinavpandey.1996@gmail.com" ,
            Password = "9336867472"
        };
        smtpClient.EnableSsl=true;
        smtpClient.Send(mailMessage);

    }

  
}
        

    