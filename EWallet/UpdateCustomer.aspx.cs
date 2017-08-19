using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    DataBaseHandler dbh = new DataBaseHandler();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            ShowData();
    }
    public void ShowData()
    {
        DataSet ds = new DataSet();
        ds=dbh.UserDetails("", 3);
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
    {
        //NewEditIndex property used to determine the index of the row being edited.  
        GridView1.EditIndex = e.NewEditIndex;
        ShowData();
    }
    protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
    {        
        Label id = GridView1.Rows[e.RowIndex].FindControl("lblCustomerID") as Label;
        TextBox FirstName = GridView1.Rows[e.RowIndex].FindControl("txtFirstName") as TextBox;
        TextBox LastName = GridView1.Rows[e.RowIndex].FindControl("txtLastName") as TextBox; 
        TextBox Email = GridView1.Rows[e.RowIndex].FindControl("txtEmail") as TextBox;
        TextBox Phone = GridView1.Rows[e.RowIndex].FindControl("txtPhone") as TextBox;
        dbh.UpdateCustomerData(FirstName.Text, LastName.Text, Email.Text, Phone.Text, Convert.ToInt16( id.Text));
        GridView1.EditIndex = -1;
        //Call ShowData method for displaying updated data  
        ShowData();
    }
    protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
    {
        //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
        GridView1.EditIndex = -1;
        ShowData();
    }
    protected void BtnReportBack_Click1(object sender, EventArgs e)
    {
        
            Response.Redirect("AccountInfo.ASPX");
    }
}