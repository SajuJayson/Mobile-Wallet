﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["userType"] == "1")
        { }

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