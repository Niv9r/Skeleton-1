using System;
using ClassLibrary;

namespace AdminSystem.Stock
{
    public partial class ProductList : System.Web.UI.Page
    {
        private ProductManager _productManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _productManager = new ProductManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                LoadProductList();
            }
        }

        private void LoadProductList()
        {
            GridViewProduct.DataSource = _productManager.GetAllProducts();
            GridViewProduct.DataBind();
        }
    }
}
