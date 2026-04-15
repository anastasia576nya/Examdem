namespace дээм
{
    partial class MainCardForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            bindingprodSource1 = new BindingSource(components);
            categorySource = new BindingSource(components);
            manufacturerSource = new BindingSource(components);
            product_nameSource = new BindingSource(components);
            SupplierSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingprodSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)categorySource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)product_nameSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SupplierSource).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(45, 74);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 323);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // bindingprodSource1
            // 
            bindingprodSource1.DataSource = typeof(Models.Product);
            // 
            // categorySource
            // 
            categorySource.DataSource = typeof(Models.Category);
            // 
            // manufacturerSource
            // 
            manufacturerSource.DataSource = typeof(Models.Manufacturer);
            // 
            // product_nameSource
            // 
            product_nameSource.DataSource = typeof(Models.ProductName);
            // 
            // SupplierSource
            // 
            SupplierSource.DataSource = typeof(Models.Supplier);
            // 
            // MainCardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flowLayoutPanel1);
            Name = "MainCardForm";
            Load += MainCardForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)bindingprodSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)categorySource).EndInit();
            ((System.ComponentModel.ISupportInitialize)manufacturerSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)product_nameSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)SupplierSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public BindingSource bindingprodSource1;
        public BindingSource categorySource;
        public BindingSource manufacturerSource;
        public BindingSource product_nameSource;
        public BindingSource SupplierSource;
        public FlowLayoutPanel flowLayoutPanel1;
    }
}