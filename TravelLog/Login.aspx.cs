using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace TravelLog
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT User_Username FROM [User] WHERE User_Username = '" + username + "' AND User_Password = '" + password + "'";
            cmd.Connection = db;

            db.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                bool validUsername = false;

                while (reader.Read())
                {
                    IDataRecord record = (IDataRecord)reader;
                    if ((string)record[0] == username)
                    {
                        validUsername = true;
                    }
                }

                if (validUsername)
                {
                    // open new page
                    Session["username"] = username;
                    Response.Redirect("Main Page.aspx");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
                Label1.Visible = true;
            }
            finally
            {
                db.Close();
            }
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("Signup.aspx");
        }
    }
}