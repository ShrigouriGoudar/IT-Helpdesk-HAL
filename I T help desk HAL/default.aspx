<%@ Page Title="" Language="C#" MasterPageFile="~/masterhal.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="I_T_help_desk_HAL.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="datatables/css/fonts.css" rel="stylesheet" />
    <link href="css/home2.css" rel="stylesheet" />
</asp:Content >
   
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div id="body" class="body" >
          <div class="hero">
         <div >
            <nav id="nav" class="navbar navbar-expand-lg navbar-light" >
                <a class="navbar-brand" href="#">
                    <img src="images/logo%20nav.png"  style="height:43px; width:123px" />
                 
                </a>

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                 <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto" style="color:white">
                        <li class="nav-item active">
                            <a class="nav-link" href="default.aspx">Home</a>
                        </li>
                      
                    </ul>
                     
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0" >
                        
                        <li class="nav-item active" style="color:white">
                            <asp:LinkButton class="nav-link"  ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">User Login</asp:LinkButton>
                        </li>
                        <li class="nav-item active">
                            <asp:LinkButton class="nav-link" ID="LinkButton2" runat="server" Height="24px" OnClick="LinkButton2_Click">Admin Login</asp:LinkButton>
                        </li>
                          <li class="nav-item active">
                            <asp:LinkButton class="nav-link" ID="LinkButton3" runat="server" Height="32px" OnClick="LinkButton3_Click">Technician Login</asp:LinkButton>
                        </li>
                    </ul>
                </div>
            </nav>
       </div>

         
            <h1 class="title">The force behind the forces.</h1>
        </div>
 </div>
    
        
</asp:Content>
