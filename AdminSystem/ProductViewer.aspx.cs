using System;
using ClassLibrary;

namespace AdminSystem.Stock
{
    public partial class ProductViewer : System.Web.UI.Page
    {
        private ProductManager _productManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _productManager = new ProductManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string productID = Request.QueryString["ProductID"];
                if (!string.IsNullOrEmpty(productID))
                {
                    LoadProduct(int.Parse(productID));
                }
            }
        }

        private void LoadProduct(int productID)
        {
            var product = _productManager.GetProductByID(productID);
            txtProductID.Text = product.ProductID.ToString();
            txtProductName.Text = product.ProductName;
            txtCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString("0.00");
            txtStockQuantity.Text = product.StockQuantity.ToString();
            txtBrand.Text = product.Brand;
        }
    }
}
