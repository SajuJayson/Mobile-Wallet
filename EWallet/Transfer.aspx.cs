using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtbSend_Click(object sender, EventArgs e)
    {
        //eWalletEntities dbcontext = new eWalletEntities();
        ////context.TableName.AddObject(TableEntityInstance);
        //using (var db = new EfContext("name=EfSample"))
        //{
        //    var customers = db.Set<Customer>();
        //    customers.Add(new Customer { CustomerId = id, Name = "John Doe" });

        //    db.SaveChanges();
        //}
        Response.Redirect("ConfirmationForm.aspx");
    }    
    protected void RBtnChange(object sender, EventArgs e)
    {
        
    }

}