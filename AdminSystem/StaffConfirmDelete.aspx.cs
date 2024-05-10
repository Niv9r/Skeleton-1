using System;
using ClassLibrary;

namespace AdminSystem.Staff
{
    public partial class StaffConfirmDelete : System.Web.UI.Page
    {
        private StaffManager _staffManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _staffManager = new StaffManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string staffID = Request.QueryString["StaffID"];
                txtStaffID.Text = staffID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int staffID = int.Parse(txtStaffID.Text);
            _staffManager.DeleteStaff(staffID);
            Response.Redirect("StaffList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("StaffList.aspx");
        }
    }
}
