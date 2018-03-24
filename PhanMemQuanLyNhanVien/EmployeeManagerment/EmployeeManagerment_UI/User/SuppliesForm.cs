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
    public partial class SuppliesForm : Form
    {
        List<string> listBaoVe = new List<string>();
        List<string> listKeToan = new List<string>();
        List<string> listIT = new List<string>();
        List<string> listKinhDoanh = new List<string>();
        List<string> listNhanSu = new List<string>();
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

        public SuppliesForm()
        {
            InitializeComponent();
        }

        private void GetAllData()
        {
            try
            {
                grid_listsupplies.DataSource = new EmployeeManagement_Service.Service.Module.Supplies(new EmployeeManagementDBContext()) { }.SupplyAll();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SuppliesForm_Load(object sender, EventArgs e)
        {
            InsertDataforCombobox();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_department.SelectedIndex == 0)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listKeToan.Count; i++)
                {
                    cbb_position.Items.Add(listKeToan[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 1)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listBaoVe.Count; i++)
                {
                    cbb_position.Items.Add(listBaoVe[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 2)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listIT.Count; i++)
                {
                    cbb_position.Items.Add(listIT[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 3)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listKinhDoanh.Count; i++)
                {
                    cbb_position.Items.Add(listKinhDoanh[i]);
                }
            }
            else if (cbb_department.SelectedIndex == 4)
            {
                cbb_position.Items.Clear();
                for (int i = 0; i < listNhanSu.Count; i++)
                {
                    cbb_position.Items.Add(listNhanSu[i]);
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
