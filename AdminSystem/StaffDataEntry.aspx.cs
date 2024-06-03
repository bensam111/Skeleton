using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //  create a new instance of clsStaff
        clsStaff AnStaff = new clsStaff();
        //capture the Name
        AnStaff.Name = txtNameId.Text;
        AnStaff.Position = txtPositionId.Text;
        AnStaff.Email = txtEmailId.Text;
        AnStaff.Hiredate = Convert.ToDateTime(DateTime.Now);
        AnStaff.Phone = txtPhoneId.Text;
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
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


