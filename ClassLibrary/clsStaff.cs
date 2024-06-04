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


        public bool Find(int StaffId)
        {
            //create an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the staff id to search for
            DB.AddParameter("@StaffId", StaffId);
            //execute the stored procedure
            DB.Execute("sproc_tblStaff_FilterByStaffId");
            // if one record is found(there should be either one or zero)
            if (DB.Count == 1)
            {

                //copy the data from the database to the private data members
                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mPosition = Convert.ToString(DB.DataTable.Rows[0]["Position"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["Email"]);
                mHiredate = Convert.ToDateTime(DB.DataTable.Rows[0]["HireDate"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["Phone"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {

                //return false indicating there is a problem
                return false;

            }
        }

        public string Valid(string name, string position, string email, string phone, string hiredate)
        {
            //create a string variable to store the error
            String Error = "";
            DateTime DateTemp;
            //if the name is blank
            if (name.Length == 0)
            {
                //record the error
                Error = Error + "The name may not be blank : ";
            }
            //if the name is greater than 6 characters
            if (name.Length > 6)
            {
                //record the error
                Error = Error + "The name must be less than 6 characters";
            }
            DateTemp = Convert.ToDateTime(hiredate);
            if (DateTemp > DateTime.Now.Date)
            {
                Error = Error + "The date cannot be in the future";
            }
            //return any error messages
            return Error;
        }
    }
}