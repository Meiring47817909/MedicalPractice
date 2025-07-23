<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Web_Application.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Backgound_Image.JPG'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-size: xx-large;
            text-align: center;
            height: 81px;
        }
        .auto-style2 {
            width: 351px;
            height: 222px;
            top: 0%;
            right: 0%;
            bottom: 0%;
            left: 0%;
        }
        .auto-style3 {
            font-size: x-large;
            height: 41px;
        }
        .auto-style5 {
            font-size: x-large;
            width: 105px;
        }
        .auto-style6 {
            width: 105px;
        }
        .auto-style9 {
            width: 105px;
            height: 13px;
        }
        .auto-style10 {
            height: 13px;
        }
        .auto-style7 {
            width: 105px;
            height: 45px;
        }
        .auto-style8 {
            height: 45px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p class="auto-style1">
                <strong>Welcome to Brighton medical!</strong></p>
        </div>
        <table align="center" class="auto-style2" style="border: thick solid #000000; background-color: #C0C0C0;">
            <tr>
                <td class="auto-style3" colspan="2" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Login with your patient details</strong></td>
            </tr>
            <tr>
                <td class="auto-style5">Patient ID:</td>
                <td>
                    <asp:TextBox ID="txtPatientID" runat="server" CssClass="auto-style4" MaxLength="10" style="font-size: x-large" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">&nbsp;</td>
                <td>
                    <asp:RequiredFieldValidator ID="rfvPatientID" runat="server" ControlToValidate="txtPatientID" CssClass="auto-style4" ErrorMessage="Enter patient ID" ForeColor="Red" SetFocusOnError="True" style="font-size: x-large"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">Password:</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style4" MaxLength="20" style="font-size: x-large" TextMode="Password" Width="216px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9"></td>
                <td class="auto-style10">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword" CssClass="auto-style4" ErrorMessage="Enter password" ForeColor="Red" SetFocusOnError="True" style="font-size: x-large"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Button ID="btnLogin" runat="server" CssClass="myButton" Height="41px" Text="Login" Width="98px" OnClick="btnLogin_Click" />
                </td>
                <td class="auto-style8">
                    <asp:Label ID="lblError" runat="server" CssClass="auto-style4" ForeColor="Red" style="font-size: x-large"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
