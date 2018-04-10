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
            Test_El.IDStaff = new Guid("BF711301-4C0D-4056-A2DC-22AAA95787F2");
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
            Contract.IDContract = new Guid("7F93169E-BFBB-4121-A3A1-060F766A491B");
            Contract.PayForms = "Trực tiếp";
            Contract.ContractType = "Bảo hiểm";
            bool check = new Contracts(new EmployeeManagementDBContext()) { }.Edit(Contract);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Xoa_HD()
        {
            Guid guid = new Guid("7F93169E-BFBB-4121-A3A1-060F766A491B");
            //Test_Contract.IDContract = new Guid("289739C5-3DAB-4CC4-8CF7-8BCF4632198A");
            bool check = new Contracts(new EmployeeManagementDBContext()) { }.Delete(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Lay_HD()
        {
            Guid guid = new Guid("7F93169E-BFBB-4121-A3A1-060F766A491B");
            //Test_Contract.IDContract = new Guid("8E0DC287-5F62-4D61-BB26-686FF959C62A");
            PdbContract check = new Contracts(new EmployeeManagementDBContext()) { }.GetContract(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Them_Hoc_Van()
        {
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Add(Test_El);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Chinh_Sua_Hoc_Van()
        {
            PdbEducationLevel EL = new PdbEducationLevel();
            EL = Test_El;
            EL.ID_EL = new Guid("07B13ECF-5AA6-42A2-81E7-9A9A750A2149");
            EL.Result = "Pass";
            EL.PlaceProvide = "Đại học bách khoa HN";
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Edit(EL);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Xoa_Hoc_Van()
        {
            Guid guid = new Guid("07B13ECF-5AA6-42A2-81E7-9A9A750A2149");
            //Test_El.ID_EL = new Guid("7861B53B-7B7B-4603-BD4C-EBEDF7D3D4A7");
            bool check = new EducationLevels(new EmployeeManagementDBContext()) { }.Delete(guid);
            Assert.AreNotEqual(check, false);
        }

        [TestMethod]
        public void Lay_Bang_Cap()
        {
            Guid guid = new Guid("D43C27B2-5735-41EB-98DE-62AEA7113322");
            //Test_El.ID_EL = new Guid("D43C27B2-5735-41EB-98DE-62AEA7113322");
            PdbEducationLevel check = new EducationLevels(new EmployeeManagementDBContext()) { }.GetEducationLevel(guid);
            Assert.AreNotEqual(check, false);
        }
    }
}
