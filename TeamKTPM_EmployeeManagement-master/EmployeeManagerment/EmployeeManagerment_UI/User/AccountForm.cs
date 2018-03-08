using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class AccountForm : Form
    {
        private List<string> listBaoVe = new List<string>();
        private List<string> listKeToan = new List<string>();
        private List<string> listIT = new List<string>();
        private List<string> listKinhDoanh = new List<string>();
        private List<string> listNhanSu = new List<string>();
        private string depar = null;
        private string posi = null;
        Guid _id;
        int index;

        private void InsertDataforCombobox()
        {
            listKeToan.Add("Kế toán trưởng");
            listKeToan.Add("Nhân viên");
            listIT.Add("Giám đốc CNTT");
            listIT.Add("Thiết kế viên");
            listIT.Add("Lập trình viên");
            listBaoVe.Add("Tổ trưởng");
            listBaoVe.Add("Bảo vệ");
            listKinhDoanh.Add("Trưởng phòng kinh doanh");
            listKinhDoanh.Add("Nhân viên");
            listNhanSu.Add("Trưởng phòng nhân sự");
            listNhanSu.Add("Nhân viên");
        }

        public AccountForm()
        {
            InitializeComponent();
        }

        private void cbb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_department.SelectedIndex == 0)
            {
                depar = "Kế toán";
                cbb_position.Items.Clear();
                for (int i = 0; i < listKeToan.Count; i++)
                {
                    cbb_position.Items.Add(listKeToan[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 1)
            {
                depar = "Bảo vệ";
                cbb_position.Items.Clear();
                for (int i = 0; i < listBaoVe.Count; i++)
                {
                    cbb_position.Items.Add(listBaoVe[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 2)
            {
                depar = "Công nghệ thông tin";
                cbb_position.Items.Clear();
                for (int i = 0; i < listIT.Count; i++)
                {
                    cbb_position.Items.Add(listIT[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 3)
            {
                depar = "Kinh doanh";
                cbb_position.Items.Clear();
                for (int i = 0; i < listKinhDoanh.Count; i++)
                {
                    cbb_position.Items.Add(listKinhDoanh[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 4)
            {
                depar = "Nhân sự";
                cbb_position.Items.Clear();
                for (int i = 0; i < listNhanSu.Count; i++)
                {
                    cbb_position.Items.Add(listNhanSu[i]);
                }
            }
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            InsertDataforCombobox();
            GetAllData();
        }

        private void btn_addaccount_Click(object sender, EventArgs e)
        {
            AddAccount();
        }

        private void AddAccount()
        {
            PdbAccount account = new PdbAccount();
            try
            {
                account = GetInfomation();
                new Accounts(new EmployeeManagementDBContext()) { }.Create(account);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.InsertSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
            finally
            {
                GetAllData();
            }
        }

        private void GetAllData()
        {
            List<PdbAccount> list = new Accounts(new EmployeeManagementDBContext()) { }.AccountAll();
            grid_listaccount.DataSource = list;
        }

        private PdbAccount GetInfomationforEdit(PdbAccount ac)
        {
            ac.IDStaff = (Guid)cbb_firstname.SelectedValue;
            ac.AccountName = txt_accountname.Text;
            ac.AccountPassword = txt_accountpassword.Text;
            ac.AccountLevel = txt_accountlevel.Text;
            //ac.PdbStaff = new Staffs(new EmployeeManagementDBContext()) { }.GetStaff((Guid)cbb_firstname.SelectedValue);
            if (cb_isactiveaccount.Checked)
            {
                ac.isActive = true;
            }
            else
                ac.isActive = false;
            return ac;
        }

        private PdbAccount GetInfomation()
        {
            PdbAccount ac = new PdbAccount();
            ac.IDAccount = Guid.NewGuid();
            ac.IDStaff = (Guid)cbb_firstname.SelectedValue;
            ac.AccountName = txt_accountname.Text;
            ac.AccountPassword = txt_accountpassword.Text;
            ac.AccountLevel = txt_accountlevel.Text;
            //ac.PdbStaff = new Staffs(new EmployeeManagementDBContext()) { }.GetStaff((Guid)cbb_firstname.SelectedValue);
            if (cb_isactiveaccount.Checked)
            {
                ac.isActive = true;
            }
            else
                ac.isActive = false;
            return ac;
        }

        private void cbb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            posi = cbb_position.Text;
            List<PdbStaff> list = new EmployeeManagement_Service.Service.Module.Staffs(new EmployeeManagementDBContext()) { }.GetStaffwithPosition(posi, depar);
            Dictionary<Guid, string> comboSource = new Dictionary<Guid, string>();
            for (int i = 0; i < list.Count; i++)
            {
                comboSource.Add(list[i].ID_Staff, list[i].FirstName.ToString());
            }
            try
            {
                cbb_firstname.DataSource = new BindingSource(comboSource, null);
                cbb_firstname.DisplayMember = "Value";
                cbb_firstname.ValueMember = "Key";
            }
            catch
            {
                MessageBox.Show("Erorr", "Không có nhân viên nào");
            }
        }

        private void btn_reloadaccount_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btn_deleteaccount_Click(object sender, EventArgs e)
        {
            DeleteAccount();
        }

        private void DeleteAccount()
        {
            try
            {
                new Accounts(new EmployeeManagementDBContext()) { }.Delete(_id);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.DeleteSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileDelete();
            }
            finally
            {
                GetAllData();
            }
        }

        private void grid_listaccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_editaccount_Click(object sender, EventArgs e)
        {
            EditAccount();
        }

        private void EditAccount()
        {
            EmployeeManagementDBContext context = new EmployeeManagementDBContext();
            PdbAccount eve = new Accounts(context) { }.GetAccountwithID(_id);
            eve = GetInfomationforEdit(eve);
            try
            {
                new Accounts(context) { }.Update(eve);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.UpdateSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileEdit();
                throw new Exception();
            }
            finally
            {
                GetAllData();
            }
        }

        private void grid_listaccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = grid_listaccount.CurrentCell.RowIndex;
            _id = (Guid)grid_listaccount.Rows[index].Cells[0].Value;
            txt_accountname.Text = grid_listaccount.Rows[index].Cells[2].Value.ToString().Trim();
            txt_accountpassword.Text = grid_listaccount.Rows[index].Cells[3].Value.ToString().Trim();
            txt_accountlevel.Text = grid_listaccount.Rows[index].Cells[4].Value.ToString().Trim();
            bool check = (bool)grid_listaccount.Rows[index].Cells[5].Value;
            if (check)
            {
                cb_isactiveaccount.Checked = true;
            }
            else
            {
                cb_isactiveaccount.Checked = false;
            }
        }

        private void btn_backaccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
