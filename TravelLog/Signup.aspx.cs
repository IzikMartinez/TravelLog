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
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirm_password = txtConfirmPassword.Text;

            SqlConnection db1 = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT User_Username, User_Email FROM [User]";
            cmd.Connection = db1;

            db1.Open();

            bool validUsernameAndEmail = true;
            Label1.Text = "";

            // Validate username/email not already in-use
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    IDataRecord record = (IDataRecord)reader;
                    if ((string)record[0] == username)
                    {
                        Label1.Text += "Error: Username " + username + " already exists in the database.\n";
                        Label1.Visible = true;
                        validUsernameAndEmail = false;
                    }
                    if ((string)record[1] == email)
                    {
                        Label1.Text += "Error: Email " + email + " already exists in the database.\n";
                        Label1.Visible = true;
                        validUsernameAndEmail = false;
                    }
                }

                reader.Close();
            }
            catch
            {
                Label1.Text += "Error: Failed to access database.\n";
                Label1.Visible = true;
                validUsernameAndEmail = false;
            }
            finally
            {
                db1.Close();
            }

            // Validate password
            if (password == confirm_password && validUsernameAndEmail)
            {
                SqlConnection db2 = new SqlConnection(SqlDataSource1.ConnectionString);
                cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                // 
                cmd.CommandText = "INSERT INTO [User] (User_Username, User_Password, User_Email) VALUES ('" + username + "','" + password + "','" + email + "')";
                cmd.Connection = db2;

                db2.Open();

                bool success = false;

                try
                {
                    cmd.ExecuteNonQuery(); // for insert statements
                    success = true;
                }
                catch (Exception ex)
                {
                    success = false;
                    Label1.Text += ex.Message;
                }
                finally
                {
                    db2.Close(); // avoid memory leakage
                }

                if (success)
                {
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Label1.Visible = true;
                }
            }

        }
    }
}