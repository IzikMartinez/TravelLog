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
            if (Master.TxtUsername.Text != "Admin")
                Master.RfvUsername.ErrorMessage = "Invalid Admin name";
            else if (Master.TxtPassword.Text != "Password")
                Master.RfvPassword.ErrorMessage = "Invalid Password";
            else
            {
                Response.Redirect("AdminConsole.aspx");
            }
        }
    }
}