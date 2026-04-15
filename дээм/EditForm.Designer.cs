namespace дээм
{
    partial class EditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            textBox2 = new TextBox();
            productBindingSource = new BindingSource(components);
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            productNameBindingSource = new BindingSource(components);
            comboBox2 = new ComboBox();
            supplierBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            comboBox3 = new ComboBox();
            manbindingSource1 = new BindingSource(components);
            comboBox4 = new ComboBox();
            categoryBindingSource = new BindingSource(components);
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productNameBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource, "Article", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox2.Location = new Point(68, 74);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(113, 23);
            textBox2.TabIndex = 1;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // textBox3
            // 
            textBox3.DataBindings.Add(new Binding("Text", productBindingSource, "CountUnit", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox3.Location = new Point(63, 153);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.DataBindings.Add(new Binding("Text", productBindingSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox4.Location = new Point(63, 194);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.DataBindings.Add(new Binding("Text", productBindingSource, "Discount", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox5.Location = new Point(72, 360);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(109, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.DataBindings.Add(new Binding("Text", productBindingSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged));
            textBox6.Location = new Point(72, 402);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(116, 23);
            textBox6.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.DataBindings.Add(new Binding("SelectedValue", productNameBindingSource, "IdProductName", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox1.DataSource = productNameBindingSource;
            comboBox1.DisplayMember = "ProductName1";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(63, 113);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(118, 23);
            comboBox1.TabIndex = 6;
            comboBox1.ValueMember = "IdProductName";
            // 
            // productNameBindingSource
            // 
            productNameBindingSource.DataSource = typeof(Models.ProductName);
            // 
            // comboBox2
            // 
            comboBox2.DataBindings.Add(new Binding("SelectedValue", supplierBindingSource, "IdSupplier", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox2.DataSource = supplierBindingSource;
            comboBox2.DisplayMember = "SupplierName";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(72, 234);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(109, 23);
            comboBox2.TabIndex = 7;
            comboBox2.ValueMember = "IdSupplier";
            // 
            // supplierBindingSource
            // 
            supplierBindingSource.DataSource = typeof(Models.Supplier);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 82);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 8;
            label1.Text = "артикул";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 116);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 9;
            label2.Text = "название";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(193, 155);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 11;
            label4.Text = "колво";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(204, 199);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "цена";
            // 
            // comboBox3
            // 
            comboBox3.DataBindings.Add(new Binding("SelectedValue", manbindingSource1, "IdManufacturer", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox3.DataSource = manbindingSource1;
            comboBox3.DisplayMember = "ManufacturerName";
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(72, 274);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(109, 23);
            comboBox3.TabIndex = 13;
            comboBox3.ValueMember = "IdManufacturer";
            // 
            // manbindingSource1
            // 
            manbindingSource1.DataSource = typeof(Models.Manufacturer);
            // 
            // comboBox4
            // 
            comboBox4.DataBindings.Add(new Binding("SelectedValue", categoryBindingSource, "IdCategory", true, DataSourceUpdateMode.OnPropertyChanged));
            comboBox4.DataSource = categoryBindingSource;
            comboBox4.DisplayMember = "CategoryName";
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(72, 314);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(109, 23);
            comboBox4.TabIndex = 14;
            comboBox4.ValueMember = "IdCategory";
            // 
            // categoryBindingSource
            // 
            categoryBindingSource.DataSource = typeof(Models.Category);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(192, 240);
            label6.Name = "label6";
            label6.Size = new Size(68, 15);
            label6.TabIndex = 15;
            label6.Text = "поставщик";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 282);
            label7.Name = "label7";
            label7.Size = new Size(90, 15);
            label7.TabIndex = 16;
            label7.Text = "производитель";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 321);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 17;
            label8.Text = "категория";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(202, 363);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 18;
            label9.Text = "скидка";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(194, 406);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 19;
            label10.Text = "описание";
            // 
            // button1
            // 
            button1.Location = new Point(63, 463);
            button1.Name = "button1";
            button1.Size = new Size(105, 37);
            button1.TabIndex = 20;
            button1.Text = "сохранить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 532);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productNameBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)manbindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        public BindingSource productBindingSource;
        public BindingSource supplierBindingSource;
        public BindingSource productNameBindingSource;
        public BindingSource manbindingSource1;
        public BindingSource categoryBindingSource;
    }
}