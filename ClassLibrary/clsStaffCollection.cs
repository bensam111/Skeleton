using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsStaffCollection
    {
        List<clsStaff> mStaffList = new List<clsStaff>();
        clsStaff mThisStaff = new clsStaff ();
        public List<clsStaff> StaffList
        {
            get
            {
                return mStaffList;
            }
            set
            {
                mStaffList = value;
            }
        }
        public int Count 
        { 
            get
            {
                return StaffList.Count;
            }
            set
            {

            }

        }
        public clsStaff ThisStaff
        {
            get
            {
                return mThisStaff;
            }
            set
            {
                mThisStaff = value;
            }
        }
        public clsStaffCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblStaff_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsStaff AnStaff = new clsStaff();
                AnStaff.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);
                AnStaff.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnStaff.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnStaff.Position = Convert.ToString(DB.DataTable.Rows[Index]["Position"]);
                AnStaff.Email = Convert.ToString(DB.DataTable.Rows[Index]["Email"]);
                AnStaff.Phone = Convert.ToString(DB.DataTable.Rows[Index]["Phone"]);
                AnStaff.Hiredate = Convert.ToDateTime(DB.DataTable.Rows[Index]["Hiredate"]);
                mStaffList.Add(AnStaff);
                Index++;
            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", mThisStaff.Name);
            DB.AddParameter("@Position", mThisStaff.Position);
            DB.AddParameter("@Email", mThisStaff.Email);
            DB.AddParameter("@Phone", mThisStaff.Phone);
            DB.AddParameter("@Hiredate", mThisStaff.Hiredate);
            DB.AddParameter("@Active", mThisStaff.Active);
            return DB.Execute("sproc_tblStaff_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@staffId", mThisStaff.StaffId);
            DB.AddParameter("@name", mThisStaff.Name);
            DB.AddParameter("@position", mThisStaff.Position);
            DB.AddParameter("@Phone", mThisStaff.Phone);
            DB.AddParameter("@email", mThisStaff.Email);
            DB.AddParameter("@hiredate", mThisStaff.Hiredate);
            DB.AddParameter("@Active", mThisStaff.Active);
            DB.Execute("sproc_tblStaff_Update");

        }
    }
}