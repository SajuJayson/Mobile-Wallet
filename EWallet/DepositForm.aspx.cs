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
    int CustId = 1003;
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            Calendar1.Visible =false;
        }
    }

    protected void BtnConfirmDeposit_Click(object sender, EventArgs e)
    {
        ds = cls.checkBankAccNoDetails(Convert.ToInt32( TxtBoxCcNo.Text));
        if (ds == null)
        {
            LabelStatus.Text = "Please Enter Correct Bank Account No";
        }
        else
        {
            ds1 = cls.checkUserId(CustId);
            int balance = Convert.ToInt32(ds1.Tables[0].Rows[0]["Balance"]);

            
                int updatedAmt = balance - Convert.ToInt32(TxtBoxAmount.Text);
                Response.Redirect($"ConfirmationForm.aspx?Task=3&CustID={CustId}&CurBal={balance}&DeductedAmt={"-"+TxtBoxAmount.Text}&updatedAmt={updatedAmt}&BankAccNo={TxtBoxCcNo.Text}");

            

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