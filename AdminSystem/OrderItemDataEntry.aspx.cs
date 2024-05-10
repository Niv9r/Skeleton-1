using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderItemDataEntry : System.Web.UI.Page
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
            txtOrderID.Text = orderItem.OrderID.ToString();
            txtProductID.Text = orderItem.ProductID.ToString();
            txtQuantity.Text = orderItem.Quantity.ToString();
            txtUnitPrice.Text = orderItem.UnitPrice.ToString("0.00");
            txtTotalPrice.Text = orderItem.TotalPrice.ToString("0.00");
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _orderItemManager.AddOrderItem(
                int.Parse(txtOrderID.Text), int.Parse(txtProductID.Text), int.Parse(txtQuantity.Text),
                decimal.Parse(txtUnitPrice.Text), decimal.Parse(txtTotalPrice.Text));

            Response.Redirect("OrderItemList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _orderItemManager.UpdateOrderItem(
                int.Parse(Request.QueryString["OrderItemID"]),
                int.Parse(txtOrderID.Text), int.Parse(txtProductID.Text), int.Parse(txtQuantity.Text),
                decimal.Parse(txtUnitPrice.Text), decimal.Parse(txtTotalPrice.Text));

            Response.Redirect("OrderItemList.aspx");
        }
    }
}
