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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Check if the page is a postback (i.e., user clicked the "Sign Up" button)
            if (IsPostBack)
            {
                // Get the form values
                string fullName = TextBox1.Text;
                DateTime dateOfBirth = Convert.ToDateTime(TextBox2.Text);
                string contactNo = TextBox3.Text;
                string emailID = TextBox4.Text;
                string department = DropDownList1.SelectedValue;
                string departmentNo = TextBox6.Text;
                string designation = TextBox7.Text;
                string employeeID = TextBox5.Text;
                string username = TextBox8.Text; // Set this to the desired username (e.g., emailID)
                string password = TextBox9.Text; // Set this to the desired password

                // Insert data into the database
                InsertUserData(fullName, dateOfBirth, contactNo, emailID, department, departmentNo, designation, employeeID, username, password);

                // Redirect to the login page after successful signup
                Response.Redirect("userlogin.aspx");
            }
        }

        private void InsertUserData(string fullName, DateTime dateOfBirth, string contactNo, string emailID, string department, string departmentNo, string designation, string employeeID, string username, string password)
        {
            // Fetch the connection string from the web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            // Create the SQL query
            string query = @"INSERT INTO Users_table (FullName, DateOfBirth, ContactNo, EmailID, Department, DepartmentNo, Designation, EmployeeID, UserID, Password)
                             VALUES (@FullName, @DateOfBirth, @ContactNo, @EmailID, @Department, @DepartmentNo, @Designation, @EmployeeID, @UserID, @Password)";

            // Set up the connection and command
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to the command
                    command.Parameters.AddWithValue("@FullName", fullName);
                    command.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    command.Parameters.AddWithValue("@ContactNo", contactNo);
                    command.Parameters.AddWithValue("@EmailID", emailID);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@DepartmentNo", departmentNo);
                    command.Parameters.AddWithValue("@Designation", designation);
                    command.Parameters.AddWithValue("@EmployeeID", employeeID);
                    command.Parameters.AddWithValue("@UserID", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Open the connection, execute the query, and close the connection
                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}