using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Runtime.Remoting;

namespace Testing1
{
    [TestClass]
    public class tstStaffCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            Assert.IsNotNull(AllStaffs);
        }
        [TestMethod]
        public void StaffListOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.StaffId = 4;
            TestItem.Name = "Mohammed Zoubi ";
            TestItem.Position = "Customer service";
            TestItem.Email = "maz@mail.com";
            TestItem.Phone = "07933284352";
            TestItem.Hiredate = DateTime.Now;
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.StaffList, TestList);


        }       
        [TestMethod]
        public void ThisStaffPropertyOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestStaff = new clsStaff();
            TestStaff.Active = true;
            TestStaff.StaffId = 4;
            TestStaff.Name = "Mohammed Zoubi ";
            TestStaff.Position = "Customer service";
            TestStaff.Email = "maz@mail.com";
            TestStaff.Phone = "07933284352";
            TestStaff.Hiredate = DateTime.Now;
            AllStaffs.ThisStaff = TestStaff;
            Assert.AreEqual(AllStaffs.ThisStaff, TestStaff);


        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            List<clsStaff> TestList = new List<clsStaff>();
            clsStaff TestItem = new clsStaff();
            TestItem.Active = true;
            TestItem.StaffId = 4;
            TestItem.Name = "Mohammed Zoubi ";
            TestItem.Position = "Customer service";
            TestItem.Email = "maz@mail.com";
            TestItem.Phone = "07933284352";
            TestItem.Hiredate = DateTime.Now;
            TestList.Add(TestItem);
            AllStaffs.StaffList = TestList;
            Assert.AreEqual(AllStaffs.Count, TestList.Count);


        }
        [TestMethod]
        public void AddMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.Name = "Mohammed Zoubi";
            TestItem.Position = "Customer service";
            TestItem.Email = "maz@mail.com";
            TestItem.Phone = "07933284352";
            TestItem.Hiredate = DateTime.Now;
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffId = PrimaryKey;
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);
        }
        [TestMethod]
        public void UpdateMethodOK()
        {
            clsStaffCollection AllStaffs = new clsStaffCollection();
            clsStaff TestItem = new clsStaff();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.Name = "Mohammed Zoubi";
            TestItem.Position = "Customer service";
            TestItem.Email = "maz@mail.com";
            TestItem.Phone = "07933284352";
            TestItem.Hiredate = DateTime.Now;
            AllStaffs.ThisStaff = TestItem;
            PrimaryKey = AllStaffs.Add();
            TestItem.StaffId = PrimaryKey;
            TestItem.Active = false;
            TestItem.Name = "Mahmood kerim";
            TestItem.Position = "stock";
            TestItem.Phone = "07984568134";
            TestItem.Email = "mahmood@gmail.com";
            TestItem.Hiredate= DateTime.Now;
            AllStaffs.ThisStaff = TestItem;
            AllStaffs.Update();
            AllStaffs.ThisStaff.Find(PrimaryKey);
            Assert.AreEqual(AllStaffs.ThisStaff, TestItem);

        }
    }
}
