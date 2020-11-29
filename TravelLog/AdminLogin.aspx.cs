using System;
using System.Web.UI;

namespace TravelLog
{
    public partial class AdminLogin : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdminLogin_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AdminConsole.aspx");
        }
    }
}