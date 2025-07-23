<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="Web_Application.Dashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            text-align: center;
            height: 81px;
        }
        .auto-style4 {
            width: 0%;
            height: 565px;
            top: 0%;
            right: 0%;
            bottom: 0%;
            left: 0%;
        }
        .auto-style3 {
            font-size: x-large;
            width: 269px;
        }
        .auto-style13 {
            width: 111px;
        }
        .auto-style7 {
            width: 269px;
            height: 102px;
        }
        .auto-style6 {
            width: 269px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <strong>
            <asp:Label ID="lblWelcomeOrError" runat="server" CssClass="auto-style1"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style4" style="border: thick solid #000000; background-color: #C0C0C0">
            <tr>
                <td class="auto-style3" style="border-bottom-style: solid; border-width: thin; border-color: #000000"><strong>Mangage password</strong></td>
                <td class="auto-style13" rowspan="8" style="border-left-style: solid; border-width: medium; border-color: #000000">
                    <asp:Image ID="imgProfilePicture" runat="server" Height="547px" Width="427px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style7" style="border-bottom-style: solid; border-width: medium; border-color: #000000">
                    <asp:Button ID="btnChangePassword" runat="server" CssClass="myButton" Height="45px" OnClick="btnChangePassword_Click" Text="Change password" Width="260px" />
                    <br />
                    <br />
                    <asp:HyperLink ID="hplLogout" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Login.aspx" style="font-size: x-large">Logout</asp:HyperLink>
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="border-bottom-style: solid; border-width: thin; border-color: #000000"><strong>Manage appointments</strong></td>
            </tr>
            <tr>
                <td class="auto-style6" style="border-bottom-style: solid; border-width: medium; border-color: #000000">
                    <asp:Button ID="btnBookAppointment" runat="server" CssClass="myButton" Height="45px" OnClick="btnBookAppointment_Click" Text="Book appointment" Width="260px" />
                    <br />
                    <br />
                    <asp:Button ID="btnCancelAppointment" runat="server" CssClass="myButton" Height="45px" OnClick="btnMyAppointments_Click" Text="Cancel appointment" Width="260px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="border-bottom-style: solid; border-width: thin; border-color: #000000"><strong>Manage personal details</strong></td>
            </tr>
            <tr>
                <td class="auto-style6" style="border-bottom-style: solid; border-width: medium; border-color: #000000">
                    <asp:Button ID="btnUpdateDetails" runat="server" CssClass="myButton" Height="45px" OnClick="btnUpdateDetails_Click" Text="Update personal details" Width="260px" />
                    <br />
                    <br />
                    <asp:Button ID="btnViewInvoices" runat="server" CssClass="myButton" Height="45px" OnClick="btnViewInvoices_Click" Text="View invoices" Width="260px" />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style3" style="border-bottom-style: solid; border-width: thin; border-color: #000000"><strong>Change avatar</strong></td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:DropDownList ID="drpAvatar" runat="server" AutoPostBack="True" Font-Size="X-Large" OnSelectedIndexChanged="drpAvatar_SelectedIndexChanged">
                        <asp:ListItem>Other</asp:ListItem>
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
