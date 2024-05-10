using System;
using ClassLibrary;

namespace AdminSystem.Stock
{
    public partial class ProductDataEntry : System.Web.UI.Page
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
            txtProductName.Text = product.ProductName;
            txtCategory.Text = product.Category;
            txtPrice.Text = product.Price.ToString("0.00");
            txtStockQuantity.Text = product.StockQuantity.ToString();
            txtBrand.Text = product.Brand;
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            _productManager.AddProduct(
                txtProductName.Text, txtCategory.Text, decimal.Parse(txtPrice.Text),
                int.Parse(txtStockQuantity.Text), txtBrand.Text);

            Response.Redirect("ProductList.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            _productManager.UpdateProduct(
                int.Parse(Request.QueryString["ProductID"]),
                txtProductName.Text, txtCategory.Text, decimal.Parse(txtPrice.Text),
                int.Parse(txtStockQuantity.Text), txtBrand.Text);

            Response.Redirect("ProductList.aspx");
        }
    }
}
