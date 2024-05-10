using System;
using ClassLibrary;

namespace AdminSystem.Order
{
    public partial class OrderList : System.Web.UI.Page
    {
        private OrderManager _orderManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _orderManager = new OrderManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadOrderList();
            }
        }

        private void LoadOrderList()
        {
            GridViewOrder.DataSource = _orderManager.GetAllOrders();
            GridViewOrder.DataBind();
        }
    }
}
