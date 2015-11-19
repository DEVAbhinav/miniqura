<%@ Page Language="C#" AutoEventWireup="true" CodeFile="regn.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html>
<%--<html>  xmlns="http://www.w3.org/1999/xhtml">--%>
<head id="Head1" runat="server">
     <meta charset="utf-8"/>
  <%--<meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1"/>--%>
  <title>Registration Form</title>
  <link rel="stylesheet" href="css/style.css"/> 
</head>
<body>
        <section class="container">
    <div class="login">
      <h1>Register to Web App</h1>
      <form runat="server">
          <p><asp:TextBox ID="TextBox1" runat="server" placeholder="Name"></asp:TextBox></p>
          <p><asp:TextBox ID="TextBox2" runat="server" placeholder="Email" ></asp:TextBox></p>
          <p><asp:TextBox ID="TextBox3" type="Password" runat="server" placeholder="Password"></asp:TextBox></p>
          <p>
              <asp:RequiredFieldValidator ID="RFV1" runat="server" ErrorMessage="* Required name" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>
              <asp:RequiredFieldValidator ID="RFV2" runat="server" ErrorMessage="* Required email" ControlToValidate="TextBox2"></asp:RequiredFieldValidator>
        
               </p>
        <p class="remember_me">
          <label>
            <input type="checkbox" name="remember_me" runat="server" id="remember_me"/>
            Remember me on this computer
          </label>
        </p>
        <p class="submit"> <asp:Button ID="Button1" runat="server" Text="Register" OnClick="btn_reg"/></p>
      </form>
    </div>

    <div class="login-help">
      <p>Forgot your password? <a href="index.html">Click here to reset it</a></p>
    </div>
  </section>

  
</body>
</html>
