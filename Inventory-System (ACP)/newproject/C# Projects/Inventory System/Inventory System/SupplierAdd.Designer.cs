namespace Inventory_System
{
    partial class frmSupplierAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSupplierAdd));
            txtName = new TextBox();
            label1 = new Label();
            txtAddress = new TextBox();
            label2 = new Label();
            txtContact = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            btnCancel = new Button();
            btnAdd = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(199, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(236, 33);
            txtName.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Wheat;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 15);
            label1.Name = "label1";
            label1.Size = new Size(137, 25);
            label1.TabIndex = 7;
            label1.Text = "Supplier Name";
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(199, 51);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(236, 33);
            txtAddress.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Wheat;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(114, 54);
            label2.Name = "label2";
            label2.Size = new Size(79, 25);
            label2.TabIndex = 9;
            label2.Text = "Address";
            // 
            // txtContact
            // 
            txtContact.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContact.Location = new Point(199, 90);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(236, 33);
            txtContact.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 93);
            label3.Name = "label3";
            label3.Size = new Size(151, 25);
            label3.TabIndex = 11;
            label3.Text = "Contact Number";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(199, 129);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(236, 33);
            txtEmail.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(135, 132);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 13;
            label4.Text = "Email";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Wheat;
            btnCancel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(375, 191);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(92, 36);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Wheat;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(265, 191);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(92, 36);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // frmSupplierAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(501, 239);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtContact);
            Controls.Add(label3);
            Controls.Add(txtAddress);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSupplierAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Supplier Add";
            Load += frmSupplierAdd_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private TextBox txtAddress;
        private Label label2;
        private TextBox txtContact;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private Button btnCancel;
        private Button btnAdd;
    }
}