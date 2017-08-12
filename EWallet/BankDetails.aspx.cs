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
    int CustId = 1003;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void BtnNextWithdraw_Click(object sender, EventArgs e)
    {
        ds = cls.checkBankAccNoDetails(Convert.ToInt32(TextBoxAccountNo.Text));
        if(ds == null)
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