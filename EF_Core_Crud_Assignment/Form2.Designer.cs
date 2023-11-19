namespace EF_Core_Crud_Assignment
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbEmployee = new ComboBox();
            cmbShipper = new ComboBox();
            dtpOrderDate = new DateTimePicker();
            txtCity = new TextBox();
            btnAddOrUpdate = new Button();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 0;
            label1.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 98);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 1;
            label2.Text = "Order Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 152);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "Ship City";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 204);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Shipper";
            // 
            // cmbEmployee
            // 
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(184, 44);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(170, 28);
            cmbEmployee.TabIndex = 4;
            // 
            // cmbShipper
            // 
            cmbShipper.FormattingEnabled = true;
            cmbShipper.Location = new Point(184, 201);
            cmbShipper.Name = "cmbShipper";
            cmbShipper.Size = new Size(170, 28);
            cmbShipper.TabIndex = 5;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Location = new Point(184, 93);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(170, 27);
            dtpOrderDate.TabIndex = 6;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(184, 149);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(170, 27);
            txtCity.TabIndex = 7;
            // 
            // btnAddOrUpdate
            // 
            btnAddOrUpdate.Location = new Point(184, 249);
            btnAddOrUpdate.Name = "btnAddOrUpdate";
            btnAddOrUpdate.Size = new Size(170, 30);
            btnAddOrUpdate.TabIndex = 8;
            btnAddOrUpdate.Text = "Add";
            btnAddOrUpdate.UseVisualStyleBackColor = true;
            btnAddOrUpdate.Click += btnAddOrUpdate_Click;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 323);
            Controls.Add(btnAddOrUpdate);
            Controls.Add(txtCity);
            Controls.Add(dtpOrderDate);
            Controls.Add(cmbShipper);
            Controls.Add(cmbEmployee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbEmployee;
        private ComboBox cmbShipper;
        private DateTimePicker dtpOrderDate;
        private TextBox txtCity;
        private Button btnAddOrUpdate;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}