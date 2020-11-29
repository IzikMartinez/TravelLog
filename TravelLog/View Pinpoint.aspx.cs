using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelLog
{
    public partial class View_Pinpoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblLocation.Text = Session["location"].ToString();
            lblDate.Text = Session["date"].ToString();
            lblDescription.Text = Session["description"].ToString();
            //img.ImageUrl = Session["image"];
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Main Page.aspx");
        }
    }
}