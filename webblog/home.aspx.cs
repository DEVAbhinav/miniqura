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


public partial class home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
      
        if ((Session["Email"]) == (null))
        { Response.Redirect("login.aspx"); }
        sessionval.Text = Session["Email"].ToString();

        DataSet ds = GetData ();
        Repeater1.DataSource = ds;
        Repeater1.DataBind();

       

    }

    private DataSet GetData()
        {
 	using(SqlConnection CN = new SqlConnection(ConfigurationManager.ConnectionStrings["conblog"].ConnectionString))
            {


                    SqlDataAdapter DA;
                    DataSet DS= new DataSet();
                    
                  //  if (!IsPostBack)
                         
                             CN.Open();
                             DA = new SqlDataAdapter("select * from Questions ", CN);
                             DA.Fill(DS);
                             return DS;
                          
             }
         }
   // protected void question_list_OnItemCommand(object source, RepeaterCommandEventArgs e)
    


        //Label lblresume;
        //lblresume = (Label)e.Item.FindControl("lblresume");

        //if (e.CommandName == "download")
        //{
        //    Response.Redirect(lblresume.Text);


        //}
        //else if (e.CommandName == "ViewDetails")
        //{


        //}}
    }
        
        
       
