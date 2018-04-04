using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Test.Hao_test.Test_EventManagement
{

    [TestClass]
    public class Testevent
    {

        private PdbEvent Test_Event;
        [TestInitialize]
        public void Setup()
        {
            Test_Event = new PdbEvent();
            Test_Event.ID_Event = Guid.NewGuid();
            Test_Event.EventName = "Nguyen Du Phuc Hao";
            Test_Event.ExpectedCost = 30000;
            Test_Event.CostsAwarded = 100000;
            Test_Event.ActualCosts = 20000;
            Test_Event.DateStart = DateTime.Now;
            Test_Event.DateEnd = DateTime.Now;
            Test_Event.Location = "Binh Duong";
            Test_Event.Scale = "phong IT";
            Test_Event.EventContent = "Di Choi";
            Test_Event.TravelBy = "xe hoi";
        }
        [TestMethod]
        public void Test_ThemEvent()
        {
            bool check = new Events(new EmployeeManagementDBContext()) { }.Add(Test_Event);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Test_EventDelete()
        {
            Test_Event.ID_Event = new Guid("0CFCB337-663B-4B61-8932-3A89B09D25AA");
            bool check = new Events(new EmployeeManagementDBContext()) { }.Delete(Test_Event.ID_Event);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Test_ChinhSuaEvent()
        {
            Test_Event = new PdbEvent();
            Test_Event.EventName = "Hao Nguyen";
            Test_Event.ExpectedCost = 30000;
            Test_Event.CostsAwarded = 100000;
            Test_Event.ActualCosts = 20000;
            Test_Event.DateStart = DateTime.Now;
            Test_Event.DateEnd = DateTime.Now;
            Test_Event.Location = "Binh Duong";
            Test_Event.Scale = "phong IT";
            Test_Event.EventContent = "Di Choi";
            Test_Event.TravelBy = "xe hoi";
            Test_Event.ID_Event = new Guid("8ECE2A2D-C5A0-498C-A5BE-D47CF3399FC6");
            bool check = new Events(new EmployeeManagementDBContext()) { }.Edit(Test_Event);
            Assert.AreNotEqual(check, false);
        }
        [TestMethod]
        public void Test_EventGet()
        {
            Test_Event.ID_Event = new Guid("4A1B325F-5114-4AA1-86F7-EE6C93642B1B");
            PdbEvent check = new Events(new EmployeeManagementDBContext()) { }.GetEvent(Test_Event.ID_Event);
            Assert.AreNotEqual(check, false);
        }

    }
}
