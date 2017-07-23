using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    Regex reg= new Regex(@"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*");
    protected void BtbSend_Click(object sender, EventArgs e)
    {

        if (!reg.IsMatch(txtphonemail.Text))
        {
            lblMes.Text = "Please enter valid entry";
        }
        else
        {
        eWalletEntities1 dbcontext = new eWalletEntities1();
        CustomerInfo Customer =  new CustomerInfo();
        using (var dbContext = new eWalletEntities1())
        {
            string balance="";
                string CustID = "";
            if (RbtnType.SelectedValue == "1")
            {
                var query = from a in dbContext.CustomerInfoes
                join b in dbContext.AccountInfoes on a.CustomerID equals b.customerid
                where a.Phone == txtphonemail.Text
                select new { custID = a.CustomerID, Bal = b.Balance };
                foreach (var item in query)
                    {
                        balance = item.Bal.ToString();
                        CustID = item.custID.ToString();
                    }
                }
            else
            {
                var query = from a in dbContext.CustomerInfoes
                join b in dbContext.AccountInfoes on a.CustomerID equals b.customerid
                where a.Email == txtphonemail.Text
                select new { custID = a.CustomerID, Bal = b.Balance };
                    foreach (var item in query)
                    {
                        balance = item.Bal.ToString();
                        CustID = item.custID.ToString();
                    }
            }     
            if(balance=="")
                lblMes.Text = "Phone/Email Number not found";
            else if ( Convert.ToInt16(balance) < Convert.ToInt16(txtbal.Text))
            {
                lblMes.Text = "Oops! Not enough balance!";
            }
            else
                {
                    string updatedAmt = Convert.ToString( Convert.ToInt64(balance) - Convert.ToInt64(txtbal.Text));
                    Response.Redirect("ConfirmationForm.aspx?CustID="+ CustID + "&CurBal=" + balance+"&DeductedAmt="+ txtbal.Text+ "&updatedAmt="+ updatedAmt);
                }
            }
        }

    }    
    protected void RBtnChange(object sender, EventArgs e)
    {
        if (RbtnType.SelectedValue == "2")
        {
            reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            lbltype.Text = "Email ID";
        }
        else
        {
            reg = new Regex(@"\D*([2-9]\d{2})(\D*)([2-9]\d{2})(\D*)(\d{4})\D*");
            lbltype.Text = "Phone Number";
        }
    }

}