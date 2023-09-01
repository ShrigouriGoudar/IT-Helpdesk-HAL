using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Security;
using System.Diagnostics;
using System.Security.Policy;
using System.Web.Services.Description;

namespace I_T_help_desk_HAL
{
    public partial class WebForm5 : System.Web.UI.Page

    {
        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {


            string selectedequipmentValue = DropDownList2.SelectedValue;
            // Here, you can fetch the cities for the selected country from a data source (database, API, etc.)

            // For demonstration purposes, let's assume a simple example:
            if (selectedequipmentValue == "PC") // Country 1
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("PC NOT SWITCHING ON", "PC NOT SWITCHING ON"));
                DropDownList3.Items.Add(new ListItem("PC SLOW", "PC SLOW"));
                DropDownList3.Items.Add(new ListItem("MONITER DISPLAY ISSUE", "MONITER DISPLAY ISSUE"));
                DropDownList3.Items.Add(new ListItem("KEYBOARD ISSUE", "KEYBOARD ISSUE"));
                DropDownList3.Items.Add(new ListItem("MOUSE ISSUE", "MOUSE ISSUE"));
                DropDownList3.Items.Add(new ListItem("POWER ISSUE", "POWER ISSUE"));
                DropDownList3.Items.Add(new ListItem("MS OFFICE ISSUE", "MS OFFICE ISSUE"));
                DropDownList3.Items.Add(new ListItem("SOFTWARE INSTALLATION", "SOFTWARE INSTALATION"));
                DropDownList3.Items.Add(new ListItem("GROUP WISE ISSUE", "GROUP WISE ISSUE"));
                DropDownList3.Items.Add(new ListItem("ANTIVIRUS ISSUE", "ANTIVIRUS ISSUE"));
                DropDownList3.Items.Add(new ListItem("IFS ISSUE", "IFS ISSUE"));
                DropDownList3.Items.Add(new ListItem("OS INSERT DISK BOOT FAIL", "OS INSERT DISK BOOT FAIL"));
                DropDownList3.Items.Add(new ListItem("BLUE SCREEN ERROR", "BLUE SCREEN ERROR"));
                DropDownList3.Items.Add(new ListItem("OS UPGRADATION", "OS UPGRADATION"));
                DropDownList3.Items.Add(new ListItem("INTENT PC NOT WORKING", "INTENT PC NOT WORKING"));
                DropDownList3.Items.Add(new ListItem("ADA ISSUES", "ADA ISSUES"));
                DropDownList3.Items.Add(new ListItem("OS ACTIVATION", "OS ACTIVATION"));
                DropDownList3.Items.Add(new ListItem("MS OUTLOOK ISSUES", "MS OUTLOOK ISSUES"));
                DropDownList3.Items.Add(new ListItem("PENDRIVE", "PENDRIVE"));
                DropDownList3.Items.Add(new ListItem("CD/DVD -EXTERNAL DRIVERS", "CD/DVD -EXTERNAL DRIVERS"));
                DropDownList3.Items.Add(new ListItem("DATE TIME CMOS BATTERY", "DATE TIME CMOS BATTERY"));
                DropDownList3.Items.Add(new ListItem("SMPS ISSUE", "SMPS ISSUE"));
                DropDownList3.Items.Add(new ListItem("EDSRS ISSUE", "EDSRS ISSUE"));
                DropDownList3.Items.Add(new ListItem("PDF ISSUE", "PDF ISSUE"));
                DropDownList3.Items.Add(new ListItem("DATA TRANSFER", "DATA TRANSFER"));
                DropDownList3.Items.Add(new ListItem("E-PROCURMENT PORTAL", "E-PROCURMENT PORTAL"));
                DropDownList3.Items.Add(new ListItem("PC INSTALLATION", "PC INSTALLATION"));
                DropDownList3.Items.Add(new ListItem("PC SHIFTING", "PC SHIFTING"));
                // Add other cities for Country 1
            }
            else if (selectedequipmentValue == "COMPANY OWNED PRINTER") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("PRINTER DRIVER INSTALLATION", "PRINTER DRIVER INSTALLATION"));
                DropDownList3.Items.Add(new ListItem("PAPER JAM", "PAPER JAM"));
                DropDownList3.Items.Add(new ListItem("PRINTER SHIFTING", "PRINTER SHIFTING"));
                DropDownList3.Items.Add(new ListItem("MAINTAINANCE", "MAINTAINANCE"));
                DropDownList3.Items.Add(new ListItem("CONNECTION ERROR", "CONNECTION ERROR"));
                DropDownList3.Items.Add(new ListItem("REPLACEMENT TONER", "REPLACEMENT TONER"));
                DropDownList3.Items.Add(new ListItem("TONER LOW", "TONER LOW"));
                DropDownList3.Items.Add(new ListItem("DRUM ISSUE", "DRUM ISSUE"));
                DropDownList3.Items.Add(new ListItem("GREEN TAB/ DRUM UNIT", "GREEN TAB/ DRUM UNIT"));
                DropDownList3.Items.Add(new ListItem("ERROR", "ERROR"));
                DropDownList3.Items.Add(new ListItem("PRINTER IP ISSUE", "PRINTER IP ISSUE"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "BROTHER HIRING PRINTER") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER DRIVER INSTALLATION", "HIRING PRINTER DRIVER INSTALLATION"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER PAPER JAM", "HIRING PRINTER PAPER JAM"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER SHIFTING", "HIRING PRINTER SHIFTING"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER MAINTAINANCE", "HIRING PRINTER MAINTAINANCE"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER CONNECTION ERROR", "HIRING PRINTER CONNECTION ERROR"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER REPLACEMENT TONER", "HIRING PRINTER REPLACEMENT TONER"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER TONER LOW", "HIRING PRINTER TONER LOW"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER DRUM ISSUE", "HIRING PRINTER DRUM ISSUE"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER GREEN TAB/ DRUM UNIT", "HIRING PRINTER GREEN TAB/ DRUM UNIT"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER ERROR", "HIRING PRINTER ERROR"));
                DropDownList3.Items.Add(new ListItem("HIRING PRINTER IP ISSUE", "HIRING PRINTER IP ISSUE"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "NETWORK CABLE") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("LAN NOT WORKING", "LAN NOT WORKING"));
                DropDownList3.Items.Add(new ListItem("RED-CROSS SYMBOL", "RED-CROSS SYMBOL"));
                DropDownList3.Items.Add(new ListItem("UNIDENTIFIED NETWORK", "UNIDENTIFIED NETWORK"));
                DropDownList3.Items.Add(new ListItem("CABLE CUT/ DAMAGED", "CABLE CUT/ DAMAGED"));
                DropDownList3.Items.Add(new ListItem("NEW NETWORK CONNECTION", "NEW NETWORK CONNECTION"));
                DropDownList3.Items.Add(new ListItem("NETWORK POINT SHIFTING", "NETWORK POINT SHIFTING"));
                DropDownList3.Items.Add(new ListItem("IP ADDRESS CONFLICT", "IP ADDRESS CONFLICT"));
                DropDownList3.Items.Add(new ListItem("CONNECTION TO FILE SERVER ISSUE", "CONNECTION TO FILE SERVER ISSUE"));
                DropDownList3.Items.Add(new ListItem("INTERNET NOT WORKING", "INTERNET NOT WORKING"));
                DropDownList3.Items.Add(new ListItem("HAL-MAIL NOT WORKING", "HAL-MAIL NOT WORKING"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "NETWORK SWITCH") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("NETWORK SWITCH PORT ISSUE", "NETWORK SWITCH PORT ISSUE"));
                DropDownList3.Items.Add(new ListItem("NETWORK SWITCH ISSUE", "NETWORK SWITCH ISSUE"));
                DropDownList3.Items.Add(new ListItem("NETWORK SWITCH ADAPTER ISSUE", "NETWORK SWITCH ADAPTER ISSUE"));
                DropDownList3.Items.Add(new ListItem("NETWORK SWITCH REQUIREMENT", "NETWORK SWITCH REQUIREMENT"));
                DropDownList3.Items.Add(new ListItem("NETWORK IO BROLEEN", "NETWORK IO BROLEEN"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "NETWORK RACK") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("NETWORK RACK POWER PROBLEM", "NETWORK RACK POWER PROBLEM"));
                DropDownList3.Items.Add(new ListItem("NETOWRK RACK SOUND/FAN ISSUE", "NETOWRK RACK SOUND/FAN ISSUE"));
                DropDownList3.Items.Add(new ListItem("MEDIA CONVERTER ISSUE", "MEDIA CONVERTER ISSUE"));
                DropDownList3.Items.Add(new ListItem("OFC SPLICING ISSUE", "OFC SPLICING ISSUE"));
                DropDownList3.Items.Add(new ListItem("SFP MODULE ISSUE", "SFP MODULE ISSUE"));
                DropDownList3.Items.Add(new ListItem("PATCH CORDS-SC-SC/SC-LC", "PATCH CORDS-SC-SC/SC-LC"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "THINCLIENT") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT NOT SWITCHING ON", "HINCLIENT NOT SWITCHING ON"));
                DropDownList3.Items.Add(new ListItem("POWER ADAPTER ISSUE", "POWER ADAPTER ISSUE"));
                DropDownList3.Items.Add(new ListItem("NOT CONNECTING TO SERVER", "NOT CONNECTING TO SERVER"));
                DropDownList3.Items.Add(new ListItem("REMOTE LICENCE ISSUE", "REMOTE LICENCE ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT MONITER ISSUE", "THINCLIENT MONITER ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT MOUSE ISSUE", "THINCLIENT MOUSE ISSUE"));
                DropDownList3.Items.Add(new ListItem("SERVER USERNAME/ PASSWARD CHANGE", "SERVER USERNAME/ PASSWARD CHANGE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT SOUND ISSUE", "THINCLIENT SOUND ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT OS ISSUE", "HINCLIENT OS ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT MOTHER BOARD ISSUE", "THINCLIENT MOTHER BOARD ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT KEYBOARD ISSUE", "THINCLIENT KEYBOARD ISSUE"));
                DropDownList3.Items.Add(new ListItem("THINCLIENT EDSRS", "THINCLIENT EDSRS"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "LAPTOP") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("LAPTOP NOT SWITCHING ON", "LAPTOP NOT SWITCHING ON"));
                DropDownList3.Items.Add(new ListItem("LAPTOP SLOW", "LAPTOP SLOW"));
                DropDownList3.Items.Add(new ListItem("LAPTOP KEYBOARD ISSUE", "LAPTOP KEYBOARD ISSUE"));
                DropDownList3.Items.Add(new ListItem("LAPTOP OS INSTALLATION", "LAPTOP OS INSTALLATION"));
                DropDownList3.Items.Add(new ListItem("LAPTOP SOFTWARE INSTALLATION", "LAPTOP SOFTWARE INSTALLATION"));
                DropDownList3.Items.Add(new ListItem("LAPTOP ADAPTER ISSUE", "LAPTOP ADAPTER ISSUE"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "SCANNER") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("SCANNER ADAPTER ISSUE", "SCANNER ADAPTER ISSUE"));
                DropDownList3.Items.Add(new ListItem("SCANNER ADAPTER ISSUE", "SCANNER ADAPTER ISSUE"));
                DropDownList3.Items.Add(new ListItem("SCANNER NOT WORKING", "SCANNER NOT WORKING"));
                DropDownList3.Items.Add(new ListItem("SCANNER DRIVER INSTALLATION", "SCANNER DRIVER INSTALLATION"));
                // Add other cities for Country 2
            }
            else if (selectedequipmentValue == "KYOCERA HIRING PRINTER") // Country 2
            {
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
                DropDownList3.Items.Add(new ListItem("PRINTER NOT SWITCHING ON", "PRINTER NOT SWITCHING ON"));
                DropDownList3.Items.Add(new ListItem("PAPER JAM", "PAPER JAM"));
                DropDownList3.Items.Add(new ListItem("CATRIDGE EMPTY", "CATRIDGE EMPTY"));
                DropDownList3.Items.Add(new ListItem("PRINTER NOT WORKING", "PRINTER NOT WORKING"));
                DropDownList3.Items.Add(new ListItem("PRINTER ISSUES", "PRINTER ISSUES"));
                // Add other cities for Country 2
            }
            // Add other conditions for different countries
            else
            {
                // If no country is selected or if there are no cities for the selected country, clear the city dropdown.
                DropDownList3.Items.Clear();
                DropDownList3.Items.Add(new ListItem("Select", "select"));
            }
        }
        protected void Page_Load(object sender, EventArgs e)
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





    



        private string GenerateNextLogID()
        {
            // Fetch the last LogID from the database and increment it
            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT MAX(CAST(LogID AS INT)) FROM Logs_table", connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value && int.TryParse(result.ToString(), out int maxLogId))
                    {
                        return (++maxLogId).ToString("D4");
                    }
                }
            }
            // Return a default value if no LogID is found in the database
            return "0001";
        }

        private int InsertNewLog(string equipment, string equipmentCode, string problem, DateTime createdDate, DateTime lastDate, string department, string location, string message, string userID)
        {
            string logId = GenerateNextLogID();

            string connectionString = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO Logs_table (LogID, Equipment, EquipmentCode, Problem, CreatedDate, LastDate, Department, Location, Message, UserID, FullName, Contact, CaseStatus) " +
                                                "VALUES (@LogID, @Equipment, @EquipmentCode, @Problem, @CreatedDate, @LastDate, @Department, @Location, @Message, @UserID, @FullName, @Contact, @CaseStatus);", connection))
                {
                    command.Parameters.AddWithValue("@LogID", logId);
                    command.Parameters.AddWithValue("@Equipment", equipment);
                    command.Parameters.AddWithValue("@EquipmentCode", equipmentCode);
                    command.Parameters.AddWithValue("@Problem", problem);
                    command.Parameters.AddWithValue("@CreatedDate", createdDate);
                    command.Parameters.AddWithValue("@LastDate", lastDate);
                    command.Parameters.AddWithValue("@Department", department);
                    command.Parameters.AddWithValue("@Location", location);
                    command.Parameters.AddWithValue("@Message", message);
                    command.Parameters.AddWithValue("@UserID", userID);
                    command.Parameters.AddWithValue("@FullName", Label2.Text);
                    command.Parameters.AddWithValue("@Contact", Label4.Text);
                    command.Parameters.AddWithValue("@CaseStatus", "Pending"); // Set CaseStatus to "Pending" for new cases
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        






        protected void LinkButton1_Click1(object sender, EventArgs e)
        {
            // Redirect to the usercreatenewlog.aspx page
            Response.Redirect("usercreatenewlog.aspx");
        }

        protected void LinkButton2_Click1(object sender, EventArgs e)
        {
            // Logout and redirect to homepage.aspx
            FormsAuthentication.SignOut();
            Session.Clear();
            Session.Abandon();
            Response.Redirect("default.aspx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            // Clear the form fields
            DropDownList2.SelectedIndex = 0;
            TextBox4.Text = "";
            DropDownList3.SelectedIndex = 0;
            TextBox2.Text = "";
            TextBox1.Text = "";
            DropDownList1.SelectedIndex = 0;
            TextBox6.Text = "";
            txtParagraph.Text = "";

         
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            // Fetch the input values from the form controls
            string problem = DropDownList2.SelectedValue;
            string equipmentCode = TextBox4.Text;
            string equipment = DropDownList3.SelectedValue;
            DateTime createdDate = DateTime.Now;
            DateTime lastDate = Convert.ToDateTime(TextBox1.Text);
            string department = DropDownList1.SelectedValue;
            string location = TextBox6.Text;
            string message = txtParagraph.Text;

            string userID = Session["UserID"] as string;


            // Store the new log details in the database
            if (InsertNewLog(problem, equipmentCode, equipment, createdDate, lastDate, department, location, message, userID) > 0)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Log inserted successfully');", true);
                // Log inserted successfully, redirect to userhome.aspx
                Response.Redirect("userhome.aspx");
            }

        }
    }
}
  

          