using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Test.Khanh_Test.Test_EventManagement
{

    [TestClass]
    public class TestFeedBack
    {
        private PdbFeedBack Test_FeedBack;
        [TestInitialize]
        public void Setup()
        {
            Test_FeedBack = new PdbFeedBack();
            Test_FeedBack.IDFeedBack = Guid.NewGuid();
            Test_FeedBack.FirstName = "Khanh";
            Test_FeedBack.LastName = "Hoang";
            Test_FeedBack.Point = "Quá tốt";
            Test_FeedBack.Email = "kchickenk@yahoo.com.vn";
            Test_FeedBack.Favourite_Software_Interface = "Thêm nhân viên";
            Test_FeedBack.Favourite_Managerial_Funtion = "Quản lý nhân viên";
            Test_FeedBack.Worst_Software_Interface = "Sửa nhân viên";
            Test_FeedBack.Worst_Managerial_Funtion = "Quản lý vật tư";
            Test_FeedBack.UserShare = "good";
        }
        [TestMethod]
        public void Test_Them_Feedback()
        {
            bool check = new FeedBacks(new EmployeeManagementDBContext()) { }.Add(Test_FeedBack);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Test_Xoa_Feedback()
        {
            Test_FeedBack.IDFeedBack = new Guid("E9F4C69A-046D-4350-9C58-0D635C48189D");
            bool check = new FeedBacks(new EmployeeManagementDBContext()) { }.Delete(Test_FeedBack.IDFeedBack);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Test_Lay_Feedback()
        {
            Test_FeedBack.IDFeedBack = new Guid("65E81B74-6135-4315-9086-4CB0BB1401D8");
            PdbFeedBack check = new FeedBacks(new EmployeeManagementDBContext()) { }.GetEvent(Test_FeedBack.IDFeedBack);
            Assert.AreNotEqual(check, false);
        }
    }
}