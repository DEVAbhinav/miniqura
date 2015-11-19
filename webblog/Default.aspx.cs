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

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

      //  if (Session[Email] == null)
       //     Response.Redirect("home.aspx");


        //Session.Abandon();
        //Session.Clear();
        //Session["Email"] = null;
        //HttpContext.Current.Session.Abandon();

    }
    protected void btn_clk(object sender, EventArgs e)
    {
        string password;
        DataTable t;
        database q = new database();
        t = q.select("select *from reg_login where email ='" + txtemail.Text.ToString().Trim() + "'");
      if(t.Rows.Count>0)
      {
          password = t.Rows[0][1].ToString();
        if (password == txtpassword.Text)
        {
            Session["Email"] = txtemail.Text;

            Response.Redirect("home.aspx");
        }
        else
            txtemail.Text = " invalid password";
    }
    else
          txtpassword.Text = "Invalid user name";













       }

    public int Email { get; set; }
}


