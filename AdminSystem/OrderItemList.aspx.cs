using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderItemList : System.Web.UI.Page
    {
        private OrderItemManager _orderItemManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderItemManager = new OrderItemManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadOrderItemList();
            }
        }

        private void LoadOrderItemList()
        {
            GridViewOrderItem.DataSource = _orderItemManager.GetAllOrderItems();
            GridViewOrderItem.DataBind();
        }
    }
}
