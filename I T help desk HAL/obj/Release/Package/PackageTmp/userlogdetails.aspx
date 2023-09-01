<%@ Page Title="" Language="C#" MasterPageFile="~/masterhal.Master" AutoEventWireup="true" CodeBehind="userlogdetails.aspx.cs" Inherits="I_T_help_desk_HAL.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/userlogdetails.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="background3"   >
    <div class="container">
       
      <div class="row">
         <div class="container-box  col-md-10 mx-auto mt-3  mb-3"  >
            <div class="">
               <div class="">
                  <div class="row">
                     <div class="col">
                        <center>
                                            <img  src="images/check.gif" style="border-radius: 50%; 
  width: 150px; 
  height: 150px; 
  object-fit: cover;" />
                        </center>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col">
                        <center>
                           <h3>Log Details</h3>        
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
                        <label>Name :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Full Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-6">
                        <label>contact:</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Contact No." ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                      <div class="col-md-6">
                        <label>Departmemt :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Department" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                    <div class="col-md-6">
                        <label>Location :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Location" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                    <div class="col-md-6">
                        <label>Equipment :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox10" runat="server" placeholder="Equipment" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                      <div class="col-md-6">
                        <label>Problem :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Problem" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                   <div class="row">
                       <div class="col-md-6">
                        <label>Created Date :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Date" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                    <div class="col-md-6">
                        <label>Last Date :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Date" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                     <div class="row">
                       <div class="col-md-6">
                        <label>Taken By :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox11" runat="server" placeholder="Name" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                    <div class="col-md-6">
                        <label>Taken Date :</label>
                        <div class="form-group" >
                           <asp:TextBox CssClass="form-control" ID="TextBox12" runat="server" placeholder="Date" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                          <div class="row">
                      <div class="col-md-12">
                           <label>Problem in detail :</label>
                           <div class="form-group">
                         <asp:TextBox ID="txtParagraph" runat="server" TextMode="MultiLine" CssClass="form-control" Rows="5" Columns="60" ReadOnly="True"></asp:TextBox>
                           </div>

                     </div>
                  </div>
                         <br />
                            <div class="row">
                              
                     <div class="col-6 mx-auto">
                             <br />
                        <center>
                           <div class="form-group  d-grid gap-2">
                              <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Solved" OnClick="Button1_Click"  />
                           </div>
                        </center>
                         <br />
                     </div>
                     
                  </div>
                  </div>
                   <hr />
                    <div class="row">
                     <div class="col">
                        <center>
                                                                   <img  src="images/chatani.gif" style="border-radius: 50%; 
  width: 150px; 
  height: 150px; 
  object-fit: cover;" />
                           
                        </center>
                     </div>
                  </div>
                  <div class="row">
    <div class="col">
        <center>
            <h3>User Comment Box</h3>
        </center>
    </div>
</div>
<hr />
<div class="chat container">
        <div class="row justify-content-md-center">
            <div class="col-md-8">
                <div id="commentBox" class="comment-box">
                    <div id="commentReadBox">
                        <ul id="comments" runat="server" class="list-unstyled"></ul>
                    </div>
                    
                  
                    <asp:TextBox ID="TextBox9" runat="server" CssClass="form-control comment-input" placeholder="Add a comment..."></asp:TextBox>
                    <center>
                        <br />
                    <asp:Button ID="addCommentButton" runat="server" Text="Add Comment"  CssClass="btn btn-primary comment-btn" OnClick="addCommentButton_Click1" />
                    </center>
                </div>
            </div>
        </div>
    </div>

            <a href="userhome.aspx" ><< Back to Home</a><br><br>
         </div>
         </div>
             </div>
          </div>
      </div>
  
     </div>
</asp:Content>

