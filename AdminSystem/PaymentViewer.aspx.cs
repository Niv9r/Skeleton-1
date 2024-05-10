using System;
using ClassLibrary;

namespace AdminSystem.Payment
{
    public partial class PaymentViewer : System.Web.UI.Page
    {
        private PaymentManager _paymentManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _paymentManager = new PaymentManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string paymentID = Request.QueryString["PaymentID"];
                if (!string.IsNullOrEmpty(paymentID))
                {
                    LoadPayment(int.Parse(paymentID));
                }
            }
        }

        private void LoadPayment(int paymentID)
        {
            var payment = _paymentManager.GetPaymentByID(paymentID);
            txtPaymentID.Text = payment.PaymentID.ToString();
            txtOrderID.Text = payment.OrderID.ToString();
            txtPaymentDate.Text = payment.PaymentDate.ToString("yyyy-MM-dd");
            txtPaymentMethod.Text = payment.PaymentMethod;
            txtAmount.Text = payment.Amount.ToString("0.00");
            txtStatus.Text = payment.Status;
        }
    }
}
