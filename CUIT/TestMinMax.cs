﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace CUIT
{
    /// <summary>
    /// Summary description for TestMinMax
    /// </summary>
    [CodedUITest]
    public class TestMinMax
    {
        public TestMinMax()
        {
        }

        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\Users\\hodan\\Desktop\\KDPM_Buoi08\\CUIT\\data-min-max.csv", "data-min-max#csv", DataAccessMethod.Sequential), DeploymentItem("data-min-max.csv"), TestMethod]
        //public void CodedUITestMethod1()
        //{
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    this.UIMap.RecordedInput(TestContext.DataRow[0].ToString(), TestContext.DataRow[1].ToString(), TestContext.DataRow[2].ToString());
        //    this.UIMap.ValidateMaxValue(TestContext.DataRow[4].ToString());
        //    this.UIMap.ValidateMinValue(TestContext.DataRow[3].ToString());
        //}

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "C:\\Users\\hodan\\Desktop\\KDPM_Buoi08\\CUIT\\data-min-max.csv", "data-min-max#csv", DataAccessMethod.Sequential), DeploymentItem("data-min-max.csv"), TestMethod]
        public void CodedUITestMethod2()
        {
            this.UIMap.AddInputNumbers(TestContext.DataRow[0].ToString(), TestContext.DataRow[1].ToString(), TestContext.DataRow[2].ToString());
            this.UIMap.ValidateMax(TestContext.DataRow[4].ToString());
            this.UIMap.ValidateMin(TestContext.DataRow[3].ToString());
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
