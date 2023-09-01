using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace I_T_help_desk_HAL
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            // Retrieve the entered admin ID and password
            string technicianID = TextBox1.Text.Trim();
            string password = TextBox2.Text.Trim();

            // Check if the admin ID and password are correct (You may use a database query for this)
            if (technicianID == "technician" && password == "technician!@#")
            {
                // Redirect to adminSignup.aspx
                Response.Redirect("technicianSignup.aspx");
            }
            else if (ValidateUser(technicianID, password))
            {
                // Set the session variable "UserID" after successful login
                Session["TechnicianID"] = technicianID;


                // Redirect to the userhome.aspx page after successful login
                Response.Redirect("technicianhome.aspx");
            }
            else
            {
                // Show an error message for invalid credentials
                // For simplicity, you can use a label to display the error message
                // Add a label control to your aspx file: <asp:Label ID="lblError" runat="server" ForeColor="Red" />
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid TechnicianID or Password. Please try again.');", true);
            }
        }
        private bool ValidateUser(string technicianID, string password)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query to check if the user exists with the provided credentials
            string query = "SELECT COUNT(*) FROM Technicians_table WHERE TechnicianID = @TechnicianID AND Password = @Password";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@TechnicianID", technicianID);
                    command.Parameters.AddWithValue("@Password", password);

                    // Open the connection and execute the query
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    // Return true if the user exists with the provided credentials, otherwise false
                    return count > 0;
                }
            }
        }
    }
}