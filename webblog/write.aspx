<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="write.aspx.cs" Inherits="write"%>
<asp:Content ID="content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     
         <div id="main">
               <table width="100%" border="0" cellspacing="0" cellpadding="2" id="Table5">
                <tr>
                <td colspan="2">
                    
                    <asp:Repeater runat="server" ID="question_list" OnItemCommand="question_list_OnItemCommand">
                            <HeaderTemplate>
                           <table border="0" width="100%">
                            </HeaderTemplate>
                            <ItemTemplate>
                            <tr >
                              <td >
                                  <fieldset style="border-color: Blue;">
                                      <legend>


                                          <asp:Label ID="lblques" runat="server" Text='<%#Eval("ques") %>' ForeColor="#0033CC" Font-Bold="True" />

                                      </legend>
                                      <%--Matter Display--%>
                                      <table>
                                          <tr>
                                              <td><b>Posted By:</b></td>
                                              <td colspan="5">
                                                  <asp:Label ID="lblpostedby" runat="server" Text='<%#Eval("name") %>' Style="text-align: left" Width="100%" /></td>
                                          </tr>
                                          <tr>

                                              <td><b>Posted On:</b></td>
                                              <td colspan="5">
                                                  <asp:Label ID="lblpostedon" runat="server" Text='<%#Eval("cr_date") %>' Style="text-align: left" Width="100%" /></td>

                                          </tr>
                                          <tr>
                                      </table>
                                      <%--Matter Display--%>
                            </table>
                                 
                                                 </fieldset>
                    </td>
                </tr>
            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
                </td></tr>
           
       
       
       
       </div>
       

   
    </asp:Content>