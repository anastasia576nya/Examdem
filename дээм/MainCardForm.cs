using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using дээм.Models;


namespace дээм
{
    public partial class MainCardForm : Form
    {
        Ispr2522SafiulinaAdPzLazarevContext context;
        public MainCardForm()
        {
            InitializeComponent();
        }

        private void MainCardForm_Load(object sender, EventArgs e)
        {

        }

        private void MainCardForm_Load_1(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Ispr2522SafiulinaAdPzLazarevContext();

            context.Products.Include(x => x.IdCategoryNavigation).Load();
            context.Products.Include(x => x.IdManufacturerNavigation).Load();
            context.Products.Include(x => x.IdProductNameNavigation).Load();
            context.Products.Include(x => x.IdSupplierNavigation).Load();
            context.Categories.Load();
            context.Manufacturers.Load();
            context.ProductNames.Load();
            context.Suppliers.Load();

            bindingprodSource1.DataSource = context.Products.Local.ToBindingList();
            categorySource.DataSource = context.Categories.Local.ToBindingList();
            manufacturerSource.DataSource = context.Manufacturers.Local.ToBindingList();
            product_nameSource.DataSource = context.ProductNames.Local.ToBindingList();
            SupplierSource.DataSource = context.Suppliers.Local.ToBindingList();

            Populate();
        }

        public void Populate()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in bindingprodSource1)
            {
                if (item is Product p)
                {
                    UserForm card = new UserForm(p);
                    card.Click += (s, ev) => { bindingprodSource1.Position = bindingprodSource1.IndexOf(p); };
                    flowLayoutPanel1.Controls.Add(card);
                }
            }
        }
    }
}
