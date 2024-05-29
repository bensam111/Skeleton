using System;

namespace ClassLibrary
{
    public class clsStaff
    {
        public clsStaff()
        {
        }

        public bool Active { get; set; }
        public string Phone { get; set; }
        public DateTime Hiredate { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string Name { get; set; }
        public int StaffId { get; set; }
    }
}