using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelLog
{
    public partial class LoginMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public TextBox TxtUsername
        {
            get => txtUsername;
            set => txtUsername = value;
        }

        public TextBox TxtPassword
        {
            get => txtPassword;
            set => txtPassword = value;
        }

        public RequiredFieldValidator RfvUsername
        {
            get => rfvUsername;
            set => rfvUsername = value;
        }

        public RequiredFieldValidator RfvPassword
        {
            get => rfvPassword;
            set => rfvPassword= value;
        }
    }
}