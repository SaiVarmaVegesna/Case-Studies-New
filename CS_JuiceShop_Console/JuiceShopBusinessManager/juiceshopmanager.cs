using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using JuiceShopDAL;
using Entities;
namespace JuiceShopBusinessManager
{
    public class juiceshopmanager
    {
        public List<juice> Flavors()
        {

        juiceshopDAL a = new juiceshopDAL();
            List<juice> l = a.GetJuiceFlavors();

            return l;
        }

        public void purchasedjuice(int juice_id, int quantity)
        {

            SqlConnection con = new SqlConnection();


            List<JuicePurchased> lst = new List<JuicePurchased>();


            con.ConnectionString = @"Data Source=LAPTOP-6RBV7VQL\SQLEXPRESS;Initial Catalog=JUICESHOP_DB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("insert into JuicePurchased(juice_id,quantity) values(@jid,@qty)", con);
            con.Open();
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@jid", juice_id);
            cmd.Parameters.AddWithValue("@qty", quantity);

            SqlCommand cmd1 = new SqlCommand("update JuicePurchased set JuicePurchased.amount = jp.quantity * j.price from JuicePurchased jp inner join juice j on jp.juice_id = j.juice_id", con);
            cmd1.CommandType = CommandType.Text;

            cmd.ExecuteNonQuery();
            cmd1.ExecuteNonQuery();
            con.Close();
        }
        public List<JuicePurchased> Totaljuice()
        {
            juiceshopDAL a = new juiceshopDAL();

            List<JuicePurchased> l2 = a.Totaljuice()
            return l2;


        }
        public void removedata()
        {
            juiceshopDAL a = new juiceshopDAL();
            a.Removepurchase();
        }
    }
}
