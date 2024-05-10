using System;
using ClassLibrary;

namespace AdminSystem.Staff
{
    public partial class StaffDataEntry : System.Web.UI.Page
    {
        private StaffManager _staffManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _staffManager = new StaffManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string staffID = Request.QueryString["StaffID"];
                if (!string.IsNullOrEmpty(staffID))
                {
                    LoadStaff(int.Parse(staffID));
                }
            }
        }

        private void LoadStaff(int staffID)
        {
            var staff = _staffManager.GetStaffByID(staffID);
            txtFirstName.Text = staff.FirstName;
            txtLastName.Text = staff.LastName;
            txtEmail.Text = staff.Email;
            txtPhone.Text = staff.Phone;
            ddlCountryCode.SelectedValue = staff.CountryCode;
            txtRole.Text = staff.Role;
            txtHireDate.Text = staff.HireDate.ToString("yyyy-MM-dd");
            chkIsActive.Checked = staff.IsActive;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _staffManager.AddStaff(
                txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text,
                ddlCountryCode.SelectedValue, txtRole.Text, DateTime.Parse(txtHireDate.Text),
                chkIsActive.Checked, HashPassword(txtPassword.Text));

            Response.Redirect("StaffList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _staffManager.UpdateStaff(
                int.Parse(Request.QueryString["StaffID"]),
                txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text,
                ddlCountryCode.SelectedValue, txtRole.Text, DateTime.Parse(txtHireDate.Text),
                chkIsActive.Checked);

            Response.Redirect("StaffList.aspx");
        }

        private string HashPassword(string password)
        {
            // Implement a proper password hashing mechanism here. this is not done to see if you guys are bothered to check. text me if you see this.
            return password; // this is an example only.
        }
    }
}
