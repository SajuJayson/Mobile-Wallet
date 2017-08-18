using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountInfo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ds = cls.UserDetails("6475289869", 1);
        LabelCustomerId.Text = ds.Tables[0].Rows[0]["CustomerID"].ToString();
        LabelFirstName.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
        LabelLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
        LabelEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
        LabelAccountNo.Text = ds.Tables[0].Rows[0]["AccountNo"].ToString();
        LabelPhoneNo.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
        LabelRollID.Text = ds.Tables[0].Rows[0]["Balance"].ToString();
//string CustID = ds1.Tables[0].Rows[0]["CustomerID"].ToString();
    }

   

    protected void BtnTransactionHistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report.aspx?Flag=1 &CustID=1003");
    }
    DataBaseHandler cls = new DataBaseHandler();
    DataSet ds = new DataSet();
    protected void Button1_Click1(object sender, EventArgs e)
    {
        if (TextBoxCId.Text.Equals(""))
        {
            //LabelOutput.Text = "Enter a customer Id";
        }
        else
        {
            int result;
            if(int.TryParse(TextBoxCId.Text,out  result))
            {
                ds = cls.checkUserId(Convert.ToInt32(TextBoxCId.Text));
            }
          
            if(ds.Tables[0].Rows.Count == 0)
            {
                LabelOutput.Text = "Enter a Valid customer Id";
            }
            else
            {
                Response.Redirect("Report.aspx?Flag=2 &CustID=" +result);
            }
        }
    }

   
}