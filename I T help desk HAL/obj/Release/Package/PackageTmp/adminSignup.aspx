<%@ Page Title="" Language="C#" MasterPageFile="~/masterhal.Master" AutoEventWireup="true" CodeBehind="adminSignup.aspx.cs" Inherits="I_T_help_desk_HAL.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/usersignup1.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="background3"  >
    <div class="container">
       
      <div class="row">
      <div class="container-box col-md-5 mx-auto mt-3  mb-3"  style=" max-height: 80vh;
    overflow-y: auto;" >
            <div class="">
               <div class="">
                  <div class="row">
                     <div class="col">
                        <center>
                                                                               <img  src="images/adminani.gif" style="border-radius: 50%; 
  width: 150px; 
  height: 150px; 
  object-fit: cover;" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Admin Signup</h3>        
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Full Name</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Date of Birth</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Date"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Contact No</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Contact No" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Email ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-6">
                        <label>Depatrment</label>
                        <div class="form-group">
                            <asp:DropDownList class="form-control" ID="DropDownList1" runat="server">
                              <asp:ListItem Text="Select" Value="select" />
                              <asp:ListItem Text="1320-Export Machine Shop" Value="1320-Export Machine Shop" />
                              <asp:ListItem Text="1321-Hawk Machine Shop" Value="1321-Hawk Machine Shop" />
                              <asp:ListItem Text="1322-Sheet Metal Shop" Value="1322-Sheet Metal Shop" />
                              <asp:ListItem Text="1323-Welding Shop" Value="1323-Welding Shop" />
                              <asp:ListItem Text="1325-Plastics Shop" Value="1325-Plastics Shop" />
                              <asp:ListItem Text="1326-Process Shop" Value="1326-Process Shop" />
                              <asp:ListItem Text="1327-Heat Treat Shop" Value="1327-Heat Treat Shop" />
                              <asp:ListItem Text="1328-Soft Tooling" Value="1328-Soft Tooling" />
                              <asp:ListItem Text="1329-Drop Tank" Value="1329-Drop Tank" />
                              <asp:ListItem Text="1330-Comb Drop Tank" Value="1330-Comb Drop Tank" />
                              <asp:ListItem Text="1335-Export Assembly" Value="1335-Export Assembly" />
                              <asp:ListItem Text="1361-Tool Room" Value="1361-Tool Room" />
                              <asp:ListItem Text="1371-N.C. Shop" Value="1371-N.C. Shop" />
                              <asp:ListItem Text="1372-Pipe Bending Shop" Value="1372-Pipe Bending Shop" />
                              <asp:ListItem Text="1376-Honey Comb" Value="1376-Honey Comb" />
                              <asp:ListItem Text="1381-Hawk Strl. Assy." Value="1381-Hawk Strl. Assy." />
                              <asp:ListItem Text="1382-Wing Assy" Value="1382-Wing Assy" />
                              <asp:ListItem Text="1383-Hawk Equipping" Value="1383-Hawk Equipping" />
                              <asp:ListItem Text="1384-Hawk Equipping" Value="1384-Hawk Equipping" />
                              <asp:ListItem Text="1391-Customer Services" Value="1391-Customer Services" />
                              <asp:ListItem Text="1412-N.C. Prog" Value="1412-N.C. Prog" />
                              <asp:ListItem Text="1416-Plant Maintenance" Value="1416-Plant Maintenance" />
                              <asp:ListItem Text="1417-Civil Maintenance" Value="1417-Civil Maintenance" />
                              <asp:ListItem Text="1418-Electrical Mantenance" Value="1418-Electrical Mantenance" />
                              <asp:ListItem Text="1419-Mechanical Maint" Value="1419-Mechanical Maint" />
                              <asp:ListItem Text="1421-Methods Engneering" Value="1421-Methods Engneering" />
                              <asp:ListItem Text="1422-Programming Engg" Value="1422-Programming Engg" />
                              <asp:ListItem Text="1423-Tool Engg" Value="1423-Tool Engg." />
                              <asp:ListItem Text="1432-Quality Control" Value="1432-Quality Control" />
                              <asp:ListItem Text="1433-Quality Mgf Inspection" Value="1433-Quality Mgf Inspection" />
                               <asp:ListItem Text="1434-Quality" Value="1434-Quality" />
                               <asp:ListItem Text="1435-Quality" Value="1435-Quality" />
                               <asp:ListItem Text="1441-Design Liasion Engg" Value="1441-Design Liasion Engg" />
                               <asp:ListItem Text="1442-Indigenisation Cell" Value="1442-Indigenisation Cell" />
                               <asp:ListItem Text="1451-MSD" Value="1451-MSD" />
                               <asp:ListItem Text="1454-External Sourcing" Value="1454-External Sourcing" />
                               <asp:ListItem Text="1460-Matl. Plg Contrl" Value="1460-Matl. Plg Contrl" />
                               <asp:ListItem Text="1461-Purchase" Value="1461-Purchase" />
                               <asp:ListItem Text="1462-Stores" Value="1462-Stores" />
                               <asp:ListItem Text="1463-Tool Crib" Value="1463-Tool Crib" />
                               <asp:ListItem Text="1482-CTP Office" Value="1482-CTP Office" />
                               <asp:ListItem Text="1502-Project Management" Value="1502-Project Management" />
                               <asp:ListItem Text="1514-Fire Brigade" Value="1514-Fire Brigade" />
                               <asp:ListItem Text="1560-Accounts" Value="1560-Accounts" />
                               <asp:ListItem Text="1610-Executive Canteen" Value="1610-Executive Canteen" />
                               <asp:ListItem Text="1611-Central Sector Canteen" Value="1611-Central Sector Canteen" />
                               <asp:ListItem Text="1575-Information Technology" Value="Information Technology" />
                               <asp:ListItem Text="P500-Airport Services Center" Value="P500-Airport Services Center" />
                               <asp:ListItem Text="1511-Security & Vigilance" Value="1511-Security & Vigilance" />
                               <asp:ListItem Text="5345-Design" Value="5345-Design" />
                               <asp:ListItem Text="1510-HR Department" Value="1510-HR Department" />
                               <asp:ListItem Text="1523-LCA-LSP" Value="1523-LCA-LSP" />
                               <asp:ListItem Text="1524-Tank Assy" Value="1524-Tank Assy"/>
                              
                           </asp:DropDownList>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Dept/P.B.No</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox6" runat="server" placeholder="ID"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                      <div class="col-md-6">
                        <label>Designation</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox7" runat="server" placeholder="Enter"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Employee ID</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox5" runat="server" placeholder="ID"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <hr />
                  <div class="row">
                     <div class="col">
                        <center>
                           <span class="badge badge-pill badge-info" style="color:black"> <h5>Login Credentials</h5></span>
                        </center>
                     </div>
                  </div>
                   <hr />
                  <div class="row">
                     <div class="col-md-6">
                        <label>Admin ID</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox8" runat="server" placeholder="Admin ID" ></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>Password</label>
                        <div class="form-group">
                           <asp:TextBox class="form-control" ID="TextBox9" runat="server" placeholder="Password" TextMode="Password" ></asp:TextBox>
                        </div>
                     </div>
                    
                     </div>
                  </div>
                <br />
                  <div class="row">
                     <div class="col-8 mx-auto">
                        <center>
                           <div class="form-group  d-grid gap-2">
                              <asp:Button class="btn btn-primary btn-block btn-lg" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
                           </div>
                        </center>
                         <br />
                     </div>
                  </div>
               
            </div>
               <a class="back-link" href="default.aspx" ><< Back to Home</a><br><br>
         </div>
         </div>
      </div>
   </div>
</asp:Content>
