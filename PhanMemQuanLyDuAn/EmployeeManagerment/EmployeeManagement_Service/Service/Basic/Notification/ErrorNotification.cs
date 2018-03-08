using System.Windows.Forms;

namespace EmployeeManagement_Service.Service.Basic.Notification
{
    public class ErrorNotification
    {
        public void LoginFailed()
        {
            MessageBox.Show("Tài khoản hoặc mật khẩu không đúng - vui lòng kiểm tra lại", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void LoginFailed5Times()
        {
            MessageBox.Show("Chương trình bị khóa 15p do đăng nhập sai quá 5 lần", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void UsernameRequired()
        {
            MessageBox.Show("Bạn chưa nhập Username", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void PasswordRequired()
        {
            MessageBox.Show("Bạn chưa nhập Password", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void LockedAccount()
        {
            MessageBox.Show("Tài khoản đang bị khóa, liên hệ quản trị viên", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void DepartmentRequired()
        {
            MessageBox.Show("Bạn chưa chọn Phòng Ban", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ErrorWhileInsert()
        {
            MessageBox.Show("Lỗi trong quá trình thêm dữ liệu", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void ErrorWhileEdit()
        {
            MessageBox.Show("Lỗi trong quá trình sửa dữ liệu", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void ErrorWhileDelete()
        {
            MessageBox.Show("Lỗi trong quá trình xóa dữ liệu", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        public void ErrorWhileRefreshData()
        {
            MessageBox.Show("Lỗi trong quá trình cập nhập dữ liệu", "Lỗi thao tác", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
