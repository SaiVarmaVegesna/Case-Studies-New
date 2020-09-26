using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OnlineParentEntities;
using System.Data.SqlClient;
using System.Data;


namespace OnlineParentDAL
{
    public class AdoConnected
    {
        public List<Parent> GetAllParent()
        {
            try
            {
                List<Parent> lstParents = new List<Parent>();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select * from tbl_parent", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Parent p = new Parent
                    {
                        parentName = sdr[0].ToString(),
                        password = sdr[1].ToString()

                    };
                    lstParents.Add(p);
                }
                sdr.Close();
                con.Close();

                return lstParents;

            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public List<Messages> GetAllMessage()
        {
            try
            {
                List<Messages> lstMessages = new List<Messages>();

                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select * from tbl_messages", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    Messages m = new Messages
                    {
                        id = (int)sdr[0],
                        parentName = sdr[1].ToString(),
                        subject = sdr[2].ToString(),
                        message = sdr[3].ToString()

                    };
                    lstMessages.Add(m);
                }
                sdr.Close();
                con.Close();

                return lstMessages;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void RegisterUser(Parent p)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("insert into tbl_parent values (@pname,@pwd)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pname", p.parentName);
                cmd.Parameters.AddWithValue("@pwd", p.password);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int Checklogin(Parent p)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from tbl_parent where parentName=@username and password=@password", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", p.parentName);
                cmd.Parameters.AddWithValue("@password", p.password);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Parent pt = null;
                int count = 0;
                if (sdr.Read())
                {
                    pt = new Parent
                    {
                        parentName = sdr[0].ToString(),
                        password = sdr[1].ToString(),
                    };
                    count++;
                }
                con.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int CheckUserRegistration(Parent p)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select * from tbl_parent where parentName=@username", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", p.parentName);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Parent pt = null;
                int count = 0;
                if (sdr.Read())
                {

                    pt = new Parent
                    {
                        parentName = sdr[0].ToString(),
                        password = sdr[1].ToString()
                    };
                    count++;
                }
                con.Close();
                return count;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void PostMessage(string parentName, string subject, string message)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("insert into tbl_messages(parentName,subject,message) values (@pname,@sub,@msg)", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@pname", parentName);
                cmd.Parameters.AddWithValue("@sub", subject);
                cmd.Parameters.AddWithValue("@msg", message);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void GetMessagesBySubject(string sub)
        {
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select * from tbl_messages where subject=@sub", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@sub", sub);

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                Messages m = null;
                if (sdr.Read())
                {
                    m = new Messages
                    {
                        id = (int)sdr[0],
                        parentName = sdr[1].ToString(),
                        subject = sdr[2].ToString(),
                        message = sdr[3].ToString()
                    };
                }

                sdr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<Messages> GetAllSubjects(string sub)
        {
            try
            {
                List<Messages> lstMsg = new List<Messages>();
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Data Source=IN-5CG0255ZNG\SQLEXPRESS;Initial Catalog=DXC;Integrated Security=True";

                SqlCommand cmd = new SqlCommand("select subject from tbl_messages", con);
                cmd.CommandType = CommandType.Text;

                con.Open();

                SqlDataReader sdr = cmd.ExecuteReader();

                Messages msg = null;
                while (sdr.Read())
                {
                    msg = new Messages
                    {
                        subject = sdr[0].ToString()
                    };
                    lstMsg.Add(msg);
                }
                sdr.Close();
                con.Close();
                return lstMsg;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
