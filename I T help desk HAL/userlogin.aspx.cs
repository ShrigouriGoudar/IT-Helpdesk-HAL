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
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string userID = TextBox1.Text;
            string password = TextBox2.Text;

            // Validate the user credentials and perform the login
            if (ValidateUser(userID, password))
            {
                // Set the session variable "UserID" after successful login
                Session["UserID"] = userID;
               

                // Redirect to the userhome.aspx page after successful login
                Response.Redirect("userhome.aspx");
            }
            else
            {
                // Show an error message if login fails (e.g., invalid credentials)
                // You can display an error message here, or use other methods like showing a label with an error message, etc.
                // For simplicity, I'm using a JavaScript alert here.
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Invalid UserID or Password. Please try again.');", true);
            }
        }

        private bool ValidateUser(string userID, string password)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query to check if the user exists with the provided credentials
            string query = "SELECT COUNT(*) FROM Users_table WHERE UserID = @UserID AND Password = @Password";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@UserID", userID);
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            // Redirect to the signup page (user signup page)
            Response.Redirect("usersighnup.aspx");
        }
    }
}