using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using дээм.Models;

namespace дээм
{
    public partial class UserForm : UserControl
    {
        public UserForm(Product product)
        {
            InitializeComponent();

            label1.Text = product.IdProductNameNavigation?.ProductName1;

            label2.Text = $"Цена: {product.Price:C2}";

            label3.Text = $"Описание: {product.Description}";

            label4.Text = $"Скидка: {product.Discount}%";

            label5.Text = $"Производитель: {product.IdManufacturerNavigation.ManufacturerName}";

            label6.Text = $"Осталось: {product.Count} Шт";

            label7.Text = $"Поставщик: {product.IdSupplierNavigation.SupplierName}";

            if (!string.IsNullOrEmpty(product.Photo))
            {
                try
                {
                    pictureBox1.ImageLocation = product.Photo;
                }
                catch
                {
                }
            }
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
