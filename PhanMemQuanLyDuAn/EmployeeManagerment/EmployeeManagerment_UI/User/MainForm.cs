using EmployeeManagement_Service.ModelDBContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btn_addeditemployee_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.EmployeeForm employeeform = new EmployeeForm();
            this.Visible = false;
            employeeform.ShowDialog();
            this.Visible = true;
        }

        private void btn_addeditsalary_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.ContractForm salary = new ContractForm();
            this.Visible = false;
            salary.ShowDialog();
            this.Visible = true;
        }

        private void btn_accountmanagement_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.AccountForm contract = new AccountForm();
            this.Visible = false;
            contract.ShowDialog();
            this.Visible = true;
        }

        private void btn_addeditevent_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.EventForm eventform = new EventForm();
            this.Visible = false;
            eventform.ShowDialog();
            this.Visible = true;
        }

        private void btn_reload_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void GetAllData()
        {
            try
            {
                grid_listemployee.DataSource = new EmployeeManagement_Service.Service.Module.Staffs(new EmployeeManagementDBContext()) { }.GetAllStaff();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void bnt_supplier_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            EmployeeManagerment_UI.User.FeedbackForm feedback = new FeedbackForm();
            this.Visible = false;
            feedback.ShowDialog();
            this.Visible = true;
        }
    }
}
