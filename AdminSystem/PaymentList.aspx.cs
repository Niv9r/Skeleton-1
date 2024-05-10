using System;
using ClassLibrary;

namespace AdminSystem.Payment
{
    public partial class PaymentList : System.Web.UI.Page
    {
        private PaymentManager _paymentManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _paymentManager = new PaymentManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadPaymentList();
            }
        }

        private void LoadPaymentList()
        {
            GridViewPayment.DataSource = _paymentManager.GetAllPayments();
            GridViewPayment.DataBind();
        }
    }
}
