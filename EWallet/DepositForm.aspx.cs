using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DepositForm : System.Web.UI.Page
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
                    Calendar1.Visible = false;
                }
                else
                    Response.Redirect("login.aspx");

            }
            else
                Response.Redirect("login.aspx");
    }

    protected void BtnConfirmDeposit_Click(object sender, EventArgs e)
    {
        ds = cls.checkBankAccNoDetails(Convert.ToInt32( TxtBoxCcNo.Text));
        if (ds.Tables[0].Rows.Count == 0)
        {
            Label6.Text = "Please Enter Correct Bank Account No";
        }
        else
        {
            ds1 = cls.checkUserId(CustId);
            int balance = Convert.ToInt32(ds1.Tables[0].Rows[0]["Balance"]);

            
                int updatedAmt = balance + Convert.ToInt32(TxtBoxAmount.Text);
                Response.Redirect($"ConfirmationForm.aspx?Task=3&CustID={CustId}&CurBal={balance}&DeductedAmt={TxtBoxAmount.Text}&updatedAmt={updatedAmt}&BankAccNo={TxtBoxCcNo.Text}");

            

        }
    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (Calendar1.Visible == false)
        {
            Calendar1.Visible = true;
        }
        else
        {
            Calendar1.Visible = false;
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TxtBoxExDate.Text =Convert.ToString (Calendar1.SelectedDate);
        Calendar1.Visible = false;
    }
}