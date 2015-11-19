<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8"/>
  <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>
  <title>Login Form</title>
  <link rel="stylesheet" href="css/style.css"/> 
      <script type="text/javascript">
          window.history.forward();
          function noBack() {
              window.history.forward();
          }
</script>
   </head>
    <body   onLoad="noBack();" onpageshow="if (event.persiste d) noBack();" onUnload="" >
     <section class="container">
    <div class="login">
      <h1>Login to Web App</h1>
      <form runat="server">
       <h2>welcome <asp:TextBox ID="sessionval" runat="server"></asp:TextBox></h2>
          <asp:TextBox ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
          <asp:TextBox ID="txtpassword" runat="server" placeholder="Password" textmode="Password"></asp:TextBox>
        <p class="remember_me">
          <label>
            <input type="checkbox" name="remember_me" id="remember_me"/>
            Remember me on this computer
          </label>
        </p>
        <p class="submit">
            <asp:Button ID="Button1" runat="server" Text="Login" onclick="btn_clk"/></p>
     <a href="regn.aspx">click here to register</a>
           </form>
    </div>







    <div class="login-help">
      <p>Forgot your password? <a href="index.html">Click here to reset it</a>.</p>
    </div>
  </section>
 </body>
 </html>
