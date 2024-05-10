using System;
using ClassLibrary;

namespace AdminSystem.Stock
{
    public partial class ProductConfirmDelete : System.Web.UI.Page
    {
        private ProductManager _productManager;

        protected void Page_Load(object sender, EventArgs e)
        {
            _productManager = new ProductManager(clsDataConnection.ConnectionString);

            if (!IsPostBack)
            {
                string productID = Request.QueryString["ProductID"];
                txtProductID.Text = productID;
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(txtProductID.Text);
            _productManager.DeleteProduct(productID);
            Response.Redirect("ProductList.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProductList.aspx");
        }
    }
}
