<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="LeaveApplyV2.aspx.cs"
    Inherits="leave_form.LeaveApplyV2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Leave Application</title>
</head>

<body>

<form id="form1" runat="server">

    <div>

        <h3>LEAVE APPLICATION</h3>

        Employee Name:
        <asp:TextBox
            ID="txtTemp"
            runat="server">
        </asp:TextBox>

        <br /><br />

        Leave Date:
        <asp:TextBox
            ID="TB1"
            runat="server"
            ReadOnly="true">
        </asp:TextBox>

        <br /><br />

        Leave Type:
        <asp:DropDownList
            ID="DropDownList1"
            runat="server">

            <asp:ListItem>Select leave type</asp:ListItem>
            <asp:ListItem>Medical Leave</asp:ListItem>
            <asp:ListItem>Emergency Leave</asp:ListItem>

            <asp:ListItem>Tour Leave</asp:ListItem>
            <asp:ListItem>Casual Leave</asp:ListItem>

        </asp:DropDownList>

        <br /><br />

        Reason:

        <asp:TextBox
            ID="txtReason"
            runat="server"
            TextMode="MultiLine"
            Rows="4"
            Columns="20">
        </asp:TextBox>

        <br /><br />

        <asp:CheckBox
            ID="checkBox1"
            runat="server"
            Text="Remember My Name" />

        <br /><br />

        <asp:Button
            ID="btn"
            runat="server"
            Text="Submit Leave"
            OnClick="btn_Click" />

        <br /><br />

        <asp:Label
            ID="LBLMSG"
            runat="server">
        </asp:Label>

    </div>

</form>

</body>
</html>