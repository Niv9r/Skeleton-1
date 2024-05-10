using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderItemViewer : System.Web.UI.Page
    {
        private OrderItemManager _orderItemManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderItemManager = new OrderItemManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string orderItemID = Request.QueryString["OrderItemID"];
                if (!string.IsNullOrEmpty(orderItemID))
                {
                    LoadOrderItem(int.Parse(orderItemID));
                }
            }
        }

        private void LoadOrderItem(int orderItemID)
        {
            var orderItem = _orderItemManager.GetOrderItemByID(orderItemID);
            txtOrderItemID.Text = orderItem.OrderItemID.ToString();
            txtOrderID.Text = orderItem.OrderID.ToString();
            txtProductID.Text = orderItem.ProductID.ToString();
            txtQuantity.Text = orderItem.Quantity.ToString();
            txtUnitPrice.Text = orderItem.UnitPrice.ToString("0.00");
            txtTotalPrice.Text = orderItem.TotalPrice.ToString("0.00");
        }
    }
}
