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
            string TestData = "67";
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
        [TestMethod]
        public void FindMethodOk()
        {
             //create an instance of the class we want to create
             clsStaff Anstaff = new clsStaff();
            //create a Boolean variable to store the results of the validation
            Boolean Found = false;
            //create some test data to use with the method
            Int32 StaffId = 5;
            //invoke the method
            Found = Anstaff.Find(StaffId);
            //test to see if the result is true 
            Assert.IsTrue(Found);
                            

        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create a Boolean variable to store the result of the search
            Boolean Found = false;
            //create a Boolean variable to record if the date is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method 
            Int32 StaffId = 5;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id 
            if (AnStaff.StaffId != 5)
            {
                OK = false;

            }
            //test to see that the result is correct
            Assert.IsTrue(OK); 
        }
        [TestMethod]
        public void TestNameFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Name != "Test Name")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPositionFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Position != "Test Position")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestEmailFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Email != "asd@gmail.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPhoneFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Phone != "1")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestHiredateFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Hiredate != Convert.ToDateTime("02/06/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 5;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Active != true)
            {
                OK = false;
            }  
            Assert.IsTrue(OK);
        }

    }
}
