<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Book Appointment.aspx.cs" Inherits="Web_Application.Book_Appointment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="background-image: url('Images/Personal.jpg'); background-repeat: no-repeat; background-size: cover">
    <link rel="stylesheet" type ="text/css" href="Brighton_Medical_Style.css"/>
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            height: 95px;
        }
        .auto-style14 {
            width: 1051px;
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
            Height= 194px;
        }
        .auto-style17 {
            height: 50px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <strong>
            <asp:Label ID="lblAddOrError" runat="server" CssClass="auto-style11" ForeColor="Black" style="font-size: xx-large"></asp:Label>
            </strong>
        </div>
        <table align="center" class="auto-style14" style="border: thick solid #000000; background-color: #C0C0C0;">
            <tr>
                <td class="auto-style16" colspan="2" style="border-bottom-style: solid; border-width: medium; border-color: #000000"><strong>Book an appointment</strong></td>
            </tr>
            <tr>
                <td class="auto-style5" style="border-bottom-style: solid; border-width: thin; border-color: #000000">Choose an availabe appointment</td>
                <td class="auto-style5" style="border-left-style: solid; border-color: #000000; border-bottom-width: thin; border-left-width: medium; border-bottom-style: solid;">Select the procedure</td>
            </tr>
            <tr>
                <td class="auto-style15" style="vertical-align: top">
                    <div id="grdAvailableAppointmentsScroll" style="max-height:200px;overflow-y:scroll;">
                        <asp:GridView ID="grdAvailableAppointments" runat="server" AutoGenerateColumns="False" AutoGenerateSelectButton="True" CssClass="auto-style5" ShowHeaderWhenEmpty="True" Width="699px">
                            <Columns>
                                <asp:BoundField DataField="AppointmentID" HeaderText="Appointment ID"></asp:BoundField>
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:yyyy/MM/dd}" HeaderText="Date" />
                                <asp:BoundField DataField="Date_Time" DataFormatString="{0:HH:mm}" HeaderText="Time" />
                                <asp:BoundField DataField="Doctor" HeaderText="Doctor" />
                                <asp:BoundField DataField="Status" HeaderText="Status">
                                <ControlStyle BackColor="#33CC33" />
                                <ItemStyle BackColor="#33CC33" ForeColor="White" />
                                </asp:BoundField>
                            </Columns>
                            <HeaderStyle BackColor="#333399" ForeColor="White" />
                            <SelectedRowStyle BackColor="#0099FF" />
                        </asp:GridView>
                    </div>
                </td>
                <td class="auto-style15" style="border-left-style: solid; border-width: medium; border-color: #000000">
                    <asp:RadioButtonList ID="rlstProcedure" runat="server" Font-Size="X-Large" Height="198px" Width="375px">
                        <asp:ListItem Value="Medical result analysis">Medical result analysis – R360</asp:ListItem>
                        <asp:ListItem Value="Routine Check-up">Routine Check-up – R500</asp:ListItem>
                        <asp:ListItem Value="Surgical appointment">Surgical appointment – R1500</asp:ListItem>
                        <asp:ListItem Value="Urgent Medical Check-up">Urgent Medical Check-up – R2000</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td class="auto-style17" style="border-width: medium; border-color: #000000; border-top-style: solid;">
                    <asp:Button ID="btnBook" runat="server" CssClass="myButton" Height="45px" OnClick="btnBook_Click" style="font-size: x-large" Text="Book" Width="108px" />
                </td>
                <td class="auto-style17" style="border-top-style: solid; border-width: medium; border-color: #000000; border-left-style: solid;">
                    <asp:HyperLink ID="hplLogout" runat="server" CssClass="auto-style8" ForeColor="#3366FF" NavigateUrl="~/Dashboard.aspx" style="font-size: x-large">Dashboard</asp:HyperLink>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
