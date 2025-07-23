<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Change password.aspx.cs" Inherits="Web_Application.Change_password" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 81px;
        }
        .auto-style2 {
            font-size: x-large;
            text-align: left;
        }
        .auto-style3 {
            font-size: x-large;
        }
        .auto-style4 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="lblChangeOrError" runat="server" CssClass="auto-style11" ForeColor="Black" style="font-size: xx-large"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style1" style="background-color: #C0C0C0; border: thick solid #000000">
        <tr>
            <td class="auto-style2" colspan="2" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Change your password</strong></td>
        </tr>
        <tr>
            <td class="auto-style3">Enter new password:</td>
            <td class="auto-style10">
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style5" MaxLength="20" Width="224px" style="font-size: x-large"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: middle" class="auto-style13"></td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" CssClass="auto-style4" ErrorMessage="Enter password" ForeColor="Red" ControlToValidate="txtPassword" SetFocusOnError="True" style="font-size: x-large"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td style="vertical-align: middle" class="auto-style4">
                <asp:Button ID="btnChange" runat="server" CssClass="myButton" Text="Change" OnClick="btnChange_Click" Width="108px" Height="45px" />
            </td>
            <td class="auto-style10">
                <asp:HyperLink ID="hplLoginOrDashboard" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Login.aspx" style="font-size: x-large">[hplLoginOrDashboard]</asp:HyperLink>
            </td>
        </tr>
    </table>
    </form>
</body>
</html>
