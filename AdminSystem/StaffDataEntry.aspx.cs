using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 StaffId;
    protected void Page_Load(object sender, EventArgs e)
    {
        StaffId = Convert.ToInt32(Session["StaffId"]);
        if (IsPostBack == false) 
        {
            if (StaffId != -1)
            {
                DisplayStaff();
            }
        }

    }
    void DisplayStaff()
    {
        clsStaffCollection Staffbook = new clsStaffCollection();
        Staffbook.ThisStaff.Find(StaffId);
        txtStaffId.Text = Staffbook.ThisStaff.StaffId.ToString();
        txtNameId.Text = Staffbook.ThisStaff.Name.ToString();
        txtPositionId.Text = Staffbook.ThisStaff.Position.ToString();
        txtEmailId.Text = Staffbook.ThisStaff.Email.ToString();
        txtPhoneId.Text = Staffbook.ThisStaff.Phone.ToString();
        txtHiredateId.Text = Staffbook.ThisStaff.Hiredate.ToString();
        chkActive.Checked = Staffbook.ThisStaff.Active; 


    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        
        string name = txtNameId.Text;
        string position = txtPositionId.Text;
        string email = txtEmailId.Text;
        string phone = txtPhoneId.Text;
        string hiredate = txtHiredateId.Text;
        string active = chkActive.Text;
        string Error = "";
        Error = AnStaff.Valid( name, position, email, phone, hiredate);
        if (Error == "")
        {
            //capture the Name
            AnStaff.StaffId = StaffId;
            AnStaff.Name = name;
            AnStaff.Position = position;
            AnStaff.Email = email;
            AnStaff.Hiredate = Convert.ToDateTime(DateTime.Now);
            AnStaff.Phone = phone;
            AnStaff.Active = chkActive.Checked;
            clsStaffCollection StaffList = new clsStaffCollection();


            if (StaffId == -1)
            {
                StaffList.ThisStaff = AnStaff;
                StaffList.Add();
            }
            else
            {
                StaffList.ThisStaff.Find(StaffId);
                StaffList.ThisStaff = AnStaff;
                StaffList.Update();

            }
            Response.Redirect("StaffList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
            
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AnStaff = new clsStaff();
        //create a variable to store the primary key
        Int32 StaffId;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        StaffId = Convert.ToInt32(txtStaffId.Text);
        //find the record
        Found = AnStaff.Find(StaffId);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtNameId.Text = AnStaff.Name;
            txtPositionId.Text = AnStaff.Position;
            txtEmailId.Text = AnStaff.Email;
            txtHiredateId.Text = AnStaff.Hiredate.ToString();
            txtPhoneId.Text = AnStaff.Phone;
            chkActive.Checked = AnStaff.Active;


        }

    }
}


