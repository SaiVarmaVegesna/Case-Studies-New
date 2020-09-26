using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using JuiceShopEntities;
namespace JuiceShopDAL
{
    public class juiceshopDAL
    {
        private List<JuicePurchased> lst;

        public List<juice> GetJuiceFlavors()
        {
            SqlConnection con = new SqlConnection();
       
     
                List<juice> lst = new List<juice>();


                con.ConnectionString = @"Data Source=LAPTOP-6RBV7VQL\SQLEXPRESS;Initial Catalog=JUICESHOP_DB;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select * from  juice", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    juice j = new juice
                    {
                        juice_id = (int)sdr[0],
                        juice_flavor = sdr[1].ToString(),
                        price = (int)sdr[2],

                    };
                    lst.Add(j);
                }
                sdr.Close();

                con.Close();

                return lst;
            
           
            
        }
         public List<JuicePurchased>Totaljuice()
        {
            List<JuicePurchased> l1 = new List<JuicePurchased>();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=LAPTOP-6RBV7VQL\SQLEXPRESS;Initial Catalog=JUICESHOP_DB;Integrated Security=True";

            SqlCommand cmd = new SqlCommand("select * from JuicePurchased", con);
            cmd.CommandType = CommandType.Text;

            con.Open();

            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                JuicePurchased j1 = new JuicePurchased
                {
                   
                    juice_id = (int)sdr[1],
                    quantity = (int)sdr[2],
                    amount = (int)sdr[3]
                };
                l1.Add(j1);
            }
            sdr.Close();
            con.Close();
            return l1;

        }


        public void Removepurchase()
        {
            SqlConnection con = new SqlConnection();

            {
                con.ConnectionString = @"Data Source=LAPTOP-6RBV7VQL\SQLEXPRESS;Initial Catalog=JUICESHOP_DB;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("delete from JuicePurchased", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

            }
                
            
        }



    }
    }

       
    




