using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AcknowledgementForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        eWalletEntities1 dbContext = new eWalletEntities1();
        AccountInfo Acc = new AccountInfo();
        CustomerInfo Cus = new CustomerInfo();
        Acc.Balance= Convert.ToDecimal ( Request.QueryString["RemBal"]);
        Acc.customerid= Convert.ToInt16(Request.QueryString["CustID"]);

        using (var Test = new eWalletEntities1())
        {
            // Mark entity as modified
            dbContext.Entry(Acc).State = System.Data.Entity.EntityState.Modified;

            // Save changes to database
            dbContext.SaveChanges();
        }
        LabelAcknowledgement.Text = "Transcation Successful!";

        //var query = from a in dbContext.CustomerInfoes
        //            join b in dbContext.AccountInfoes on a.CustomerID equals b.customerid
        //            where a.CustomerID == Convert.ToInt16(Request.QueryString["CustID"])
        //            select new { custID = a.CustomerID, AccNo = a.AccountNo, Email = a.Email, Bal = b.Balance };
        //foreach (var item in query)
        //{
        //    . = item.Bal.ToString();
        //    CustID = item.custID.ToString();
        //}

    }

    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
}