using Microsoft.EntityFrameworkCore;
using дээм.Models;

namespace дээм
{
    public partial class Form1 : Form
    {
        Ispr2522SafiulinaAdPzLazarevContext context;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            context = new Ispr2522SafiulinaAdPzLazarevContext();
            context.Products.Include(x => x.IdCategoryNavigation).Include(x => x.IdManufacturerNavigation).Include(x => x.IdProductNameNavigation).Include(x => x.IdSupplierNavigation).Load();
            context.Categories.Load();
            context.Manufacturers.Load();
            context.ProductNames.Load();
            context.Suppliers.Load();

            context.Database.EnsureCreated();

            bindingSource1.DataSource = context.Products.Local.ToBindingList();
            PrnamebindingSource2.DataSource = context.ProductNames.Local.ToBindingList();
            supbindingSource2.DataSource = context.Suppliers.Local.ToBindingList();
            manbindingSource2.DataSource = context.Manufacturers.Local.ToBindingList();
            catbindingSource2.DataSource = context.Categories.Local.ToBindingList();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            context.SaveChanges();
            dataGridView1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var product = textBox1.Text;
            var category = textBox2.Text;

            context.ChangeTracker.Clear();
            context.Products
                .Include(x => x.IdProductNameNavigation)
                .Include(x => x.IdCategoryNavigation)
                .Where(x => x.IdProductNameNavigation.ProductName1.Contains(product) &&
                    x.IdCategoryNavigation.CategoryName.Contains(category))
                .Load();
            bindingSource1.DataSource = context.Products.Local.ToBindingList();
            catbindingSource2.DataSource = context.Categories.Local.ToBindingList();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // 1. Создаем чистый объект продукта
            var newProduct = new Product();

            newProduct.IdProductName = context.ProductNames.First().IdProductName;
            newProduct.IdCategory = context.Categories.First().IdCategory;
            newProduct.IdManufacturer = context.Manufacturers.First().IdManufacturer;
            newProduct.IdSupplier = context.Suppliers.First().IdSupplier;

            // 2. Инициализируем обязательные поля дефолтными значениями, 
            // чтобы база не выкинула ошибку NOT NULL
            newProduct.Article = "";
            newProduct.Unit = "шт.";
            newProduct.Description = "-";
            newProduct.Photo = "";
            newProduct.Price = 0;
            newProduct.Count = 0;
            newProduct.Discount = 0;

            var form = new EditForm();

            // Прокидываем справочники
            form.categoryBindingSource.DataSource = catbindingSource2.DataSource;
            form.manbindingSource1.DataSource = manbindingSource2.DataSource;
            form.productNameBindingSource.DataSource = PrnamebindingSource2.DataSource;
            form.supplierBindingSource.DataSource = supbindingSource2.DataSource;

            // Привязываем наш новый объект к BindingSource формы
            form.productBindingSource.DataSource = newProduct;

            // 3. Ждем, пока пользователь заполнит форму и нажмет "Сохранить" (DialogResult.OK)
            if (form.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Явно добавляем объект в контекст EF
                    context.Products.Add(newProduct);

                    // Сохраняем в физическую БД
                    context.SaveChanges();

                    // Обновляем список на экране
                    bindingSource1.DataSource = context.Products.Local.ToBindingList();
                    dataGridView1.Refresh();

                    MessageBox.Show("Данные успешно сохранены в базу!");
                }
                catch (Exception ex)
                {
                    // Если база не приняла данные — мы увидим реальную причину
                    string inner = ex.InnerException?.Message ?? ex.Message;
                    MessageBox.Show($"Ошибка сохранения: {inner}");

                    // Удаляем объект из памяти контекста, чтобы он не мешался
                    context.Entry(newProduct).State = EntityState.Detached;
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null) return;

            var form = new EditForm();
            form.categoryBindingSource.DataSource = catbindingSource2.DataSource;
            form.manbindingSource1.DataSource = manbindingSource2.DataSource;
            form.productNameBindingSource.DataSource = PrnamebindingSource2.DataSource;
            form.supplierBindingSource.DataSource = supbindingSource2.DataSource;

            // Редактируем текущий объект
            form.productBindingSource.DataSource = bindingSource1.Current;

            if (form.ShowDialog() == DialogResult.OK)
            {
                bindingSource1.EndEdit();
                context.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {

                bindingSource1.RemoveCurrent();
                context.SaveChanges();
                dataGridView1.Refresh();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";

            // 1. Очищаем старое
            context.ChangeTracker.Clear();

            // 2. Сначала загружаем справочники (категории, производителей и т.д.)
            // Это важно, чтобы ComboBox в таблице не ломались!
            context.Categories.Load();
            context.Manufacturers.Load();
            context.Suppliers.Load();
            context.ProductNames.Load();

            // 3. Теперь загружаем сами продукты со всеми связями
            context.Products
                .Include(x => x.IdProductNameNavigation)
                .Include(x => x.IdCategoryNavigation)
                .Include(x => x.IdManufacturerNavigation)
                .Include(x => x.IdSupplierNavigation)
                .Load();

            // 4. Обновляем привязки
            bindingSource1.DataSource = context.Products.Local.ToBindingList();

            // 5. Перерисовываем таблицу
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

