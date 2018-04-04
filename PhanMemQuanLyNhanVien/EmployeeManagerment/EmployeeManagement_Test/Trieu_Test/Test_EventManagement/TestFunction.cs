using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.Service.Module;
using EmployeeManagement_Service.ModelDBContext;

namespace EmployeeManagement_Test.Trieu_Test.Test_EventManagement
{
    [TestClass]
    public class TestFunction
    {
        private PdbContract Test_Contract;
        private PdbEducationLevel Test_El;
        [TestInitialize]
        public void setUp()
        {
            Test_Contract = new PdbContract();
            Test_Contract.IDContract = Guid.NewGuid();
            Test_Contract.IDStaff = new Guid("CFACFF13-F9D6-44D4-8ADE-F5B22FB627C1");
            Test_Contract.ContractType = "Lao động";
            Test_Contract.ContractDescription = "Lao động ntn....";
            Test_Contract.PayForms = "Chuyển khoản";
            Test_Contract.StartDate = DateTime.Now;
            Test_Contract.EndDate = DateTime.Now;
            Test_Contract.SignDate = DateTime.Now;

            Test_El = new PdbEducationLevel();
            Test_El.ID_EL = Guid.NewGuid();
            Test_El.IDStaff = new Guid("5A1C6FE2-C0B3-4939-AB6F-0B6E0B534775");
            Test_El.NameEL = "Đại học văn lang";
            Test_El.Major = "Quản lý nhân sự";
            Test_El.CertificateType = "Tin học đại cương";
            Test_El.PlaceProvide = "Đại học mở";
            Test_El.Result = "Good";
            Test_El.DateOut = DateTime.Now;
            Test_El.DateProvide = DateTime.Now;
            Test_El.Note = null;
        }

        [TestMethod]
        public void Them_Hop_Dong()
        {
            bool check = new Contracts(new EmployeeManagementDBContext()) { }.Add(Test_Contract);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Chinh_Sua_HD()
        {
            PdbContract Contract = new PdbContract();
            Contract = Test_Contract;
            Contract.IDContract = new Guid("8E0DC287-5F62-4D61-BB26-686FF959C62A");
            Contract.PayForms = "Trực tiếp";
            Contract.ContractType = "Bảo hiểm";
            bool check = new Contracts(new EmployeeManagementDBContext()) { }.Edit(Contract);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Xoa_HD()
        {
            Guid guid = new Guid("289739C5-3DAB-4CC4-8CF7-8BCF4632198A");
            //Test_Contract.IDContract = new Guid("289739C5-3DAB-4CC4-8CF7-8BCF4632198A");
            bool check = new Contracts(new EmployeeManagementDBContext()) { }.Delete(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Lay_HD()
        {
            Guid guid = new Guid("8E0DC287-5F62-4D61-BB26-686FF959C62A");
            //Test_Contract.IDContract = new Guid("8E0DC287-5F62-4D61-BB26-686FF959C62A");
            PdbContract check = new Contracts(new EmployeeManagementDBContext()) { }.GetContract(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void EducationLevel_Add()
        {
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Add(Test_El);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void EducationLevel_Edit()
        {
            PdbEducationLevel EL = new PdbEducationLevel();
            EL = Test_El;
            EL.ID_EL = new Guid("D43C27B2-5735-41EB-98DE-62AEA7113322");
            EL.Result = "Pass";
            EL.PlaceProvide = "Đại học bách khoa HN";
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Edit(EL);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void EducationLevel_Delete()
        {
            Guid guid = new Guid("7861B53B-7B7B-4603-BD4C-EBEDF7D3D4A7");
            //Test_El.ID_EL = new Guid("7861B53B-7B7B-4603-BD4C-EBEDF7D3D4A7");
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Delete(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void EducationLevel_Get()
        {
            Guid guid = new Guid("D43C27B2-5735-41EB-98DE-62AEA7113322");
            //Test_El.ID_EL = new Guid("D43C27B2-5735-41EB-98DE-62AEA7113322");
            PdbEducationLevel check = new EducationLevels(new EmployeeManagementDBContext()) { }.GetEducationLevel(guid);
            Assert.AreNotEqual(check, false);
        }
    }
}
