using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderConfirmDelete : System.Web.UI.Page
    {
        private OrderManager _orderManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderManager = new OrderManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string orderID = Request.QueryString["OrderID"];
                txtOrderID.Text = orderID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int orderID = int.Parse(txtOrderID.Text);
            _orderManager.DeleteOrder(orderID);
            Response.Redirect("OrderList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderList.aspx");
        }
    }
}
