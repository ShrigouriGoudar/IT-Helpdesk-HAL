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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                // Retrieve the entered details from the form
                string fullName = TextBox1.Text.Trim();
                string dateOfBirth = TextBox2.Text.Trim();
                string contact = TextBox3.Text.Trim();
                string emailID = TextBox4.Text.Trim();
                string department = DropDownList1.SelectedValue;
                string departmentNo = TextBox6.Text.Trim();
                string designation = TextBox7.Text.Trim();
                string employeeID = TextBox5.Text.Trim();
                string adminID = TextBox8.Text; // Set this to the desired username (e.g., emailID)
                string password = TextBox9.Text; // Set this to the desired password

                // Generate an Admin ID and Password
                // You need to implement this method to generate a strong password

                // Insert the admin details into the Admins_table (You need to use a database connection for this)
                InsertAdminData(adminID, fullName, dateOfBirth, contact, emailID, department, departmentNo, designation, employeeID, password);

              
                // Redirect to the login page after successful signup
                Response.Redirect("adminlogin.aspx");
            }
        }

        // Method to insert admin details into the database (You need to implement this method using SQL)
        private void InsertAdminData(string adminID, string fullName, string dateOfBirth, string contact, string emailID, string department, string departmentNo, string designation, string employeeID, string password)
        {
            // Implement the database connection and SQL query here to insert data into the Admins_table
            // Example code:
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

            string query = @"INSERT INTO Admins_table (AdminID, FullName, DateOfBirth, Contact, EmailID, Department, DepartmentNo, Designation, EmployeeID, PasswordID) 
                               VALUES (@AdminID, @FullName, @DateOfBirth, @Contact, @EmailID, @Department, @DepartmentNo, @Designation, @EmployeeID, @PasswordID)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@AdminID", adminID);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@EmailID", emailID);
                    cmd.Parameters.AddWithValue("@Department", department);
                    cmd.Parameters.AddWithValue("@DepartmentNo", departmentNo);
                    cmd.Parameters.AddWithValue("@Designation", designation);
                    cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                    cmd.Parameters.AddWithValue("@PasswordID", password);
                    
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            
        }

    }
}