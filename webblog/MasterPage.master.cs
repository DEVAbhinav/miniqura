using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void btn_post(object sender, EventArgs e)
    {
        Response.Redirect("post.aspx");
    }


    protected void SignOut_Click(object sender, EventArgs e)
    {
        Session["Email"] = null;
        Response.Redirect("Default.aspx");
    }
}

