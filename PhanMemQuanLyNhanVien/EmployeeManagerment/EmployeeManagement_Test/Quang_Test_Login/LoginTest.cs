﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeManagement_Service.ModelDBContext;

namespace EmployeeManagement_Test.Quang_Test_Login
{
    /// <summary>
    /// Summary description for LoginTest
    /// </summary>
    [TestClass]
    public class LoginTest
    {
        [TestInitialize]
        public void Setup()
        {

        }

        [TestMethod]
        public void Test_DN1()
        {
            PdbAccount ac = new EmployeeManagement_Service.Service.Basic.Functions.UserLogins() { }.CheckLogin("kt1", "kt1", "Kế toán");
            Assert.AreEqual(ac, null);
        }

    }
}
