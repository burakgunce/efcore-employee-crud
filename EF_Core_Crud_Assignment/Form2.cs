using EF_Core_Crud_Assignment.Models;
using EF_Core_Crud_Assignment.NorthwindContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Core_Crud_Assignment
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string _mode = "";
        public int _id;
        public Form2(string mode) : this()
        {
            _mode = mode;
            UpdateButtonText();
        }
        public Form2(string mode, int id) : this()
        {
            _mode = mode;
            _id = id;
            UpdateButtonText();
            
        }

        private void UpdateButtonText()
        {
            if (_mode == "Add")
            {
                btnAddOrUpdate.Text = "Add";
            }
            else if (_mode == "Update")
            {
                btnAddOrUpdate.Text = "Update";
            }
        }

        public void FillAreas()
        {
            NorthwindContext1 dbContext = new NorthwindContext1();
            var order = dbContext.Orders.FirstOrDefault(o => o.OrderId == _id);
            cmbEmployee.SelectedIndex = (int)order.EmployeeId - 1;
            dtpOrderDate.Text = order.OrderDate.ToString();
            txtCity.Text = order.ShipCity;
            cmbShipper.SelectedIndex = (int)order.ShipVia - 1;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (_mode == "Add")
            {
                int employeeIndex;
                int shipIndex;
                NorthwindContext1 dbContext = new NorthwindContext1();
                Order order = new Order();
                employeeIndex = cmbEmployee.SelectedIndex + 1;
                order.EmployeeId = employeeIndex;
                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtCity.Text;
                shipIndex = cmbShipper.SelectedIndex + 1;
                order.ShipVia = shipIndex;
                dbContext.Orders.Add(order);
                dbContext.SaveChanges();
            }
            else if (_mode == "Update")
            {
                NorthwindContext1 dbContext = new NorthwindContext1();
                var order = dbContext.Orders.FirstOrDefault(o => o.OrderId == _id);

                order.EmployeeId = cmbEmployee.SelectedIndex + 1;
                order.OrderDate = dtpOrderDate.Value;
                order.ShipCity = txtCity.Text;
                order.ShipVia = cmbShipper.SelectedIndex + 1;
                dbContext.Orders.Update(order);
                dbContext.SaveChanges();
            }

            this.Close();


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NorthwindContext1 dbContext = new NorthwindContext1();
            List<Employee> employees = dbContext.Employees.ToList();
            List<Shipper> shippers = dbContext.Shippers.ToList();

            foreach (var employee in employees)
            {
                cmbEmployee.Items.Add(employee.FirstName);
            }
            foreach (var ship in shippers)
            {
                cmbShipper.Items.Add(ship.CompanyName);
            }
            if (_mode == "Update")
            {
                FillAreas();
            }
            

        }
    }
}
