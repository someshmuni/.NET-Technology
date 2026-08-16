using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineEventRegistration
{
    public partial class EventRegistration : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblMessage.Text = "Registration Successful! Welcome " + txtName.Text
                    + "<br/>Event: " + ddlEvent.SelectedItem.Text
                    + "<br/>Event Date: " + txtDate.Text
                    + "<br/>Tickets: " + txtTickets.Text;
            }
        }
        protected void cvTerms_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = chkTerms.Checked;
        }
    }
}