using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.CodeDom;
using System.Dynamic;
using System.IO;
using System.Security.Policy;

namespace Testing1
{
    [TestClass]
    public class tstStaff
    {
        //good test data
        //create some test data to pass the method
        string name = "Mohammed Zoubi";
        string position = "Customer service";
        string email = "maz@mail.com";
        string phone = "07933284352";
        string hiredate = DateTime.Now.ToShortDateString();


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
            Int32 StaffId = 7;
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
            Int32 StaffId = 7;
            //invoke the method
            Found = AnStaff.Find(StaffId);
            //check the staff id 
            if (AnStaff.StaffId != 7)
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
            Int32 StaffId = 7;
            Found = AnStaff.Find(StaffId);
            if (AnStaff.Name != "Oyin Dumbo")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestPositionFound()
        {
            clsStaff AnStaff = new clsStaff();
            Boolean found = false;
            Boolean OK = true;
            Int32 StaffId = 7;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Position != "stock")
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
            Int32 StaffId = 7;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Email != "oyin@gmail.com")
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
            Int32 StaffId = 7;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Phone != "07142523489")
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
            Int32 StaffId = 7;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Hiredate != Convert.ToDateTime("02/05/2024"))
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
            Int32 StaffId = 7;
            found = AnStaff.Find(StaffId);
            if (AnStaff.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string variable to store any error message
            String Error = "";
            //invoke the method 
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            //test to see that hte result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMinLessOne()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //string c=variable to store any error messsage
            String Error = "";
            //create some test data to pass to the method
            string name = ""; //this should trigger an error
            //invoke the method
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void nameMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "a"; //This should be ok 
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "aa";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "";
            name = name.PadRight(49, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "";
            name = name.PadRight(50, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "";
            name = name.PadRight(25, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void nameMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "";
            name = name.PadRight(51, 'a');

            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void nameExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string name = "";
            name = name.PadRight(500, 'a'); //this should fail
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void hiredateExtremeMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string hiredate = TestDate.ToString();
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void hiredateMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string hiredate = TestDate.ToString();
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void hiredateMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string hiredate = TestDate.ToString();
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void hiredateMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string hiredate = TestDate.ToString();
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void hiredateExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string hiredate = TestDate.ToString();
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void emailMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "a";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void emailMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "aa";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void emailMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            email = email.PadRight(49, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void emailMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            email = email.PadRight(50, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void emailMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            email = email.PadRight(51, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void emailMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            email = email.PadRight(25, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");

        }
        [TestMethod]
        public void emailExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string email = "";
            email = email.PadRight(100, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void positionMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            Error = AnStaff.Valid(name,position,email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void positionMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "a";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void positionMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "aa";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void positionMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            position = position.PadRight(49, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void positionMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            position = position.PadRight(50, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void positionMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            position = position.PadRight(51, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void positionMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            position = position.PadRight(25, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void positionExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string position = "";
            position = position.PadRight(100, 'a');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneMinLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneMin()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "1";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneMinPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "11";
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneMaxLessOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            phone = phone.PadRight(19, '1');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            phone = phone.PadRight(20, '1');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneMaxPlusOne()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            phone = phone.PadRight(21, '1');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void phoneMid()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            phone = phone.PadRight(10, '1');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void phoneExtremeMax()
        {
            clsStaff AnStaff = new clsStaff();
            String Error = "";
            string phone = "";
            phone = phone.PadRight(30, '1');
            Error = AnStaff.Valid(name, position, email, phone, hiredate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
