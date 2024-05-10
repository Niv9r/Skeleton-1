using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderItemConfirmDelete : System.Web.UI.Page
    {
        private OrderItemManager _orderItemManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderItemManager = new OrderItemManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string orderItemID = Request.QueryString["OrderItemID"];
                txtOrderItemID.Text = orderItemID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int orderItemID = int.Parse(txtOrderItemID.Text);
            _orderItemManager.DeleteOrderItem(orderItemID);
            Response.Redirect("OrderItemList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("OrderItemList.aspx");
        }
    }
}
