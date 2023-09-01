using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace I_T_help_desk_HAL
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Page_Init(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check if the admin is logged in (check session or authentication status)
                // Assuming you have stored the AdminID in a session variable named "AdminID"
                // You can replace "Session["AdminID"]" with the actual variable storing the AdminID.
                string adminID = Session["AdminID"] as string;

                if (adminID != null)
                {
                    // Fetch the admin details from the Admins_table based on the AdminID
                    DataTable dtAdminDetails = GetAdminDetailsFromDatabase(adminID);

                    if (dtAdminDetails != null && dtAdminDetails.Rows.Count > 0)
                    {
                        // Populate the admin details in the corresponding labels on the page
                        Label1.Text = dtAdminDetails.Rows[0]["AdminID"].ToString();
                        Label2.Text = dtAdminDetails.Rows[0]["FullName"].ToString();
                        Label3.Text = dtAdminDetails.Rows[0]["AdminID"].ToString();
                        Label4.Text = dtAdminDetails.Rows[0]["Contact"].ToString();
                        Label5.Text = dtAdminDetails.Rows[0]["Department"].ToString();
                    }
                }
                else
                {
                    // If the AdminID is null or admin is not logged in, redirect to the login page
                    Response.Redirect("adminlogin.aspx");
                }
            }

            // Bind the GridView during the Page_Init event
            BindGridView();
        }
        private DataTable GetAdminDetailsFromDatabase(string adminID)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query to fetch admin details from the Admins_table based on AdminID
            string query = "SELECT FullName, AdminID, Contact, Department FROM Admins_table WHERE AdminID = @AdminID";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the AdminID parameter to the command
                    command.Parameters.AddWithValue("@AdminID", adminID);

                    // Create a DataTable to store the results
                    DataTable dtAdminDetails = new DataTable();

                    // Open the connection, execute the query, and fill the DataTable
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dtAdminDetails.Load(reader);
                    }
                    connection.Close();

                    return dtAdminDetails;
                }
            }
        }
        protected void BindGridView()
        {
            // Check if the admin is logged in (check session or authentication status)
            // Assuming you have stored the AdminID in a session variable named "AdminID"
            // You can replace "Session["AdminID"]" with the actual variable storing the AdminID.
            string adminID = Session["AdminID"] as string;

            if (string.IsNullOrEmpty(adminID))
            {
                // If the AdminID is null or admin is not logged in, redirect to the login page
                Response.Redirect("adminlogin.aspx");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Update the SQL query to fetch logs for the current admin with CaseStatus "Taken"
                    string query = @"SELECT [LogID], [FullName] AS [User], [Contact] AS [Contact], [Department], 
                [Location], [Equipment], [Problem], [TechnicianName] AS [Technician],
                [CreatedDate], [LastDate], [TakenDate], [SolvedDate], [CaseStatus]
                FROM [Logs_table]
                WHERE [TechnicianName] = (
                    SELECT [FullName] FROM [Admins_table] WHERE [AdminID] = @AdminID
                ) AND [CaseStatus] = 'Taken'";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add the AdminID parameter to the command
                        command.Parameters.AddWithValue("@AdminID", adminID);

                        connection.Open();
                        SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        dataAdapter.Fill(dt);

                        // Bind the GridView with the updated data table and set the DataKeyNames property
                        GridView1.DataKeyNames = new string[] { "LogID" };
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


        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("admincreatelogs.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("admintakelogs.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("admintakenlogs.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("admincloselogs.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        { // Logout and redirect to homepage.aspx
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Response.Redirect("default.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "ViewLogDetails")
            {
                // Handle the click on the "LogID" hyperlink
                // Get the LogID from the CommandArgument
                if (e.CommandArgument != null)
                {
                    string logID = e.CommandArgument.ToString();
                    Response.Redirect("admindetails2.aspx?LogID=" + logID);
                }
            }
        }
    }
}