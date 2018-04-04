using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;
namespace EmployeeManagement_Test.Nhi_test.Test_EventManagement
{
    [TestClass]
    public class TestFuntion
    {
        private PdbBonusSalary TestSalary;
        private PdbStaff Test_staff;
        [TestInitialize]
        public void Setup()
        {
            TestSalary = new PdbBonusSalary();
            TestSalary.IDBS = Guid.NewGuid();
            TestSalary.IDStaff = new Guid("CFACFF13-F9D6-44D4-8ADE-F5B22FB627C1");
            TestSalary.MoneyBonus = 4000;
            TestSalary.DayBonus = DateTime.Now;
            TestSalary.ReasonBonus = "i don't know";
            TestSalary.MonthBonus = "12";
            TestSalary.YearBonus = "2017";

            Test_staff = new PdbStaff();
            Test_staff.ID_Staff = Guid.NewGuid();
            Test_staff.FirstName = "Hao";
            Test_staff.LastName = "Nguyen";
            Test_staff.Birthday = DateTime.Now;
            Test_staff.IndentityCard = "khongbiet";
            Test_staff.Date_Create_IC = new DateTime(2010, 12, 01);
            Test_staff.Place_Create_IC = "campuchia";
            Test_staff.Hometown = "Campuchia";
            Test_staff.Phone = "01868323274";
            Test_staff.AddressNumber = "23";
            Test_staff.AddressStreet = "Lê văn sỹ";
            Test_staff.AddressDistrict = "3";
            Test_staff.AddressWard = "tphcm";
            Test_staff.AddressCity = "Tphcm";
            Test_staff.Sex = "nam";
            Test_staff.Department = "Kế toán";
            Test_staff.Position = "Kế toán trưởng";
            Test_staff.SalaryBasic = 123;
            Test_staff.CoefficientsSalary = 123;
            Test_staff.isMarried = true;
            Test_staff.DateStartWork = new DateTime(2010, 12, 03);
            Test_staff.DateEndWork = new DateTime(2015, 12, 31);
            Test_staff.Image = new byte[] { 0x00, 0x00, 0x00, 0x01 };
            Test_staff.Produce = "abc";
            Test_staff.Email = "aptran17@gmail.com";

        }

        [TestMethod]
        public void TestThemLuong()
        {
            bool check = new Salary(new EmployeeManagementDBContext()) { }.Add(TestSalary);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void TestSuaLuong()
        {
            TestSalary.IDBS = new Guid("72F22668-143F-4F20-B083-EABC9CEAA3AA");
            TestSalary.ReasonBonus = "Edit";
            bool check = new Salary(new EmployeeManagementDBContext()) { }.Edit(TestSalary);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void TestXoaLuong()
        {
            bool check = new Salary(new EmployeeManagementDBContext()) { }.Delete(new Guid("C099B97F-AEBD-4F2B-96C6-6029A69417DA"));
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void ThemNV()
        {
            bool check = new Staffs(new EmployeeManagementDBContext()) { }.Create(Test_staff);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void staff_edit()
        {
            PdbStaff Staff = new PdbStaff();
            Staff = Test_staff;
            Staff.ID_Staff = new Guid("5a1c6fe2-c0b3-4939-ab6f-0b6e0b534775");

            bool check = new Staffs(new EmployeeManagementDBContext()) { }.Update(Test_staff);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Staff_Delete()
        {
            Guid guid = new Guid("5a1c6fe2-c0b3-4939-ab6f-0b6e0b534775");
            bool check = new Staffs(new EmployeeManagementDBContext()) { }.Delete(guid);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Staff_Get()
        {
            Guid guid = new Guid("5a1c6fe2-c0b3-4939-ab6f-0b6e0b534775");
            //Test_Contract.IDContract = new Guid("8E0DC287-5F62-4D61-BB26-686FF959C62A");
            PdbStaff check = new Staffs(new EmployeeManagementDBContext()) { }.GetStaff(guid);
            Assert.AreNotEqual(check, false);
        }
    }
}
