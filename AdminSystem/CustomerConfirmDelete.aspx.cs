using System;
using ClassLibrary;

namespace AdminSystem.Customer
{
    public partial class CustomerConfirmDelete : System.Web.UI.Page
    {
        private CustomerManager _customerManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _customerManager = new CustomerManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string customerID = Request.QueryString["CustomerID"];
                txtCustomerID.Text = customerID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int customerID = int.Parse(txtCustomerID.Text);
            _customerManager.DeleteCustomer(customerID);
            Response.Redirect("CustomerList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerList.aspx");
        }
    }
}
