using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
        if (Session["userType"] == "1")
        { }

=======
        Session["Userid"] = "1003";
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
        Session["Userid"] = "1003";
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
<<<<<<< HEAD
<<<<<<< HEAD
=======
        Session["Userid"] = "1003";
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
        Session["Userid"] = "1003";
>>>>>>> 1e59712ebcd767a4a239d4f3d91db27b8ffd4fb3
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
=======
>>>>>>> parent of dce31fb... Merge branch 'master' of https://github.com/SajuJayson/Mobile-Wallet
    }

    protected void BtnTransfer_Click(object sender, EventArgs e)
    {
        Response.Redirect("Transfer.aspx");
    }

    protected void BtnDeposit_Click(object sender, EventArgs e)
    {
        Response.Redirect("DepositForm.aspx");
    }

    protected void BtnWithdraw_Click(object sender, EventArgs e)
    {
        Response.Redirect("BankDetails.aspx");
    }

    protected void BtnReport_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report.aspx");
    }
}