<%@ Page Title="" Language="C#" MasterPageFile="~/masterhal.Master" AutoEventWireup="true" CodeBehind="technicianlogin.aspx.cs" Inherits="I_T_help_desk_HAL.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userlogin.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="background2" >
      <br />
     <div class="container ">
      <div class="row " >
         <div class="login-box col-md-4 mx-auto mt-3  mb-3" >
            <div class="  " >
               <div class="">
                  <div class="row">
                     <div class="col">
                        <center>
                                                          <img  src="images/techani.gif" style="border-radius: 50%; 
  width: 150px; 
  height: 150px; 
  object-fit: cover;" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3 style="color:white">Technician Login</h3>
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <label  style="color:white">Technician ID</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Technician ID"></asp:TextBox>
                        </div>
                         <br />

                        <label  style="color:white" >Password</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                         <br />
                         
                        <div class="form-group d-grid gap-2 ">
                           <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                        </div>
                       
                     </div>
                  </div>
               </div>
            </div>
            <a href="default.aspx" style="color:white" ><< Back to Home</a><br><br>
         </div>
      </div>
         <br />
   </div>
        </div>
</asp:Content>
