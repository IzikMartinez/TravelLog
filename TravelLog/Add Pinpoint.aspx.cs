using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TravelLog
{
    public partial class Add_Pinpoint : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }

        protected void btnFinish_Click(object sender, System.EventArgs e)
        {
            string username = Session["username"].ToString();
            int xcoord = (int)Session["xcoord"];
            int ycoord = (int)Session["ycoord"];
            string location = txtLocation.Text;
            string date = txtDate.Text;
            string description = txtDescription.Text;

            // Validate password
            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            //SqlCommand cmd = new SqlCommand();
            //cmd.CommandType = System.Data.CommandType.Text;
            //cmd = new SqlCommand();

            var cmd = new SqlCommand("INSERT INTO [Pinpoint] (User_Username, Pinpoint_X, Pinpoint_Y, Pinpoint_Location, Pinpoint_Date, Pinpoint_Description) VALUES (@username, @xcoord, @ycoord, @location, @date, @description)");
            
            // Must use paramaterized queries to avoid sql injection when user inputs single quotes
            SqlParameter parameter1 = new SqlParameter();
            parameter1.ParameterName = "@username";
            parameter1.Value = username;
            cmd.Parameters.Add(parameter1);

            SqlParameter parameter2 = new SqlParameter();
            parameter2.ParameterName = "@xcoord";
            parameter2.Value = xcoord;
            cmd.Parameters.Add(parameter2);

            SqlParameter parameter3 = new SqlParameter();
            parameter3.ParameterName = "@ycoord";
            parameter3.Value = ycoord;
            cmd.Parameters.Add(parameter3);

            SqlParameter parameter4 = new SqlParameter();
            parameter4.ParameterName = "@location";
            parameter4.Value = location;
            cmd.Parameters.Add(parameter4);

            SqlParameter parameter5 = new SqlParameter();
            parameter5.ParameterName = "@date";
            parameter5.Value = date;
            cmd.Parameters.Add(parameter5);

            SqlParameter parameter6 = new SqlParameter();
            parameter6.ParameterName = "@description";
            parameter6.Value = description;
            cmd.Parameters.Add(parameter6);

            cmd.Connection = db;

            db.Open();

            bool success = false;

            try
            {
                cmd.ExecuteNonQuery(); // for insert statements
                success = true;
            }
            catch (Exception ex)
            {
                success = false;
                Label5.Text += ex.Message;
            }
            finally
            {
                db.Close(); // avoid memory leakage
            }

            if (success)
            {
                Response.Redirect("Main Page.aspx");
            }
            else
            {
                Label5.Visible = true;
            }
            
        }
    }
}