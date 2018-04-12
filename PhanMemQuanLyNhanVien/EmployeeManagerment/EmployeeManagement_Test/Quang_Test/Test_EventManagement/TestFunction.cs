using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Test.Quang_Test.Test_EventManagement
{
   
    [TestClass]
    public class TestFunctionAccount
    {
        private PdbAccount account;
        [TestInitialize]
        public void SetUp()
        {
            account = new PdbAccount();
            account.AccountName = "test1";
            account.AccountPassword = "test";
            account.AccountLevel = "NS";
            account.IDAccount = Guid.NewGuid();
            account.IDStaff = new Guid("CFACFF13-F9D6-44D4-8ADE-F5B22FB627C1");
            account.isActive = true;
        }

        [TestMethod]
        public void Test_Tao_TK()
        {
            bool checkadd = new Accounts(new EmployeeManagementDBContext()) { }.Create(account);
            Assert.AreNotEqual(checkadd, false);
        }
        [TestMethod]
        public void Test_Update_TK()
        {
            account = new PdbAccount();
            account.AccountName = "testupdate";
            account.AccountPassword = "testupdate";
            account.AccountLevel = "Bao Ve";
            account.IDAccount = new Guid("7B17E386-AA4B-496E-89A7-5585FF9480CE");
            account.IDStaff = new Guid("CFACFF13-F9D6-44D4-8ADE-F5B22FB627C1");
            account.isActive = true;
            bool checkupdate = new Accounts(new EmployeeManagementDBContext()) { }.Update(account);
            Assert.AreNotEqual(checkupdate, false);
        }
        [TestMethod]
        public void Test_Xoa_TK()
        {
            account = new PdbAccount();
            account.AccountName = "testdelete";
            account.AccountPassword = "testdelete";
            account.AccountLevel = "NS";
            account.IDAccount = new Guid("E82BD1A2-0B52-4E34-90E8-42EC7D2C5F78");
            account.IDStaff = new Guid("CFACFF13-F9D6-44D4-8ADE-F5B22FB627C1");
            account.isActive = true;
            bool checkdetele = new Accounts(new EmployeeManagementDBContext()) { }.Delete(account.IDAccount);
            Assert.AreNotEqual(checkdetele, false);
        }
    }
}
