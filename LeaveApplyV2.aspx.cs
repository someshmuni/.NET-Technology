using System;

namespace leave_form
{
    public partial class LeaveApplyV2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Check whether employee name is available in cookie
                if (Request.Cookies["EmpName"] != null)
                {
                    txtTemp.Text = Request.Cookies["EmpName"].Value;
                }

                // Get selected leave date from Session
                if (Session["LeaveDate"] != null)
                {
                    DateTime leaveDate = (DateTime)Session["LeaveDate"];

                    TB1.Text = leaveDate.ToString("dd-MM-yyyy");
                }
                else
                {
                    TB1.Text = "No date selected";
                }
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            string employeeName = txtTemp.Text;
            string leaveType = DropDownList1.SelectedValue;
            string reason = txtReason.Text;

            // Store employee name in Session
            Session["EmpName"] = employeeName;

            // Store leave information in Session
            Session["LeaveType"] = leaveType;
            Session["Reason"] = reason;

            // Create cookie if checkbox is selected
            if (checkBox1.Checked)
            {
                Response.Cookies["EmpName"].Value = employeeName;

                // Cookie will expire after 7 days
                Response.Cookies["EmpName"].Expires =
                    DateTime.Now.AddDays(7);
            }

            // Display successful submission message
            LBLMSG.Text =
                "<b>Leave application submitted successfully!</b><br/><br/>" +
                "Employee Name: " + employeeName + "<br/>" +
                "Leave Date: " + TB1.Text + "<br/>" +
                "Leave Type: " + leaveType + "<br/>" +
                "Reason: " + reason;
        }
    }
}