<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EventRegistration.aspx.cs" Inherits="OnlineEventRegistration.EventRegistration" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h1>ONLINE EVENT REGISTRATION PORTAL</h1>

<hr />

<h3>Participant Details</h3>
    <asp:Label ID="lblDate" runat="server"
    Text="Event Date: ">
</asp:Label>

<br />

<asp:TextBox ID="txtDate" runat="server"
    TextMode="Date">
</asp:TextBox>

<asp:RequiredFieldValidator
    ID="rfvDate"
    runat="server"
    ControlToValidate="txtDate"
    ErrorMessage="Please select the event date."
    ForeColor="Red">
</asp:RequiredFieldValidator>

<br /><br />


<br />

<asp:Label ID="lblName" runat="server"
    Text="Full Name: ">
</asp:Label>

<br />

<asp:TextBox ID="txtName" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator
    ID="rfvName"
    runat="server"
    ControlToValidate="txtName"
    ErrorMessage="Please enter your name."
    ForeColor="Red">
</asp:RequiredFieldValidator>

<br /><br />


<asp:Label ID="lblEmail" runat="server"
    Text="Email: ">
</asp:Label>

<br />

<asp:TextBox ID="txtEmail" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator
    ID="rfvEmail"
    runat="server"
    ControlToValidate="txtEmail"
    ErrorMessage="Please enter your email."
    ForeColor="Red">
</asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator
    ID="revEmail"
    runat="server"
    ControlToValidate="txtEmail"
    ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
    ErrorMessage="Please enter a valid email address."
    ForeColor="Red">
</asp:RegularExpressionValidator>

<br /><br />


<asp:Label ID="lblPhone" runat="server"
    Text="Phone Number: ">
</asp:Label>

<br />

<asp:TextBox ID="txtPhone" runat="server">
</asp:TextBox>

<asp:RequiredFieldValidator
    ID="rfvPhone"
    runat="server"
    ControlToValidate="txtPhone"
    ErrorMessage="Please enter your phone number."
    ForeColor="Red">
</asp:RequiredFieldValidator>

    <asp:RegularExpressionValidator
    ID="revPhone"
    runat="server"
    ControlToValidate="txtPhone"
    ValidationExpression="^[0-9]{10}$"
    ErrorMessage="Phone number must contain exactly 10 digits."
    ForeColor="Red">
</asp:RegularExpressionValidator>

<br /><br />


<asp:Label ID="lblEvent" runat="server"
    Text="Select Event: ">
</asp:Label>

<br />

<asp:DropDownList ID="ddlEvent" runat="server">

    <asp:ListItem Text="-- Select Event --" Value="">
    </asp:ListItem>

    <asp:ListItem Text="AI Workshop" Value="AI Workshop">
    </asp:ListItem>

    <asp:ListItem Text="Web Development Seminar" Value="Web Development Seminar">
    </asp:ListItem>

    <asp:ListItem Text="Coding Competition" Value="Coding Competition">
    </asp:ListItem>

    <asp:ListItem Text="Tech Fest" Value="Tech Fest">
    </asp:ListItem>

</asp:DropDownList>

<asp:RequiredFieldValidator
    ID="rfvEvent"
    runat="server"
    ControlToValidate="ddlEvent"
    InitialValue=""
    ErrorMessage="Please select an event."
    ForeColor="Red">
</asp:RequiredFieldValidator>

<br /><br />


<asp:Label ID="lblTickets" runat="server"
    Text="Number of Tickets: ">
</asp:Label>

<br />

<asp:TextBox ID="txtTickets" runat="server">
</asp:TextBox>



<asp:RangeValidator
    ID="rvTickets"
    runat="server"
    ControlToValidate="txtTickets"
    MinimumValue="1"
    MaximumValue="5"
    Type="Integer"
    ErrorMessage="Tickets must be between 1 and 5."
    ForeColor="Red">
</asp:RangeValidator>

<br /><br />


<asp:Label ID="lblGender" runat="server"
    Text="Gender: ">
</asp:Label>

<br />

<asp:RadioButton
    ID="rbMale"
    runat="server"
    GroupName="Gender"
    Text="Male">
</asp:RadioButton>

<asp:RadioButton
    ID="rbFemale"
    runat="server"
    GroupName="Gender"
    Text="Female">
</asp:RadioButton>

<asp:RadioButton
    ID="rbOther"
    runat="server"
    GroupName="Gender"
    Text="Other">
</asp:RadioButton>

<br /><br />


<asp:CheckBox
    ID="chkTerms"
    runat="server"
    Text="I agree to the Terms and Conditions.">
</asp:CheckBox>

<asp:CustomValidator
    ID="cvTerms"
    runat="server"
    ErrorMessage="Please agree to the Terms and Conditions."
    ForeColor="Red"
    OnServerValidate="cvTerms_ServerValidate">
</asp:CustomValidator>

<br /><br />


<asp:Button
    ID="btnRegister"
    runat="server"
    Text="Register"
    OnClick="btnRegister_Click">
</asp:Button>

<br /><br />


<asp:Label
    ID="lblMessage"
    runat="server"
    ForeColor="Green">
</asp:Label>

<br /><br />


<asp:ValidationSummary
    ID="ValidationSummary1"
    runat="server"
    ForeColor="Red">
</asp:ValidationSummary>
</asp:Content>
