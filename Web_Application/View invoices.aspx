<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View invoices.aspx.cs" Inherits="Web_Application.View_invoices" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 96px;
        }
        .auto-style14 {
            width: 800px;
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
        .auto-style15 {
            height: 181px;
        }
        .auto-style17 {
            height: 54px;
        }
        .auto-style5 {
            font-size: x-large;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="lblError" runat="server" CssClass="auto-style18" style="font-size: xx-large"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style14" style="border: thick solid #000000; background-color: #C0C0C0;">
            <tr>
                <td class="auto-style16" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Your invoices</strong></td>
            </tr>
            <tr>
                <td class="auto-style15" style="vertical-align: top">
                    <div id="grdBookedAppointmentsScroll" style="max-height:200px;overflow-y:scroll;">
                        <asp:GridView ID="grdViewInvoices" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="auto-style5" ShowHeaderWhenEmpty="True" Width="1166px">
                            <Columns>
                                <asp:BoundField DataField="AppointmentID" HeaderText="Appointment ID"></asp:BoundField>
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Date" />
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:HH:mm}" HeaderText="Time" />
                                <asp:BoundField DataField="Doctor" HeaderText="Doctor" />
                                <asp:BoundField DataField="Type" HeaderText="Procedure"></asp:BoundField>
                                <asp:BoundField DataField="Price" DataFormatString="{0:C2}" HeaderText="Price" />
                                <asp:BoundField DataField="Status" HeaderText="Status">
                                <ControlStyle BackColor="#33CC33" />
                                <ItemStyle BackColor="Yellow" />
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
                    <asp:HyperLink ID="hplLogout" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Dashboard.aspx" style="font-size: x-large">Dashboard</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
