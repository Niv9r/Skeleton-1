using System;
using ClassLibrary;

namespace AdminSystem.Customer
{
    public partial class CustomerViewer : System.Web.UI.Page
    {
        private CustomerManager _customerManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _customerManager = new CustomerManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string customerID = Request.QueryString["CustomerID"];
                if (!string.IsNullOrEmpty(customerID))
                {
                    LoadCustomer(int.Parse(customerID));
                }
            }
        }

        private void LoadCustomer(int customerID)
        {
            var customer = _customerManager.GetCustomerByID(customerID);
            txtCustomerID.Text = customer.CustomerID.ToString();
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            txtCountryCode.Text = customer.CountryCode;
            txtAddress.Text = customer.Address;
            chkIsActive.Checked = customer.IsActive;
        }
    }
}
