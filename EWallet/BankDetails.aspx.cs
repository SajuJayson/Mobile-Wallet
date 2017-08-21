using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class BankDetails : System.Web.UI.Page
{
    DataBaseHandler cls = new DataBaseHandler();
    DataSet ds = new DataSet();
    DataSet ds1 = new DataSet();
    static int CustId ;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            if (Session["UserInfo"] != null)
            {
                DataSet ds = new DataSet();
                ds = Session["UserInfo"] as DataSet;
                if (ds.Tables[0].Rows.Count > 0)
                {
                    Session["Userid"] = ds.Tables[0].Rows[0]["CustomerID"];
                    CustId = Convert.ToInt32(ds.Tables[0].Rows[0]["CustomerID"]);
                    Control c = this.Master.FindControl("login");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("Register");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("LogOut");// "masterDiv"= the Id of the div.
                    c.Visible = true;
                    Label mpLabel = (Label)Master.FindControl("welcome");
                    mpLabel.Text = "Welcome " + ds.Tables[0].Rows[0]["firstname"];
                    mpLabel.Visible = true;
                    //Flag = 1;

                }
                else
                    Response.Redirect("login.aspx");

            }
            else
                Response.Redirect("login.aspx");
    }
    
    protected void BtnNextWithdraw_Click(object sender, EventArgs e)
    {
        ds = cls.checkBankAccNoDetails(Convert.ToInt32(TextBoxAccountNo.Text));
        if(ds.Tables[0].Rows.Count == 0)
        {
            LabelStatus.Text = "Please Enter Correct Bank Account No";
        }
        else
        {
            ds1 = cls.checkUserId(CustId);
            int balance =Convert.ToInt32( ds1.Tables[0].Rows[0]["Balance"]);

            if (balance < Convert.ToInt32(TextBoxAmount.Text))
            {
                LabelStatus.Text = "Low Balance. Please Enter Amount less than "+balance;

            }
            else
            {
                int updatedAmt = balance - Convert.ToInt32(TextBoxAmount.Text);
                Response.Redirect($"ConfirmationForm.aspx?Task=2&CustID={CustId}&CurBal={balance}&DeductedAmt={TextBoxAmount.Text}&updatedAmt={updatedAmt}&BankAccNo={TextBoxAccountNo.Text}");

            }

        }
    }

    protected void BtnBackWithdraw_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}