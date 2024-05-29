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
        AnStaff.Hiredate = Convert.ToDateTime(txtHiredateId.Text);
        AnStaff.Phone = txtPhoneId.Text;
        //store the staff in the session object
        Session["AnStaff"] = AnStaff;
        //navigate to the view page
        Response.Redirect("StaffViewer.aspx");
    }
}


