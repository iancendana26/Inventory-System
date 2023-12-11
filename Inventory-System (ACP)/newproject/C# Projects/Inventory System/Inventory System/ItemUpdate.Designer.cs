namespace Inventory_System
{
    partial class frmItemUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmItemUpdate));
            btnCancel = new Button();
            btnUpdate = new Button();
            txtStocks = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            btnContactSupplier = new Button();
            label3 = new Label();
            cbbSupplier = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(279, 187);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 36);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Wheat;
            btnUpdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(181, 187);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 36);
            btnUpdate.TabIndex = 25;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtStocks
            // 
            txtStocks.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtStocks.Location = new Point(181, 99);
            txtStocks.Name = "txtStocks";
            txtStocks.Size = new Size(236, 33);
            txtStocks.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 102);
            label2.Name = "label2";
            label2.Size = new Size(141, 25);
            label2.TabIndex = 19;
            label2.Text = "Updated Stocks";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(181, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 33);
            txtName.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 66);
            label1.Name = "label1";
            label1.Size = new Size(62, 25);
            label1.TabIndex = 17;
            label1.Text = "Name";
            // 
            // btnContactSupplier
            // 
            btnContactSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnContactSupplier.Location = new Point(12, 12);
            btnContactSupplier.Name = "btnContactSupplier";
            btnContactSupplier.Size = new Size(199, 36);
            btnContactSupplier.TabIndex = 27;
            btnContactSupplier.Text = "Contact Supplier";
            btnContactSupplier.UseVisualStyleBackColor = true;
            btnContactSupplier.Click += btnContactSupplier_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(93, 143);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 28;
            label3.Text = "Supplier";
            // 
            // cbbSupplier
            // 
            cbbSupplier.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSupplier.FormattingEnabled = true;
            cbbSupplier.Location = new Point(181, 140);
            cbbSupplier.Name = "cbbSupplier";
            cbbSupplier.Size = new Size(236, 33);
            cbbSupplier.TabIndex = 29;
            cbbSupplier.DropDown += cbbSupplier_DropDown;
            // 
            // frmItemUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(466, 246);
            ControlBox = false;
            Controls.Add(cbbSupplier);
            Controls.Add(label3);
            Controls.Add(btnContactSupplier);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(txtStocks);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmItemUpdate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Item Update";
            Load += frmItemUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnUpdate;
        private Label label2;
        private Label label1;
        private Button btnContactSupplier;
        private Label label3;
        public ComboBox cbbSupplier;
        public TextBox txtStocks;
        public TextBox txtName;
    }
}