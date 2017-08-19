using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AccountInfo : System.Web.UI.Page
{
    string Flag,CustID;
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
                    Control c = this.Master.FindControl("login");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("Register");// "masterDiv"= the Id of the div.
                    c.Visible = false;
                    c = this.Master.FindControl("LogOut");// "masterDiv"= the Id of the div.
                    c.Visible = true;
                    Label mpLabel = (Label)Master.FindControl("welcome");
                    mpLabel.Text = "Welcome " + ds.Tables[0].Rows[0]["firstname"];
                    mpLabel.Visible = true;
                    ViewState["Flag"] = ds.Tables[0].Rows[0]["rollid"].ToString();
                    ViewState["CustID"] = ds.Tables[0].Rows[0]["CustomerID"].ToString();
                    LabelCustomerId.Text = ds.Tables[0].Rows[0]["CustomerID"].ToString();
                    LabelFirstName.Text = ds.Tables[0].Rows[0]["FirstName"].ToString();
                    LabelLastName.Text = ds.Tables[0].Rows[0]["LastName"].ToString();
                    LabelEmail.Text = ds.Tables[0].Rows[0]["Email"].ToString();
                    LabelAccountNo.Text = ds.Tables[0].Rows[0]["AccountNo"].ToString();
                    LabelPhoneNo.Text = ds.Tables[0].Rows[0]["Phone"].ToString();
                    LabelRollID.Text = "";
                    if (ds.Tables[0].Rows[0]["rollid"].ToString() == "1")
                        test.Visible = true;
                }
                else
                    Response.Redirect("login.aspx");

            }
            else
                Response.Redirect("login.aspx");
    }
   

    protected void BtnTransactionHistory_Click(object sender, EventArgs e)
    {
        Response.Redirect("Report.aspx?Flag="+ ViewState["Flag"] + " &CustID="+ ViewState["CustID"]);
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

    protected void Check(object sender, EventArgs e)
    {
        Response.Redirect("UpdateCustomer.aspx");
    }
}