namespace дээм
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewComboBoxColumn();
            PrnamebindingSource2 = new BindingSource(components);
            countUnitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            CountUnit = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewComboBoxColumn();
            supbindingSource2 = new BindingSource(components);
            dataGridViewTextBoxColumn7 = new DataGridViewComboBoxColumn();
            manbindingSource2 = new BindingSource(components);
            dataGridViewTextBoxColumn8 = new DataGridViewComboBoxColumn();
            catbindingSource2 = new BindingSource(components);
            dataGridViewTextBoxColumn9 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn10 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn11 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn12 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn13 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn14 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn15 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn16 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn17 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PrnamebindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource2).BeginInit();
            SuspendLayout();
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Product);
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, countUnitDataGridViewTextBoxColumn, CountUnit, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8, dataGridViewTextBoxColumn9, dataGridViewTextBoxColumn10, dataGridViewTextBoxColumn11, dataGridViewTextBoxColumn12, dataGridViewTextBoxColumn13, dataGridViewTextBoxColumn14, dataGridViewTextBoxColumn15, dataGridViewTextBoxColumn16, dataGridViewTextBoxColumn17 });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(23, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1239, 276);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "IdProduct";
            dataGridViewTextBoxColumn1.HeaderText = "IdProduct";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Resizable = DataGridViewTriState.True;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.DataPropertyName = "Article";
            dataGridViewTextBoxColumn2.HeaderText = "Article";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.DataPropertyName = "IdProductName";
            dataGridViewTextBoxColumn3.DataSource = PrnamebindingSource2;
            dataGridViewTextBoxColumn3.DisplayMember = "ProductName1";
            dataGridViewTextBoxColumn3.HeaderText = "IdProductName";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn3.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn3.ValueMember = "IdProductName";
            // 
            // PrnamebindingSource2
            // 
            PrnamebindingSource2.DataSource = typeof(Models.ProductName);
            // 
            // countUnitDataGridViewTextBoxColumn
            // 
            countUnitDataGridViewTextBoxColumn.DataPropertyName = "CountUnit";
            countUnitDataGridViewTextBoxColumn.HeaderText = "CountUnit";
            countUnitDataGridViewTextBoxColumn.Name = "countUnitDataGridViewTextBoxColumn";
            countUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CountUnit
            // 
            CountUnit.DataPropertyName = "CountUnit";
            CountUnit.HeaderText = "CountUnit";
            CountUnit.Name = "CountUnit";
            CountUnit.ReadOnly = true;
            CountUnit.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.DataPropertyName = "Unit";
            dataGridViewTextBoxColumn4.HeaderText = "Unit";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.DataPropertyName = "Price";
            dataGridViewTextBoxColumn5.HeaderText = "Price";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.DataPropertyName = "IdSupplier";
            dataGridViewTextBoxColumn6.DataSource = supbindingSource2;
            dataGridViewTextBoxColumn6.DisplayMember = "SupplierName";
            dataGridViewTextBoxColumn6.HeaderText = "IdSupplier";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn6.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn6.ValueMember = "IdSupplier";
            // 
            // supbindingSource2
            // 
            supbindingSource2.DataSource = typeof(Models.Supplier);
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.DataPropertyName = "IdManufacturer";
            dataGridViewTextBoxColumn7.DataSource = manbindingSource2;
            dataGridViewTextBoxColumn7.DisplayMember = "ManufacturerName";
            dataGridViewTextBoxColumn7.HeaderText = "IdManufacturer";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn7.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn7.ValueMember = "IdManufacturer";
            // 
            // manbindingSource2
            // 
            manbindingSource2.DataSource = typeof(Models.Manufacturer);
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.DataPropertyName = "IdCategory";
            dataGridViewTextBoxColumn8.DataSource = catbindingSource2;
            dataGridViewTextBoxColumn8.DisplayMember = "CategoryName";
            dataGridViewTextBoxColumn8.HeaderText = "IdCategory";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.Resizable = DataGridViewTriState.True;
            dataGridViewTextBoxColumn8.SortMode = DataGridViewColumnSortMode.Automatic;
            dataGridViewTextBoxColumn8.ValueMember = "IdCategory";
            // 
            // catbindingSource2
            // 
            catbindingSource2.DataSource = typeof(Models.Category);
            // 
            // dataGridViewTextBoxColumn9
            // 
            dataGridViewTextBoxColumn9.DataPropertyName = "Discount";
            dataGridViewTextBoxColumn9.HeaderText = "Discount";
            dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            dataGridViewTextBoxColumn10.DataPropertyName = "Count";
            dataGridViewTextBoxColumn10.HeaderText = "Count";
            dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            dataGridViewTextBoxColumn10.Visible = false;
            // 
            // dataGridViewTextBoxColumn11
            // 
            dataGridViewTextBoxColumn11.DataPropertyName = "Description";
            dataGridViewTextBoxColumn11.HeaderText = "Description";
            dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            dataGridViewTextBoxColumn12.DataPropertyName = "Photo";
            dataGridViewTextBoxColumn12.HeaderText = "Photo";
            dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            dataGridViewTextBoxColumn13.DataPropertyName = "IdCategoryNavigation";
            dataGridViewTextBoxColumn13.HeaderText = "IdCategoryNavigation";
            dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            dataGridViewTextBoxColumn13.Visible = false;
            // 
            // dataGridViewTextBoxColumn14
            // 
            dataGridViewTextBoxColumn14.DataPropertyName = "IdManufacturerNavigation";
            dataGridViewTextBoxColumn14.HeaderText = "IdManufacturerNavigation";
            dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            dataGridViewTextBoxColumn14.Visible = false;
            // 
            // dataGridViewTextBoxColumn15
            // 
            dataGridViewTextBoxColumn15.DataPropertyName = "IdProductNameNavigation";
            dataGridViewTextBoxColumn15.HeaderText = "IdProductNameNavigation";
            dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            dataGridViewTextBoxColumn15.Visible = false;
            // 
            // dataGridViewTextBoxColumn16
            // 
            dataGridViewTextBoxColumn16.DataPropertyName = "IdSupplierNavigation";
            dataGridViewTextBoxColumn16.HeaderText = "IdSupplierNavigation";
            dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            dataGridViewTextBoxColumn16.Visible = false;
            // 
            // dataGridViewTextBoxColumn17
            // 
            dataGridViewTextBoxColumn17.DataPropertyName = "OrdersProducts";
            dataGridViewTextBoxColumn17.HeaderText = "OrdersProducts";
            dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            dataGridViewTextBoxColumn17.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(49, 386);
            button1.Name = "button1";
            button1.Size = new Size(84, 41);
            button1.TabIndex = 1;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(172, 395);
            button2.Name = "button2";
            button2.Size = new Size(132, 32);
            button2.TabIndex = 2;
            button2.Text = "добавление";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(357, 388);
            button3.Name = "button3";
            button3.Size = new Size(115, 39);
            button3.TabIndex = 3;
            button3.Text = "удаление";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(517, 388);
            button4.Name = "button4";
            button4.Size = new Size(125, 39);
            button4.TabIndex = 4;
            button4.Text = "редактирование";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 5;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(441, 31);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 34);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 7;
            label1.Text = "название продукта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(583, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 8;
            label2.Text = "категория продукта";
            // 
            // button5
            // 
            button5.Location = new Point(755, 26);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 9;
            button5.Text = "поиск";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(895, 24);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 10;
            button6.Text = "сброс";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)PrnamebindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)supbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)catbindingSource2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public BindingSource bindingSource1;
        private DataGridView dataGridView1;
        public BindingSource PrnamebindingSource2;
        public BindingSource supbindingSource2;
        public BindingSource manbindingSource2;
        public BindingSource catbindingSource2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button5;
        private DataGridViewTextBoxColumn idProductDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn articleDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idProductNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idSupplierDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idManufacturerDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn idCategoryDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idCategoryNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idManufacturerNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idProductNameNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idSupplierNavigationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ordersProductsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn countUnitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn CountUnit;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private Button button6;
    }
}
