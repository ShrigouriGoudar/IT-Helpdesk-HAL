<%@ Page Title="" Language="C#" MasterPageFile="~/masterhal.Master" AutoEventWireup="true" CodeBehind="adminhome.aspx.cs" Inherits="I_T_help_desk_HAL.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <script src="jquery/jquery.js"></script>
    <script src="jquery/jquery.min.js"></script>
    <link href="datatables/css/cdn.datatables.net_1.13.5_css_jquery.dataTables.min.css" rel="stylesheet" />
    <script src="datatables/js/cdn.datatables.net_1.13.5_js_jquery.dataTables.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable({
                "searching": true, // Enable searching
                "lengthChange": true, // Hide page size dropdown
                "paging": true, // Hide pagination
                "info": true // Hide table information
            });
        });
    </script>
    <link href="css/adminhome.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="body">
        <div id="background3 " >
     <div>
             <nav class="navbar navbar-expand-lg navbar-light" >
                <a class="navbar-brand" href="#">
                   <img src="images/logo%20nav.png"  style="height:43px; width:123px" />
                </a>

                <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarSupportedContent" aria-controls="navbarSupportedContent" aria-expanded="false" aria-label="Toggle navigation">
                    <span class="navbar-toggler-icon"></span>
                </button>

                 <div class="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul class="navbar-nav mr-auto" style="color:white">
                        <li class="nav-item active">
                            <a class="nav-link" href="adminhome.aspx">Home</a>
                        </li>
                     
                      <li class="nav-item active" style="color:white">
                            <asp:LinkButton class="nav-link"  ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Create New Log</asp:LinkButton>
                        </li>
                           <li class="nav-item active" style="color:white">
                            <asp:LinkButton class="nav-link"  ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Take logs</asp:LinkButton>
                        </li>
                           <li class="nav-item active" style="color:white">
                            <asp:LinkButton class="nav-link"  ID="LinkButton4" runat="server" OnClick="LinkButton4_Click">Taken logs</asp:LinkButton>
                        </li>
                           <li class="nav-item active" style="color:white">
                            <asp:LinkButton class="nav-link"  ID="LinkButton5" runat="server" OnClick="LinkButton5_Click">Close logs</asp:LinkButton>
                        </li>
                    </ul>
                     <span class="welcome1 navbar-nav ms-auto">
                          <centre style="position: relative;    margin-right: 563px;">
                         <span   Style="font-size:20px">Welcome </span>
                         <asp:Label ID="Label1" runat="server"    Style="font-size:20px" Text="Your ID"></asp:Label>
                         </centre>
                             </span>
                    <ul class="navbar-nav ms-auto mb-2 mb-lg-0" >
                    
                      
                        <li class="nav-item active">
                            <asp:LinkButton class="nav-link" ID="LinkButton2" runat="server" OnClick="LinkButton2_Click" >Logout</asp:LinkButton>
                        </li>
                        
                    </ul>
                </div>
            </nav>
        </div>
   
                <div class="container" style="max-width: 100%; padding: 0;">
       
      <div class="row"  style="max-width: 100%; padding: 0;">
         <div class="container-box col-md mx-auto mt-2  mb-2" style=" max-height: 80vh;
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
                           <h3>Admin Logs</h3>        
                        </center>
                     </div>
                  </div>

                    <div class="row">
                     <div class="col-md-6">
                        <label Style="font-size:20px">Name:</label>
                        
                         <span>
  <asp:Label ID="Label2" runat="server"    Style="font-size:20px" Text="Your_Name"></asp:Label>
                         </span>
                        
                     </div>
                     <div class="col-md-6">
                        <label Style="font-size:20px">Admin ID: </label>
                          
                         <span>
  <asp:Label ID="Label3" runat="server"    Style="font-size:20px" Text="Your_ID"></asp:Label>
                         </span>

                     </div>
                  </div>
                   <div class="row">
                     <div class="col-md-6">
                        <label Style="font-size:20px">Contact: </label>
                        
                         <span>
  <asp:Label ID="Label4" runat="server"    Style="font-size:20px" Text="Your_number"></asp:Label>
                         </span>
                        
                     </div>
                     <div class="col-md-6">
                        <label Style="font-size:20px">Department: </label>
                          
                         <span>
  <asp:Label ID="Label5" runat="server"    Style="font-size:20px" Text="Your_depertment"></asp:Label>
                         </span>

                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <hr />
                     </div>
                     </div>
                     <br />
                 <div class="row" style="background-color:white" >
<div class="gridview-container col-12">
    <asp:GridView ID="GridView1" runat="server" Class="table table-striped table-hover table-bordered" OnRowCommand="GridView1_RowCommand1" OnRowDataBound="GridView1_RowDataBound">
 <Columns>
        <asp:TemplateField HeaderText="Case Action">
            <ItemTemplate>
                 <asp:Button ID="btnUpdate" Text="Update" runat="server" CommandName="UpdateLog" CommandArgument='<%# Eval("LogID") %>' />
                <center>
                <asp:HyperLink ID="hlLogID" runat="server" CommandName="ViewLogDetails" Text='<%# Eval("LogID") %>' NavigateUrl='<%# "Admindetails.aspx?LogID=" + Eval("LogID") %>' />
                </center>
            </ItemTemplate>
        </asp:TemplateField>
         
    </Columns>
    </asp:GridView>

</div>
                 </div>
               
         
          
         </div>
         </div>
      </div>
   </div>
     </div>
            </div>
        </div>
</asp:Content>
