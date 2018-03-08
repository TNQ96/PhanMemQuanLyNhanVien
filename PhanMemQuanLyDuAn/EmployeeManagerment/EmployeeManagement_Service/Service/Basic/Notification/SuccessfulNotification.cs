using System.Windows.Forms;

namespace EmployeeManagement_Service.Service.Basic.Notification
{
    public class SuccessfulNotification
    {
        public void LoginSuccessful()
        {
            MessageBox.Show("Đăng nhập thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void InsertSuccessful()
        {
            MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void UpdateSuccessful()
        {
            MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void DeleteSuccessful()
        {
            MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ThankforFeedback()
        {
            MessageBox.Show("Cảm ơn bạn đã gửi phản hồi về cho chúng tôi!", "Cảm ơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool CloseandOpen()
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn hủy", "Cảm ơn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                return true;
            }
            return false;
        }
    }
}
