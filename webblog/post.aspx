<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage.master" CodeFile="post.aspx.cs" Inherits="Default5" %>
 <asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <style>
#bg1
{
	background-color: #007ACC;
}
#bg3
{
	background-color:#1987D1;
}
#font
{
	font-size:25px;
	color:white;
}
.padding1{
	top: 60px;
	left: 250px;
	right:200px;
	width:500px;
	height:350px;
	position:relative;
	border-width: 1px;
	border-color: white;
	border-radius: 0px;
	border-style: solid;
	
}
.pd{
	height: 200px;
	margin-left: 10px;
	width: 450px;
}
.pd1{
	background-color:#007ACC;
	color:white;
	margin-left: 250px;
	width: 200px;
	height:50px;
	font-weight: bolder;
}
p{
	font-size: 50px;
	color:white;
}
</style>
  
<div id="bg1">
<p>Pucho <asp:Label ID="Label1" runat="server" Text=""></asp:Label></p>
	<div id="bg3" class="padding1">
		
			<br>
                   <asp:Panel ID="Panel2" runat="server" DefaultButton="Button1">
               <asp:TextBox ID="TextBox" runat="server" class="pd" placeholder="Kya puchna h VATSA??" onkeypress="return EnterEvent(btn_post)" ></asp:TextBox>

  			
  			<br/><br/>
        
        <asp:Button ID="Button1" runat="server" Text="Pucho Vatsa" OnClick="btn_post" class="pd1"  />
        <asp:Label ID ="label23" runat="server" Text="" />
            </asp:Panel>
       
		
	</div>
</div>
             
     
     
     
</asp:Content>