namespace Inventory_System
{
    partial class frmItemAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemAdd));
            txtName = new TextBox();
            label1 = new Label();
            txtStocks = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cbbSupplier = new ComboBox();
            itemAddedEventArgsBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)itemAddedEventArgsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(143, 20);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 33);
            txtName.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 23);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 5;
            label1.Text = "Item Name";
            // 
            // txtStocks
            // 
            txtStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStocks.Location = new Point(143, 59);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(236, 33);
            txtStocks.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 62);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 7;
            label2.Text = "Stocks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(55, 101);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 9;
            label3.Text = "Supplier";
            // 
            // cbbSupplier
            // 
            cbbSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSupplier.FormattingEnabled = true;
            cbbSupplier.Location = new Point(143, 101);
            cbbSupplier.Name = "cbbSupplier";
            cbbSupplier.Size = new Size(236, 33);
            cbbSupplier.TabIndex = 11;
            cbbSupplier.DropDown += cbbSupplier_DropDown;
            cbbSupplier.SelectedIndexChanged += cbbSupplier_SelectedIndexChanged;
            // 
            // itemAddedEventArgsBindingSource
            // 
            itemAddedEventArgsBindingSource.DataSource = typeof(ItemAddedEventArgs);
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Wheat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(143, 157);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 36);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(241, 157);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 36);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmItemAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(458, 205);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(cbbSupplier);
            Controls.Add(label3);
            Controls.Add(txtStocks);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmItemAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Add";
            Load += frmItemAdd_Load;
            ((System.ComponentModel.ISupportInitialize)itemAddedEventArgsBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAdd;
        private Button btnCancel;
        public TextBox txtName;
        public TextBox txtStocks;
        public ComboBox cbbSupplier;
        private BindingSource itemAddedEventArgsBindingSource;
    }
}