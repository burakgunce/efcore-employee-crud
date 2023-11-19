namespace EF_Core_Crud_Assignment
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
            btnGetOrderList = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lstEmployees = new ListBox();
            lstShippers = new ListBox();
            dataGridView1 = new DataGridView();
            sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetOrderList
            // 
            btnGetOrderList.Location = new Point(33, 33);
            btnGetOrderList.Name = "btnGetOrderList";
            btnGetOrderList.Size = new Size(111, 43);
            btnGetOrderList.TabIndex = 0;
            btnGetOrderList.Text = "Get Order List";
            btnGetOrderList.UseVisualStyleBackColor = true;
            btnGetOrderList.Click += btnGetOrderList_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(232, 33);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(111, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(411, 33);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(111, 43);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(583, 33);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 43);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 20;
            lstEmployees.Location = new Point(35, 100);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(111, 204);
            lstEmployees.TabIndex = 4;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            lstEmployees.MouseDown += lstEmployees_MouseDown;
            // 
            // lstShippers
            // 
            lstShippers.FormattingEnabled = true;
            lstShippers.ItemHeight = 20;
            lstShippers.Location = new Point(35, 322);
            lstShippers.Name = "lstShippers";
            lstShippers.Size = new Size(109, 104);
            lstShippers.TabIndex = 5;
            lstShippers.SelectedIndexChanged += lstShippers_SelectedIndexChanged;
            lstShippers.MouseDown += lstShippers_MouseDown;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(233, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(461, 324);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // sqlCommandBuilder1
            // 
            sqlCommandBuilder1.DataAdapter = null;
            sqlCommandBuilder1.QuotePrefix = "[";
            sqlCommandBuilder1.QuoteSuffix = "]";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(lstShippers);
            Controls.Add(lstEmployees);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnGetOrderList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGetOrderList;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ListBox lstEmployees;
        private ListBox lstShippers;
        private DataGridView dataGridView1;
        private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
    }
}