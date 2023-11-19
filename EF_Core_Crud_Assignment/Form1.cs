
using EF_Core_Crud_Assignment.Models;
using EF_Core_Crud_Assignment.NorthwindContext;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EF_Core_Crud_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        NorthwindContext1 dbContext = new NorthwindContext1();
        private void Form1_Load(object sender, EventArgs e)
        {
            var employees = GetEmployees();
            var shippers = GetShippers();

            foreach (var employee in employees)
            {
                lstEmployees.Items.Add(employee.FirstName);
            }
            foreach (var shipper in shippers)
            {
                lstShippers.Items.Add(shipper.CompanyName);
            }

        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees;
            return employees = dbContext.Employees.ToList();
        }
        public List<Shipper> GetShippers()
        {
            List<Shipper> shippers;
            return shippers = dbContext.Shippers.ToList();
        }

        int employeeIndex;
        int shipperIndex;
        private void lstEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            employeeIndex = lstEmployees.SelectedIndex;
            employeeIndex++;
        }

        private void lstShippers_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipperIndex = lstEmployees.SelectedIndex;
            shipperIndex++;
        }

        private void btnGetOrderList_Click(object sender, EventArgs e)
        {
            //var orders = dbContext.Orders.Select(o => new { o.OrderId, o.OrderDate, o.ShipCity }).ToList();
            //dataGridView1.DataSource = orders;

            if (lstEmployees.SelectedIndex != -1 && lstShippers.SelectedIndex != -1)
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                var orders = dbContext.Orders.Where(o => o.EmployeeId == employeeIndex && o.ShipVia == shipperIndex).Select(o => new { o.OrderId, o.OrderDate, o.ShipCity }).ToList();
                dataGridView1.DataSource = orders;
            }
            else if (lstEmployees.SelectedIndex != -1 && lstShippers.SelectedIndex == -1)
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                var orders = dbContext.Orders.Where(o => o.EmployeeId == employeeIndex).Select(o => new { o.OrderId, o.OrderDate, o.ShipCity }).ToList();
                dataGridView1.DataSource = orders;
            }
            else if (lstEmployees.SelectedIndex == -1 && lstShippers.SelectedIndex != -1)
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                var orders = dbContext.Orders.Where(o => o.ShipVia == shipperIndex).Select(o => new { o.OrderId, o.OrderDate, o.ShipCity }).ToList();
                dataGridView1.DataSource = orders;
            }
            else if (lstEmployees.SelectedIndex == -1 && lstShippers.SelectedIndex == -1)
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                var orders = dbContext.Orders.Select(o => new { o.OrderId, o.OrderDate, o.ShipCity }).ToList();
                dataGridView1.DataSource = orders;
            }


        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Add");
            form2.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2("Update", selectedId);
            form2.ShowDialog();
        }

        int selectedId;
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = e.RowIndex;
            selectedId = (int)dataGridView1[0, index].Value;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Kaydý silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                dbContext.Orders.Remove(dbContext.Orders.FirstOrDefault(o => o.OrderId == selectedId));
                dbContext.SaveChanges();
            }
            else
            {

            }
        }

        private void lstEmployees_MouseDown(object sender, MouseEventArgs e)
        {
            int selectedIndex = lstEmployees.IndexFromPoint(e.Location);
            if (selectedIndex == ListBox.NoMatches)
            {
                lstEmployees.SelectedIndex = -1; 
            }
        }

        private void lstShippers_MouseDown(object sender, MouseEventArgs e)
        {
            int selectedIndex = lstShippers.IndexFromPoint(e.Location);
            if (selectedIndex == ListBox.NoMatches)
            {
                lstShippers.SelectedIndex = -1;
            }
        }
    }
}