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
            if ((Master as LoginMaster).TxtUsername.Text != "Admin")
                (Master as LoginMaster).RfvUsername.ErrorMessage = "Invalid Admin name";
            if ((Master as LoginMaster).TxtPassword.Text != "Password")
                (Master as LoginMaster).RfvPassword.ErrorMessage = "Invalid Password";    
            Response.Redirect("AdminConsole.aspx");
        }
    }
}