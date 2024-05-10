using System;
using ClassLibrary;

namespace AdminSystem.Payment
{
    public partial class PaymentConfirmDelete : System.Web.UI.Page
    {
        private PaymentManager _paymentManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _paymentManager = new PaymentManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string paymentID = Request.QueryString["PaymentID"];
                txtPaymentID.Text = paymentID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int paymentID = int.Parse(txtPaymentID.Text);
            _paymentManager.DeletePayment(paymentID);
            Response.Redirect("PaymentList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("PaymentList.aspx");
        }
    }
}
