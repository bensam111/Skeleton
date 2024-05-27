using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Dynamic;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //test to see that it exists
            Assert.IsNotNull(AnStaff);
        }

        [TestMethod]
        public void ActivePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property 
            AnStaff.Active = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }

        [TestMethod]
        public void HiredatePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property 
            AnStaff.Hiredate = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Hiredate, TestData);
        }

        [TestMethod]
        public void PhonePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 67;
            //assign the data to the property 
            AnStaff.Phone = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Phone, TestData);
        }

        [TestMethod]
        public void EmailPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "test@mail.com";
            //assign the data to the property 
            AnStaff.Email = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Email, TestData);
        }

        [TestMethod]
        public void PositionPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Stock";
            //assign the data to the property 
            AnStaff.Position = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Position, TestData);
        }

        [TestMethod]
        public void NamePropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            String TestData = "Mohammed Zoubi";
            //assign the data to the property 
            AnStaff.Name = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }

        [TestMethod]
        public void StaffIdPropertyOk()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 4;
            //assign the data to the property 
            AnStaff.StaffId = TestData;
            //test to see that the values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }
    }
}
