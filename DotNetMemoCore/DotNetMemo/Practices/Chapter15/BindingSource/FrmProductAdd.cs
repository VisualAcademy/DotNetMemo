using System;
using System.Windows.Forms;

namespace DotNetMemo
{
    public partial class FrmProductAdd : Form
    {
        private Category _category;

        public FrmProductAdd(Category category)
        {
            InitializeComponent();

            _category = category;
            CategoryTextBox.Text = _category.CategoryName;
        }

        public Product Product
        {
            get
            {
                var price = Decimal.Parse(PriceTextBox.Text);
                var stock = int.Parse(StockTextBox.Text);
                var onOrder = int.Parse(OrderTextBox.Text);

                var result = new Product(0, NameTextBox.Text, _category.CategoryID, QuantityTextBox.Text, price, stock, onOrder, DiscontinuedCheckBox.Checked);
                return result;
            }
        }
    }
}
