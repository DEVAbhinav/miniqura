<%@ Page Language="C#" AutoEventWireup="true" CodeFile="details.aspx.cs" Inherits="after_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form runat="server">
  <h1 style="margin-left:250px">Profile</h1>
        <table>
            <tr>
                <td><asp:Label ID="Label1" runat="server" Text="Name : "></asp:Label></td>
                <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
           </tr>
             <tr>
                <td><asp:Label ID="Label2" runat="server" Text="Email : "></asp:Label></td>

                 <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
           </tr>
             <tr>
                <td><asp:Label ID="Label3" runat="server" Text="Gender : "></asp:Label></td>
                <td><asp:RadioButton ID="Male" runat="server" Text="Male" /></td>
                <td><asp:RadioButton ID="Female" runat="server" Text="Female" /></td>
             </tr> 
             <tr>   <td><asp:Label ID="Label4" runat="server" Text="Address : "></asp:Label></td>
                <td> <asp:TextBox ID="txtadd" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
            <td><asp:Label ID="Label5" runat="server" Text="State:"></asp:Label></td>
             <td>
                 <asp:TextBox ID="txtstate" runat="server"></asp:TextBox></td>
             </tr><tr>
                <td><asp:Label ID="Label6" runat="server" Text="City : "></asp:Label></td>
                <td><asp:TextBox ID="txtcity" runat="server"></asp:TextBox></td>
           </tr> <tr>
                <td><asp:Label ID="Label7" runat="server" Text="Pin No. : "></asp:Label></td>
                <td><asp:TextBox ID="txtpin" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td><asp:Label ID="Label8" runat="server" Text="Mobile : "></asp:Label></td>
                <td><asp:TextBox ID="txtmobile" runat="server"></asp:TextBox></td>
           </tr>
            <tr>
                <td></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Update" OnClick="btn_home" /></td>
            </tr>

        </table>
    </form>
</body>
</html>
