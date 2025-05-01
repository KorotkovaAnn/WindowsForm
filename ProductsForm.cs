using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsKorotkova
{
    public partial class ProductsForm : Form
    {
        private readonly ProductRepository _productRepo;

        public ProductsForm()
        {
            InitializeComponent();
            _productRepo = new ProductRepository();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            DataTable products = _productRepo.GetAllProducts();
            if (products != null)
            {
                dataGridView1.DataSource = products;
            }
        }
    }
}

