using System;
using ClassLibrary;

namespace AdminSystem.Customer
{
    public partial class CustomerList : System.Web.UI.Page
    {
        private CustomerManager _customerManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _customerManager = new CustomerManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadCustomerList();
            }
        }

        private void LoadCustomerList()
        {
            GridViewCustomer.DataSource = _customerManager.GetAllCustomers();
            GridViewCustomer.DataBind();
        }
    }
}
