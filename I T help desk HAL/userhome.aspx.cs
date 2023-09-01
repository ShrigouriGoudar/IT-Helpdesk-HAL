using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Services.Description;
using System.Collections;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Diagnostics;
using System.EnterpriseServices.CompensatingResourceManager;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Messaging;

namespace I_T_help_desk_HAL
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the user is logged in (check session or authentication status)
                // Assuming you have stored the UserID in a session variable named "UserID"
                // You can replace "Session["UserID"]" with the actual variable storing the UserID.
                string userID = Session["UserID"] as string;

                if (userID != null)
                {
                    // Fetch the user details from the Users_table based on the UserID
                    DataTable dtUserDetails = GetUserDetailsFromDatabase(userID);

                    if (dtUserDetails != null && dtUserDetails.Rows.Count > 0)
                    {
                        // Populate the user details in the corresponding labels on the page
                        Label1.Text = dtUserDetails.Rows[0]["UserID"].ToString();
                        Label2.Text = dtUserDetails.Rows[0]["FullName"].ToString();
                        Label3.Text = dtUserDetails.Rows[0]["UserID"].ToString();
                        Label4.Text = dtUserDetails.Rows[0]["ContactNo"].ToString();
                        Label5.Text = dtUserDetails.Rows[0]["Department"].ToString();
                    }
                }
                else
                {
                    // If the UserID is null or user is not logged in, redirect to the login page
                    Response.Redirect("userlogin.aspx");
                }
            }

            // Bind the GridView during the Page_Init event
            BindGridView();
        }


        protected void BindGridView()
        {
            // Check if the user is logged in (check session or authentication status)
            // Assuming you have stored the UserID in a session variable named "UserID"
            // You can replace "Session["UserID"]" with the actual variable storing the UserID.
            string userID = Session["UserID"] as string;

            if (string.IsNullOrEmpty(userID))
            {
                // If the UserID is null or user is not logged in, redirect to the login page
                Response.Redirect("userlogin.aspx");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT [LogID], [FullName] AS [User], [Contact] AS [Contact], [Department], 
                            [Location], [Equipment], [Problem], [TechnicianName] AS [Technician],
                            [CreatedDate], [LastDate], [TakenDate], [SolvedDate], [CaseStatus]
                            FROM [Logs_table]
                            WHERE [UserID] = @UserID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the UserID parameter to the command
                        command.Parameters.AddWithValue("@UserID", userID);

                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);


                        // Bind the GridView with the updated data table
                        GridView1.DataSource = dt;


                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle and display the exception to identify the issue
                Response.Write($"An error occurred while binding the GridView: {ex.Message}");
            }
        }






        private DataTable GetUserDetailsFromDatabase(string userID)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query to fetch user details from the Users_table based on UserID
            string query = "SELECT FullName, UserID, ContactNo, Department FROM Users_table WHERE UserID = @UserID";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the UserID parameter to the command
                    command.Parameters.AddWithValue("@UserID", userID);

                    // Create a DataTable to store the results
                    DataTable dtUserDetails = new DataTable();

                    // Open the connection, execute the query, and fill the DataTable
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtUserDetails.Load(reader);
                    }
                    connection.Close();

                    return dtUserDetails;
                }
            }
        }




        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            // Redirect to the usercreatenewlog.aspx page
            Response.Redirect("usercreatenewlog.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            // Logout and redirect to homepage.aspx
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Response.Redirect("default.aspx");



        }



        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
if (e.Row.RowType == DataControlRowType.DataRow)
    {
        // Get the CaseStatus and LastDate values from the row
        string caseStatus = DataBinder.Eval(e.Row.DataItem, "CaseStatus").ToString();
        DateTime lastDate = Convert.ToDateTime(DataBinder.Eval(e.Row.DataItem, "LastDate"));

        // Apply the CSS class based on the conditions
        if (caseStatus == "Taken")
        {
            e.Row.CssClass = "blue";
        }
        else if (caseStatus == "Solved")
        {
            e.Row.CssClass = "green";
        }
        else if (lastDate < DateTime.Now.Date)
        {
            e.Row.CssClass = "red";
        }
    }

        }

        protected void GridView1_RowCommand1(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "UpdateLog")
            {
                // Get the LogID from the CommandArgument
                string logID = e.CommandArgument.ToString();

                // Redirect to userlogupdate.aspx and pass the LogID in the query string
                Response.Redirect("userlogupdate.aspx?LogID=" + logID);

            }
            else if (e.CommandName == "ViewLogDetails")
            {
                // Handle the click on the "LogID" hyperlink
                // Get the LogID from the CommandArgument
                if (e.CommandArgument != null)
                {
                    string logID = e.CommandArgument.ToString();
                    Response.Redirect("userlogdetails.aspx?LogID=" + logID);
                }
            }


        }


    }
}