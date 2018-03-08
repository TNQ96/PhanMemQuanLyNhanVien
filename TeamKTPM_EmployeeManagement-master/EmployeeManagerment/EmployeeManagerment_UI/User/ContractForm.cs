using System;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Basic;
using EmployeeManagement_Service.Service.Module;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EmployeeManagerment_UI.User
{
    public partial class ContractForm : Form
    {
        List<string> listBaoVe = new List<string>();
        List<string> listKeToan = new List<string>();
        List<string> listIT = new List<string>();
        List<string> listKinhDoanh = new List<string>();
        List<string> listNhanSu = new List<string>();
        string depar = null;
        string posi = null;
        Guid _id;


        public ContractForm()
        {
            InitializeComponent();
        }

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

        private void btn_backcontract_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PdbContract GetInformationforEdit(PdbContract con)
        {
            con.IDStaff = (Guid)cbb_firstname.SelectedValue;
            con.PayForms = txt_payforms.Text;
            con.SignDate = dtp_signdate.Value;
            con.StartDate = dtp_startdate.Value;
            con.EndDate = dtp_enddate.Value;
            con.ContractType = txt_contracttype.Text;
            con.ContractDescription = rtxt_contractdescription.Text;
            return con;
        }

        private PdbContract GetInformation()
        {
            PdbContract con = new PdbContract();
            con.IDContract = Guid.NewGuid();
            con.IDStaff = (Guid)cbb_firstname.SelectedValue;
            con.PayForms = txt_payforms.Text;
            con.SignDate = dtp_signdate.Value;
            con.StartDate = dtp_startdate.Value;
            con.EndDate = dtp_enddate.Value;
            con.ContractType = txt_contracttype.Text;
            con.ContractDescription = rtxt_contractdescription.Text;
            return con;
        }

        private void GetAllData()
        {
            try
            {
                grid_listcontract.DataSource = new EmployeeManagement_Service.Service.Module.Contracts(new EmployeeManagementDBContext()) { }.ContractsAll();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void btn_reloadcontract_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void ContractForm_Load(object sender, EventArgs e)
        {
            GetAllData();
            InsertDataforCombobox();
        }

        private void btn_addcontract_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void Add()
        {
            PdbContract con = new PdbContract();
            try
            {
                con = GetInformation();
                new EmployeeManagement_Service.Service.Module.Contracts(new EmployeeManagementDBContext()) { }.Add(con);
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

        private void EditContract()
        {
            EmployeeManagementDBContext context = new EmployeeManagementDBContext();
            PdbContract eve = new Contracts(context) { }.GetContract(_id);
            eve = GetInformationforEdit(eve);
            try
            {
                new Contracts(context) { }.Edit(eve);
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

        private void grid_listcontract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = grid_listcontract.CurrentCell.RowIndex;
            _id = (Guid)grid_listcontract.Rows[index].Cells[0].Value;
            txt_contracttype.Text = grid_listcontract.Rows[index].Cells[2].Value.ToString().Trim();
            txt_payforms.Text = grid_listcontract.Rows[index].Cells[4].Value.ToString().Trim();
            dtp_startdate.Value = (DateTime)grid_listcontract.Rows[index].Cells[5].Value;
            dtp_enddate.Value = (DateTime)grid_listcontract.Rows[index].Cells[6].Value;
            dtp_signdate.Value = (DateTime)grid_listcontract.Rows[index].Cells[7].Value;
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

        private void btn_deletecontract_Click(object sender, EventArgs e)
        {
            DeleteContract(_id);
        }

        private void DeleteContract(Guid _id)
        {
            try
            {
                new Contracts(new EmployeeManagementDBContext()) { }.Delete(_id);
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

        private void btn_editcontract_Click(object sender, EventArgs e)
        {
            EditContract();
        }
    }
}
