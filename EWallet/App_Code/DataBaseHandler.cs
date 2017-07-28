using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for DataBaseHandler
/// </summary>
public class DataBaseHandler
{
    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|Datadirectory|\\Database\\eWallet.mdf;Integrated Security=True;MultipleActiveResultSets=True;Connect Timeout=30;Application Name=EntityFramework");
          
    public DataBaseHandler()
    {          
    }

    public int TransferMoney(int SenderID, int BenificaryID, double Amount)
    {
        conn.Open();
        //SqlCommand command = new SqlCommand("update transaction set CustomerId='" + SenderID + "', BenificaryID='" + BenificaryID + "', TransactionTime=getdate() Amount='" + Amount.ToString() + "', TransactionType='T'", conn);
        SqlCommand cmd = new SqlCommand("UpdateTransfer", conn);
        cmd.Parameters.Add("@SenderID", SqlDbType.VarChar, 100).Value = SenderID;
        cmd.Parameters.Add("@BenificaryID", SqlDbType.VarChar, 100).Value = BenificaryID;
        cmd.Parameters.Add("@Amount", SqlDbType.Money, 100).Value = Amount;
        cmd.CommandType = CommandType.StoredProcedure;
        int result = cmd.ExecuteNonQuery();
        return result;
    }


    public DataSet UserDetails(String Customer, int flag)
    {
        SqlCommand cmd = new SqlCommand("GetUserDetail", conn);
        cmd.Parameters.Add("@Customer", SqlDbType.VarChar, 100).Value = Customer;
        cmd.Parameters.Add("@flag", SqlDbType.VarChar, 100).Value = flag;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }


    public DataSet ShowTransactions(int roll, int customerid)
    {
        SqlCommand cmd = new SqlCommand("GetReport", conn);
        cmd.Parameters.Add("@roll", SqlDbType.Int, 100).Value = roll;
        cmd.Parameters.Add("@CustomerId", SqlDbType.Int, 100).Value = customerid;
        cmd.CommandType = CommandType.StoredProcedure;
        SqlDataAdapter adp = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        adp.Fill(ds);
        return ds;
    }
}