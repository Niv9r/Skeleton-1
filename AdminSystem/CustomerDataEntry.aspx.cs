using System;
using ClassLibrary;

namespace AdminSystem.Customer
{
    public partial class CustomerDataEntry : System.Web.UI.Page
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
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            txtEmail.Text = customer.Email;
            txtPhone.Text = customer.Phone;
            ddlCountryCode.SelectedValue = customer.CountryCode;
            txtAddress.Text = customer.Address;
            chkIsActive.Checked = customer.IsActive;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _customerManager.AddCustomer(
                txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text,
                ddlCountryCode.SelectedValue, txtAddress.Text, chkIsActive.Checked,
                HashPassword(txtPassword.Text));

            Response.Redirect("CustomerList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _customerManager.UpdateCustomer(
                int.Parse(Request.QueryString["CustomerID"]),
                txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text,
                ddlCountryCode.SelectedValue, txtAddress.Text, chkIsActive.Checked);

            Response.Redirect("CustomerList.aspx");
        }

        private string HashPassword(string password)
        {
            // Implement a proper password hashing mechanism here.
            return password; // Example only. another test 
        }
    }
}
