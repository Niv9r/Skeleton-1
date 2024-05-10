using System;
using ClassLibrary;

namespace AdminSystem.Staff
{
    public partial class StaffList : System.Web.UI.Page
    {
        private StaffManager _staffManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _staffManager = new StaffManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadStaffList();
            }
        }

        private void LoadStaffList()
        {
            GridViewStaff.DataSource = _staffManager.GetAllStaff();
            GridViewStaff.DataBind();
        }
    }
}
