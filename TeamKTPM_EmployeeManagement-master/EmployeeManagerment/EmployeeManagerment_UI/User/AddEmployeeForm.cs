using System;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace EmployeeManagerment_UI.User
{
    public partial class AddEmployeeForm : Form
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


        //Variable
        byte[] image;
        //--------
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            InsertDataforCombobox();
        }

        public byte[] ConvertImagetoByte(System.Drawing.Image picture)
        {
            byte[] array;
            using (MemoryStream stream = new MemoryStream())
            {
                picture.Save(stream, ImageFormat.Jpeg);
                array = stream.ToArray();
            }
            return array;
        }

        private void btn_addimage_Click(object sender, EventArgs e)
        {
            ChoosePicture();
        }

        private void ChoosePicture()
        {
            try
            {
                openFileDialog1.ShowDialog();
                string file = openFileDialog1.FileName;
                if (string.IsNullOrEmpty(file))
                {
                    return;
                }
                Image myI = Image.FromFile(file);
                ptb_image.Image = myI;
                image = ConvertImagetoByte(ptb_image.Image);
            }
            catch
            {
                MessageBox.Show("Bạn chưa chọn hình !!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_backaddemployee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private PdbStaff GetInformation()
        {
            PdbStaff staff = new PdbStaff();
            staff.ID_Staff = Guid.NewGuid();
            staff.FirstName = txt_firstname.Text;
            staff.LastName = txt_lastname.Text;
            staff.Birthday = dtp_birthday.Value;
            staff.Sex = cbb_sex.Text;
            staff.Phone = txt_phonenumber.Text;
            staff.Email = txt_email.Text;
            staff.Hometown = txt_hometown.Text;
            staff.IndentityCard = txt_ic.Text;
            staff.Date_Create_IC = dtp_datecreateic.Value;
            staff.Place_Create_IC = cbb_placecreateic.Text;
            staff.Department = cbb_department.Text;
            staff.Position = cbb_position.Text;
            staff.SalaryBasic = Convert.ToDecimal(txt_basicsalary.Text);
            staff.CoefficientsSalary = Convert.ToDouble(txt_coefficientssalary.Text);
            staff.DateStartWork = dtp_datestartwork.Value;
            staff.DateEndWork = dtp_dateendwork.Value;
            staff.AddressNumber = txt_address.Text;
            staff.AddressStreet = txt_street.Text;
            staff.AddressWard = txt_ward.Text;
            staff.AddressDistrict = txt_district.Text;
            staff.AddressCity = cbb_city.Text;
            staff.Produce = rtxtproduce.Text;
            if (cbb_sex.SelectedIndex == 0)
            {
                staff.isMarried = true;
            }
            else
            {
                staff.isMarried = false;
            }
            ChoosePicture();
            staff.Image = image;
            return staff;
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.CloseandOpen())
            {
                txt_firstname.Text = "";
                txt_lastname.Text = "";
                txt_phonenumber.Text = "";
                txt_email.Text = "";
                txt_ic.Text = "";
                txt_hometown.Text = "";
                txt_basicsalary.Text = "";
                txt_coefficientssalary.Text = "";
                txt_address.Text = "";
                txt_street.Text = "";
                txt_ward.Text = "";
                txt_district.Text = "";
            }
            else
            {

            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                PdbStaff staff = new PdbStaff();
                staff = GetInformation();
                new EmployeeManagement_Service.Service.Module.Staffs(new EmployeeManagementDBContext()) { }.Create(staff);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.InsertSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
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
    }
}
