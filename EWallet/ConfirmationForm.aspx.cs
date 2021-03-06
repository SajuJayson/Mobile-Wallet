﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class ConfirmationForm : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ViewState["RefUrl"] = Request.UrlReferrer.ToString();
        }
        LabelCurrentBalance.Text = Request.QueryString["CurBal"];
        LabelAmountDeducted.Text= Request.QueryString["DeductedAmt"];
        LabelUpdatedBalance.Text = Request.QueryString["updatedAmt"];
       
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataBaseHandler cls = new DataBaseHandler();
        

        if("1"==Request.QueryString["Task"])
        {
            int result = cls.TransferMoney(Convert.ToInt16(Session["Userid"]), Convert.ToInt32(Request.QueryString["CustID"]), Convert.ToDouble(Request.QueryString["DeductedAmt"]));
            if (result == 0)
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Fail");

            }
            else
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Pass");

            }
        }else if("2" == Request.QueryString["Task"])
        {
            int result = cls.WithdrawMoney(Convert.ToInt32(Request.QueryString["CustID"]), Convert.ToInt32(Request.QueryString["BankAccNo"]), Convert.ToDouble(Request.QueryString["DeductedAmt"]));
            if (result == 0)
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Fail");

            }
            else
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Pass");

            }
        }
        else if ("3" == Request.QueryString["Task"])
        {
            int result = cls.DepositMoney(Convert.ToInt32(Request.QueryString["CustID"]), Convert.ToInt32(Request.QueryString["BankAccNo"]), Convert.ToDouble(Request.QueryString["DeductedAmt"]));
            if (result == 0)
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Fail");

            }
            else
            {
                Response.Redirect("AcknowledgementForm.aspx?RemBal=" + Request.QueryString["updatedAmt"] + "&CustID=" + Request.QueryString["CustID"] + "&Status=Pass");

            }
        }

       
    }
    protected void BtnConfirm_Click(object sender, EventArgs e)
    {
        object refUrl = ViewState["RefUrl"];
        if (refUrl != null)
            Response.Redirect((string)refUrl);
    }
}