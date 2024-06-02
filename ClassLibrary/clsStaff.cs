using System;

namespace ClassLibrary
{
    public class clsStaff
    {

        //private data member for the staff id property
        private Int32 mStaffId;
        private string mName;
        private string mPosition;
        private string mEmail;
        private DateTime mHiredate;
        private string mPhone;
        private Boolean mActive;


        //staffId public property
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }
        public DateTime Hiredate
        {
            get
            {
                return mHiredate;
            }
            set
            {
                mHiredate = value;
            }
        }
        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }
        public string Position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }        

        public int StaffId
        {
            get
            {
                //this line of code sends data out of the property
                return mStaffId;
            }

            set
            {
                //always return true
                mStaffId = value;
            }
        }


        public bool Find(int staffId)
        {
            //set the private data members to the test data value
            mStaffId = 5;
            mName = "Test Name";
            mPosition = "Test Position";
            mEmail = "asd@gmail.com";
            mHiredate = Convert.ToDateTime("02/06/2024");
            mPhone = "1";
            mActive = true;
            //always return true
            return true;
        }
    }
}