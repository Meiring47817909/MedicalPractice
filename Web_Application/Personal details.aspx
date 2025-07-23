<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Personal details.aspx.cs" Inherits="Web_Application.Personal_details" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 98px;
            text-align: center;
        }
        .auto-style14 {
            width: 865px;
            height: 541px;
            top: 0%;
            right: 0%;
            bottom: 0%;
            left: 0%;
            margin-bottom: 0px;
        }
        .auto-style61 {
            font-size: x-large;
            height: 45px;
        }
        .auto-style45 {
            font-size: x-large;
            height: 29px;
            width: 426px;
        }
        .auto-style35 {
            text-decoration: underline;
        }
        .auto-style36 {
            font-size: x-large;
            height: 29px;
            text-align: left;
            width: 268435184px;
        }
        .auto-style40 {
            font-size: x-large;
            height: 13px;
            width: 426px;
            text-align: left;
        }
        .auto-style51 {
            font-size: x-large;
            height: 13px;
            width: 268435184px;
        }
        .auto-style27 {
            text-decoration: underline;
            font-size: x-large;
            height: 30px;
            width: 411px;
        }
        .auto-style31 {
            font-size: x-large;
            height: 30px;
        }
        .auto-style53 {
            font-size: x-large;
            height: 12px;
            width: 411px;
        }
        .auto-style60 {
            font-size: x-large;
            height: 12px;
        }
        .auto-style42 {
            text-decoration: underline;
            font-size: x-large;
            height: 29px;
            width: 411px;
        }
        .auto-style47 {
            text-decoration: underline;
            font-size: x-large;
            height: 29px;
        }
        .auto-style38 {
            font-size: x-large;
            height: 33px;
            width: 410px;
        }
        .auto-style46 {
            font-size: x-large;
            height: 33px;
        }
        .auto-style43 {
            width: 411px;
            height: 179px;
        }
        .auto-style58 {
            height: 47px;
        }
        .auto-style59 {
            height: 62px;
        }
        .auto-style23 {
            height: 63px;
        }
        .auto-style56 {
            height: 39px;
        }
        .auto-style62 {
            font-size: x-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="lblUpdateOrError" runat="server" CssClass="auto-style11" ForeColor="Black" style="font-size: xx-large"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style14" style="border: thick solid #000000; background-color: #C0C0C0;">
            <tr>
                <td class="auto-style61" colspan="4" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Update your personal details</strong></td>
            </tr>
            <tr>
                <td class="auto-style45" colspan="3" style="vertical-align: 40%">
                    <asp:Label ID="Label1" runat="server" Text="      "></asp:Label>
                    <span class="auto-style35">Name:</span></td>
                <td class="auto-style36" style="vertical-align: 40%">&nbsp;<span class="auto-style35">Surname:</span></td>
            </tr>
            <tr>
                <td class="auto-style40" colspan="3" style="vertical-align: 40%">
                    <asp:TextBox ID="txtName" runat="server" CssClass="auto-style5" MaxLength="20" Width="245px" style="font-size: x-large"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Enter name" Font-Bold="False" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Details"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style51" style="vertical-align: 40%">
                    <asp:TextBox ID="txtSurname" runat="server" CssClass="auto-style5" MaxLength="20" Width="245px" style="font-size: x-large"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="rfvSurname" runat="server" ControlToValidate="txtSurname" ErrorMessage="Enter surname" Font-Bold="False" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationGroup="Details"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style27" style="vertical-align: middle">Contact number:</td>
                <td class="auto-style31" colspan="3">&nbsp;<span class="auto-style35">Email address:</span></td>
            </tr>
            <tr>
                <td class="auto-style53" style="vertical-align: 40%">
                    <asp:TextBox ID="txtContact" runat="server" CssClass="auto-style5" MaxLength="10" TextMode="Phone" Width="245px" style="font-size: x-large"></asp:TextBox>
                    &nbsp;<asp:RegularExpressionValidator ID="revContact" runat="server" ControlToValidate="txtContact" ErrorMessage="Invalid contact" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^\d{10}$" ValidationGroup="Details"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style60" colspan="3" style="vertical-align: 40%">
                    <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style5" MaxLength="20" TextMode="Email" Width="245px" style="font-size: x-large"></asp:TextBox>
                    &nbsp;<asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Invalid email" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="Details"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style42" style="vertical-align: middle">Emergency contact:</td>
                <td class="auto-style47" colspan="3"></td>
            </tr>
            <tr>
                <td class="auto-style38" colspan="2" style="vertical-align: 40%">
                    <asp:TextBox ID="txtEmergencyContact" runat="server" CssClass="auto-style5" MaxLength="10" TextMode="Phone" Width="245px" style="font-size: x-large"></asp:TextBox>
                    &nbsp;<asp:RegularExpressionValidator ID="revEmergencyContact" runat="server" ControlToValidate="txtEmergencyContact" ErrorMessage="Invalid contact" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" ValidationExpression="^\d{10}$" ValidationGroup="Details"></asp:RegularExpressionValidator>
                </td>
                <td class="auto-style46" colspan="2" style="vertical-align: middle">
                    <asp:Button ID="btnUpdate" runat="server" CssClass="myButton" Height="37px" OnClick="btnUpdate_Click" Text="Update details" ValidationGroup="Details" Width="253px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style61" colspan="4" style="border-width: medium; border-color: #000000; border-top-style: solid; border-bottom-style: solid;"><strong>Update your Allergies</strong></td>
            </tr>
            <tr>
                <td class="auto-style43" rowspan="4" style="border-right-style: solid; border-width: thin; border-color: #000000; vertical-align: top;">
                    <div id="grdAllergiesScroll" style="max-height:200px;overflow-y:scroll;">
                        <asp:GridView ID="grdAllergies" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="auto-style62" ShowHeaderWhenEmpty="True" Width="423px">
                            <Columns>
                                <asp:BoundField DataField="Allergy" HeaderText="Allergy">
                                <HeaderStyle HorizontalAlign="Left" />
                                </asp:BoundField>
                            </Columns>
                            <HeaderStyle BackColor="#333399" ForeColor="White" />
                            <SelectedRowStyle BackColor="#0099FF" />
                        </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style58" colspan="3" style="vertical-align: 40%;">
                    <asp:TextBox ID="txtAllergy" runat="server" CssClass="auto-style5" MaxLength="20" style="font-size: x-large" Width="245px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="rfvAllergy" runat="server" ControlToValidate="txtAllergy" CssClass="auto-style5" ErrorMessage="Enter allergy" Font-Bold="False" Font-Underline="False" ForeColor="Red" SetFocusOnError="True" style="font-size: x-large" ValidationGroup="Allergy"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style59" colspan="3" style="text-align: left; vertical-align: middle">
                    <asp:Button ID="btnAdd" runat="server" CssClass="myButton" Height="45px" OnClick="btnAdd_Click" Text="Add" ValidationGroup="Allergy" Width="108px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style23" colspan="3" style="border-width: thin; border-color: #000000; border-top-style: solid; vertical-align: middle; text-align: left;">
                    <asp:Button ID="btnDelete" runat="server" CausesValidation="False" CssClass="myButton" Height="45px" OnClick="btnDelete_Click" Text="Delete" Width="108px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style56" colspan="4" style="border-width: medium; border-color: #000000; border-top-style: solid; ">
                    <asp:HyperLink ID="hplLogout" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Dashboard.aspx" style="font-size: x-large">Dashboard</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
