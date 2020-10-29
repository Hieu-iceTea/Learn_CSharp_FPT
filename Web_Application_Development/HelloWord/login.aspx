<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="HelloWord.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Login ID="Login1" runat="server" BackColor="#E3EAEB" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" OnAuthenticate="Login1_Authenticate" TextLayout="TextOnTop">
            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
            <LayoutTemplate>
                <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                    <tr>
                        <td>
                            <table cellpadding="0">
                                <tr>
                                    <td align="center" style="color:White;background-color:#1C5E55;font-size:0.9em;font-weight:bold;">Log In</td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                    </td>
                                </tr>
                                <tr>
                                    <td align="center" style="color:Red;">
                                        <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                    </td>
                                </tr>
                                <tr>
                                    <td align="right">
                                        <asp:Button ID="LoginButton" runat="server" BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" OnClick="LoginButton_Click" Text="Log In" ValidationGroup="Login1" />
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </LayoutTemplate>
            <LoginButtonStyle BackColor="White" BorderColor="#C5BBAF" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#1C5E55" />
            <TextBoxStyle Font-Size="0.8em" />
            <TitleTextStyle BackColor="#1C5E55" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
        </asp:Login>
        <br />
        <asp:Label ID="lblMessage" runat="server" Text="Message here"></asp:Label>
        <br />
        <br />
        <asp:ChangePassword ID="ChangePassword1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:ChangePassword>
    </form>
</body>
</html>
