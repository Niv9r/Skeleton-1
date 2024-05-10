using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderDataEntry : System.Web.UI.Page
    {
        private OrderManager _orderManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderManager = new OrderManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string orderID = Request.QueryString["OrderID"];
                if (!string.IsNullOrEmpty(orderID))
                {
                    LoadOrder(int.Parse(orderID));
                }
            }
        }

        private void LoadOrder(int orderID)
        {
            var order = _orderManager.GetOrderByID(orderID);
            txtCustomerID.Text = order.CustomerID.ToString();
            txtOrderDate.Text = order.OrderDate.ToString("yyyy-MM-dd");
            txtStatus.Text = order.Status;
            txtTotalAmount.Text = order.TotalAmount.ToString("0.00");
            chkOrderStatus.Checked = order.OrderStatus;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _orderManager.AddOrder(
                int.Parse(txtCustomerID.Text), DateTime.Parse(txtOrderDate.Text), txtStatus.Text,
                decimal.Parse(txtTotalAmount.Text), chkOrderStatus.Checked);

            Response.Redirect("OrderList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _orderManager.UpdateOrder(
                int.Parse(Request.QueryString["OrderID"]),
                int.Parse(txtCustomerID.Text), DateTime.Parse(txtOrderDate.Text), txtStatus.Text,
                decimal.Parse(txtTotalAmount.Text), chkOrderStatus.Checked);

            Response.Redirect("OrderList.aspx");
        }
    }
}
