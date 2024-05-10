using System;
using ClassLibrary;

namespace AdminSystem.Staff
{
    public partial class StaffViewer : System.Web.UI.Page
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
            txtStaffID.Text = staff.StaffID.ToString();
            txtFirstName.Text = staff.FirstName;
            txtLastName.Text = staff.LastName;
            txtEmail.Text = staff.Email;
            txtPhone.Text = staff.Phone;
            txtRole.Text = staff.Role;
            chkIsActive.Checked = staff.IsActive;
        }
    }
}
