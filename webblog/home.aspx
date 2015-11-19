<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" EnableSessionState="True" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <link href="write.css" rel="stylesheet" />
    <div id="left">
        <br />
        &nbsp;                                                                                                                                                                                 
            Feeds&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
            <span class="auto-style1"><a href="#">edit</a></span>&nbsp;&nbsp;<span class="auto-style1">&nbsp; </span>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Top Stories" />
        <hr />
        <ul>
            <li>
                <asp:Label ID="Label1" runat="server" Text="Software & Application"></asp:Label></li>
            <li>
                <asp:Label ID="Label2" runat="server" Text="Learning to program"></asp:Label></li>
            <li>
                <asp:Label ID="Label3" runat="server" Text="Learning to program"></asp:Label></li>
            <li>
                <asp:Label ID="Label4" runat="server" Text="Learning to program"></asp:Label></li>
            <li>
                <asp:Label ID="Label5" runat="server" Text="Tourism"></asp:Label></li>
            <li>
                <asp:Label ID="Label6" runat="server" Text="Calculus"></asp:Label></li>
        </ul>
        <br />
        <h2>welcome
            <asp:TextBox ID="sessionval" runat="server"></asp:TextBox></h2>
        <br />

        Treading Now
           <hr />
        <ul>
            <li>Server Security</li>
            <li>Inside Out</li>
        </ul>
    </div>
    <div id="main">

        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <table style="border-color: blue; color: steelblue ">

                    <tr>
                        
                        <td>

                            <asp:Label ID="lblques" runat="server" Text='<%#Eval("Text") %>' ForeColor="steelblue" Font-Bold="True" />
                        </td>
                    </tr>
                    <tr>

                        <td>
                            <b>Hits : </b>

                        </td>
                        <td>

                            <asp:Label ID="Label9" runat="server" Text='<%#Eval("Hits") %>' ForeColor="lightblue" Font-Bold="True" />
                        </td>
                        
                        <td>
                            <b>Asked By: </b>

                        </td>
                        <td>

                            <asp:Label ID="lblaskby" runat="server" Text='<%#Eval("Email") %>' ForeColor="lightblue" Font-Bold="True" />
                        </td>
                  
                        
                        </tr>
                    <tr>


                        <td>
                            <b>Asked On: </b>

                        </td>
                        <td>

                            <asp:Label ID="Label7" runat="server" Text='<%#Eval("CrDate") %>' ForeColor="lightblue" Font-Bold="True" />
                        </td>
                    </tr>



                </table>

            </ItemTemplate>





        </asp:Repeater>







    </div>

    <div id="right">

        <fieldset id="border">
            <h4>Welcome To GuruJI</h4>
            <hr />
            <br />
            GuruJI is made for the people like you who likes to share thier knowledge and intrested in writting blog.
                    <br />
            You can get the millions if intresting answer here.

        </fieldset>
    </div>
</asp:Content>
