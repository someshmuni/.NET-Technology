<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="calenderV2.aspx.cs"
    Inherits="leave_form.calenderV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Academic Calendar</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h1>Academic Calendar and Leave Management System</h1>

        <h2>Academic Calendar</h2>

        <asp:Calendar
            ID="Calendar1"
            runat="server"
            OnSelectionChanged="calAcademic">
        </asp:Calendar>

        <br />

        <asp:Label
            ID="lblselectedDt"
            runat="server"
            Text="Select a date">
        </asp:Label>

        <br /><br />

        <asp:Button
            ID="btnApplyLeave"
            runat="server"
            Text="Apply Leave"
            OnClick="btnApplyLeave_Click" />

    </div>

</form>

</body>
</html>