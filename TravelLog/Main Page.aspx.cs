using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

namespace TravelLog
{
    public partial class Main_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            loadPinpoints(username);
            Label1.Visible = false;
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add Pinpoint")
            {
                btnAdd.Text = "Cancel";
            }
            else
            {
                btnAdd.Text = "Add Pinpoint";
            }
        }

        protected void map_Click(object sender, ImageClickEventArgs e)
        {
            if (btnAdd.Text == "Cancel")
            {
                Session["xcoord"] = e.X;
                Session["ycoord"] = e.Y;
                Response.Redirect("Add Pinpoint.aspx");
            }
        }

        protected void loadPinpoints(string username)
        {
            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT Pinpoint_ID, Pinpoint_X, Pinpoint_Y FROM [Pinpoint] WHERE User_Username = '" + username + "'";
            cmd.Connection = db;

            db.Open();

            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    IDataRecord record = (IDataRecord)reader;
                    string xcoord = ((int)record[1]).ToString();
                    string ycoord = ((int)record[2]).ToString();

                    ImageButton mybutton = new ImageButton();
                    mybutton.Attributes.Add("style", $"left: {xcoord}px; top: {ycoord}px; Z-INDEX: 100; position: absolute;");
                    mybutton.Visible = true;
                    mybutton.Attributes.Add("runat", "server");
                    mybutton.Height = 20;
                    mybutton.Width = 20;
                    mybutton.ImageUrl = "Images/Pinpoint.png";
                    mybutton.Click += new ImageClickEventHandler(viewPinpoint);
                    mybutton.ID = record[0].ToString();
                    form1.Controls.Add(mybutton);
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

        protected void viewPinpoint(object sender, ImageClickEventArgs e)
        {
            SqlConnection db = new SqlConnection(SqlDataSource1.ConnectionString);
            SqlCommand cmd = new SqlCommand();

            ImageButton clickedButton = (ImageButton)sender;

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT Pinpoint_Date, Pinpoint_Location, Pinpoint_Description, Pinpoint_Image FROM [Pinpoint] WHERE Pinpoint_ID = '" + clickedButton.ID + "'";
            cmd.Connection = db;

            Boolean success = false;

            db.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    IDataRecord record = (IDataRecord)reader;
                    Session["date"] = ((string)record[0]);
                    Session["location"] = ((string)record[1]);
                    Session["description"] = ((string)record[2]);
                    success = true;
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
                if (success)
                {
                    Response.Redirect("View Pinpoint.aspx");
                }
            }
        }
    }
}