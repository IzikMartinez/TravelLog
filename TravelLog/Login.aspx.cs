using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelLog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String username = txtUsername.Text;
            String password = txtPassword.Text;

            Boolean valid = validateLogin(username, password);
        }

        protected Boolean validateLogin(String u, String p)
        {
            Boolean valid = false;

            return valid;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}