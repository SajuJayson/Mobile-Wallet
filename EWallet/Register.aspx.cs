using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.UI;
using EWallet;
using System.Data;

public partial class Account_Register : Page
{
    protected void CreateUser_Click(object sender, EventArgs e)
    {
        DataBaseHandler db = new DataBaseHandler();
        db.AddUser(FirstName.Text,LastName.Text,Email.Text,Phone.Text,UserName.Text, Password.Text);
        DataSet ds = new DataSet();
        ds = db.CheckUser(Email.Text, Password.Text);
        if (ds != null)
        {
            Session["UserInfo"] = ds;
            Response.Redirect("Default.aspx");
        }
    }
}