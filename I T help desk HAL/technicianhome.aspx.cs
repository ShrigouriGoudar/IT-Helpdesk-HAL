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
    public partial class WebForm19 : System.Web.UI.Page
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
                string technicianID = Session["TechnicianID"] as string;

                if (technicianID != null)
                {
                    // Fetch the admin details from the Admins_table based on the AdminID
                    DataTable dtAdminDetails = GetAdminDetailsFromDatabase(technicianID);

                    if (dtAdminDetails != null && dtAdminDetails.Rows.Count > 0)
                    {
                        // Populate the admin details in the corresponding labels on the page
                        Label1.Text = dtAdminDetails.Rows[0]["TechnicianID"].ToString();
                        Label2.Text = dtAdminDetails.Rows[0]["FullName"].ToString();
                        Label3.Text = dtAdminDetails.Rows[0]["TechnicianID"].ToString();
                        Label4.Text = dtAdminDetails.Rows[0]["Contact"].ToString();
                        Label5.Text = dtAdminDetails.Rows[0]["Department"].ToString();
                    }
                }
                else
                {
                    // If the AdminID is null or admin is not logged in, redirect to the login page
                    Response.Redirect("technicianlogin.aspx");
                }
            }

            // Bind the GridView during the Page_Init event
            BindGridView();
        }
        protected void BindGridView()
        {
            // Check if the admin is logged in (check session or authentication status)
            // Assuming you have stored the AdminID in a session variable named "AdminID"
            // You can replace "Session["AdminID"]" with the actual variable storing the AdminID.
            string technicianID = Session["TechnicianID"] as string;

            if (string.IsNullOrEmpty(technicianID))
            {
                // If the AdminID is null or admin is not logged in, redirect to the login page
                Response.Redirect("technicianlogin.aspx");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = @"SELECT [LogID], [FullName] AS [User], [Contact] AS [Contact], [Department], 
                                    [Location], [Equipment], [Problem], [TechnicianName] AS [Technician],
                                    [CreatedDate], [LastDate], [TakenDate], [SolvedDate], [CaseStatus]
                                    FROM [Logs_table]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
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
        private DataTable GetAdminDetailsFromDatabase(string technicianID)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query to fetch admin details from the Admins_table based on AdminID
            string query = "SELECT FullName, TechnicianID, Contact, Department FROM Technicians_table WHERE TechnicianID = @TechnicianID";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add the AdminID parameter to the command
                    command.Parameters.AddWithValue("@TechnicianID", technicianID);

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
        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("techniciantakenlogs.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            // Logout and redirect to homepage.aspx
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Response.Redirect("default.aspx");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "TakeLog")
            {
                int logID = Convert.ToInt32(e.CommandArgument);
                TakeLog(logID);
                BindGridView();
            }
            else if (e.CommandName == "ViewLogDetails")
            {
                // Handle the click on the "LogID" hyperlink
                // Get the LogID from the CommandArgument
                if (e.CommandArgument != null)
                {
                    string logID = e.CommandArgument.ToString();
                    Response.Redirect("technicianlogdetails.aspx?LogID=" + logID);
                }
            }
        }
        protected void TakeLog(int logID)
        {
            // Assuming you have a method to get the currently logged-in admin's full name.
            string technicianName = GetLoggedInAdminFullName();
            string technicianID = Session["TechnicianID"] as string; // Assuming TechnicianID is stored in a session variable.

            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT CaseStatus FROM Logs_table WHERE LogID = @LogID", connection);
                command.Parameters.AddWithValue("@LogID", logID);
                connection.Open();
                string caseStatus = (string)command.ExecuteScalar();

                if (caseStatus == "Pending")
                {
                    SqlCommand updateCommand = new SqlCommand("UPDATE Logs_table SET CaseStatus = @CaseStatus, TakenDate = @TakenDate, TechnicianName = @TechnicianName, TechnicianID = @TechnicianID WHERE LogID = @LogID", connection);
                    updateCommand.Parameters.AddWithValue("@CaseStatus", "Taken");
                    updateCommand.Parameters.AddWithValue("@TakenDate", DateTime.Now);
                    updateCommand.Parameters.AddWithValue("@TechnicianName", technicianName);
                    updateCommand.Parameters.AddWithValue("@TechnicianID", technicianID);
                    updateCommand.Parameters.AddWithValue("@LogID", logID);
                    updateCommand.ExecuteNonQuery();
                }
                else
                {
                    // Show an error message indicating that the log is already taken or solved.
                    // You can use ASP.NET's Alert or Label controls to display the message.
                    // For example:
                    // ErrorMessageLabel.Text = "The log is already taken or solved.";
                    ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('The case is already taken or solved.');", true);
                }
            }
        }



        protected string GetLoggedInAdminFullName()
        {
            if (HttpContext.Current.Session["TechnicianID"] != null)
            {
                int technicianID = Convert.ToInt32(HttpContext.Current.Session["TechnicianID"]);
                string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT FullName FROM Technicians_table WHERE TechnicianID = @TechnicianID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TechnicianID", technicianID);

                    connection.Open();
                    var fullName = command.ExecuteScalar();
                    if (fullName != null)
                    {
                        return fullName.ToString();
                    }
                }
            }

            return "Unknown"; // Return a default value if the admin's full name cannot be retrieved.
        }
    }

}