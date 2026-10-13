using System;
using System.Web.UI;

namespace leave_form
{
    public partial class calenderV2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void calAcademic(object sender, EventArgs e)
        {
            DateTime selectedDate = Calendar1.SelectedDate;

            lblselectedDt.Text =
                "Selected Date: " + selectedDate.ToString("dd-MM-yyyy");

            // Store selected date in Session
            Session["LeaveDate"] = selectedDate;
        }

        protected void btnApplyLeave_Click(object sender, EventArgs e)
        {
            // Go to Leave Application page
            Response.Redirect("LeaveApplyV2.aspx");
        }
    }
}