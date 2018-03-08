using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Basic.Notification;
using EmployeeManagement_Service.Service.Module;
using System;
using System.Windows.Forms;

namespace EmployeeManagerment_UI.User
{
    public partial class FeedbackForm : Form
    {
        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            InsertFeedback();
        }

        private void InsertFeedback()
        {
            try
            {
                PdbFeedBack feedback = new PdbFeedBack();
                feedback = GetInfomation();
                new EmployeeManagement_Service.Service.Module.FeedBacks(new EmployeeManagementDBContext()) { }.Add(feedback);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.ThankforFeedback();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
        }

        #region Function
        private PdbFeedBack GetInfomation()
        {
            PdbFeedBack feedback = new PdbFeedBack();
            feedback.IDFeedBack = Guid.NewGuid();
            feedback.FirstName = txt_firstname.Text;
            feedback.LastName = txt_lastname.Text;
            feedback.Email = txt_email.Text;
            feedback.Point = lb_point.Text;
            feedback.Worst_Managerial_Funtion = cbb_worstmanagerialfunction.Text;
            feedback.Worst_Software_Interface = cbb_worstsoftwareinterface.Text;
            feedback.Favourite_Managerial_Funtion = cbb_favouritemanagerialfunction.Text;
            feedback.Favourite_Software_Interface = cbb_favouritesoftwareinterface.Text;
            feedback.UserShare = rtxt_usershare.Text;
            return feedback;
        }
        #endregion

        #region Btn_Point
        private void btn_one_Click(object sender, EventArgs e)
        {
            lb_point.Text = "Quá tệ";
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            lb_point.Text = "Hơi tệ";
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            lb_point.Text = "Bình thường";
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            lb_point.Text = "Khá tốt";
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            lb_point.Text = "Quá tốt";
        }
        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
