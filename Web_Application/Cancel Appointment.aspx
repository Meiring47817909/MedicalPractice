<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cancel Appointment.aspx.cs" Inherits="Web_Application.Cancel_Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 88px;
        }
        .auto-style14 {
            width: 964px;
            height: 314px;
            top: 0%;
            right: 0%;
            bottom: 0%;
            left: 0%;
            margin-bottom: 0px;
        }
        .auto-style16 {
            font-size: x-large;
            height: 43px;
        }
        .auto-style5 {
            font-size: x-large;
        }
        .auto-style15 {
            height: 181px;
        }
        .auto-style17 {
            height: 54px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="lblCancelOrError" runat="server" CssClass="auto-style11" ForeColor="Black" style="font-size: xx-large"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style14" style="border: thick solid #000000; background-color: #C0C0C0;">
            <tr>
                <td class="auto-style16" colspan="2" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Cancel an appointment</strong></td>
            </tr>
            <tr>
                <td class="auto-style5" colspan="2" style="border-bottom-style: solid; border-width: thin; border-color: #000000">Choose a booked appointment to cancel</td>
            </tr>
            <tr>
                <td class="auto-style15" colspan="2" style="vertical-align: top">
                    <div id="grdBookedAppointmentsScroll" style="max-height:200px;overflow-y:scroll;">
                        <asp:GridView ID="grdBookedAppointments" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="auto-style5" ShowHeaderWhenEmpty="True" Width="1139px">
                            <Columns>
                                <asp:BoundField DataField="AppointmentID" HeaderText="Appointment ID"></asp:BoundField>
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Date" />
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:HH:mm}" HeaderText="Time" />
                                <asp:BoundField DataField="Doctor" HeaderText="Doctor" />
                                <asp:BoundField DataField="Type" HeaderText="Procedure"></asp:BoundField>
                                <asp:BoundField DataField="Price" DataFormatString="{0:C2}" HeaderText="Price" />
                                <asp:BoundField DataField="Status" HeaderText="Status">
                                <ControlStyle BackColor="#33CC33" />
                                <ItemStyle BackColor="#006600" ForeColor="White" />
                                </asp:BoundField>
                            </Columns>
                            <HeaderStyle BackColor="#333399" ForeColor="White" />
                            <SelectedRowStyle BackColor="#0099FF" />
                        </asp:GridView>
                    </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style17" style="border-width: medium; border-color: #000000; border-top-style: solid;">
                    <asp:Button ID="btnCancel" runat="server" CssClass="myButton" Height="44px" OnClick="btnCancel_Click" Text="Cancel" Width="108px" />
                </td>
                <td class="auto-style17" style="border-top-style: solid; border-width: medium; border-color: #000000; border-left-style: solid;">
                    <asp:HyperLink ID="hplLogout" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Dashboard.aspx" style="font-size: x-large">Dashboard</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
