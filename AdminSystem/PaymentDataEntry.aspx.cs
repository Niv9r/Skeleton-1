using System;
using ClassLibrary;

namespace AdminSystem.Payment
{
    public partial class PaymentDataEntry : System.Web.UI.Page
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
            txtOrderID.Text = payment.OrderID.ToString();
            txtPaymentDate.Text = payment.PaymentDate.ToString("yyyy-MM-dd");
            txtPaymentMethod.Text = payment.PaymentMethod;
            txtAmount.Text = payment.Amount.ToString("0.00");
            txtStatus.Text = payment.Status;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _paymentManager.AddPayment(
                int.Parse(txtOrderID.Text), DateTime.Parse(txtPaymentDate.Text), txtPaymentMethod.Text,
                decimal.Parse(txtAmount.Text), txtStatus.Text);

            Response.Redirect("PaymentList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _paymentManager.UpdatePayment(
                int.Parse(Request.QueryString["PaymentID"]),
                int.Parse(txtOrderID.Text), DateTime.Parse(txtPaymentDate.Text), txtPaymentMethod.Text,
                decimal.Parse(txtAmount.Text), txtStatus.Text);

            Response.Redirect("PaymentList.aspx");
        }
    }
}
