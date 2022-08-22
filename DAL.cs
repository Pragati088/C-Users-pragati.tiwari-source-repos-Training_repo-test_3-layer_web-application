using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DALClass
{
    public class DAL
    {
        SqlConnection conn;
        SqlCommand cmd = new SqlCommand();

        public void Insert(int id, string name, string author, string publisher ,decimal price)
        {
            try
            {
                //
                conn = new SqlConnection("Server= DEL1-LHP-N82161\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
                cmd = new SqlCommand("InsertIntoBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", id);
                cmd.Parameters.AddWithValue("@BookName", name);
                cmd.Parameters.AddWithValue("@Author", author);
                cmd.Parameters.AddWithValue("@Publisher", publisher);
                cmd.Parameters.AddWithValue("@Price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("the exception");
            }

        }
        public void Delete(int id)
        {
            try
            {
                conn = new SqlConnection("Server = DEL1-LHP-N82161\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
                cmd = new SqlCommand("DeleteBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", id);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("the exception");
            }
        }
        public void Update(int id, string name, string city, string email,decimal price)
        {
            try
            {
                conn = new SqlConnection("Server = DEL1-LHP-N82161\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
                cmd = new SqlCommand("UpdateBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BookId", id);
                cmd.Parameters.AddWithValue("@BookName", name);
                cmd.Parameters.AddWithValue("@Author", city);
                cmd.Parameters.AddWithValue("@Publisher", email);
                cmd.Parameters.AddWithValue("@Price", price);
                conn.Open();
                cmd.ExecuteNonQuery();
                /////
                conn.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("the exception");
                ////
            }
        }
        public void SelectAll()
        {
            conn = new SqlConnection("Server = DEL1-LHP-N82161\\MSSQLSERVER01;Database = Week5;Integrated Security = SSPI");
            cmd = new SqlCommand("BookDetails", conn);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@BookId", id);
           ///
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }



    }
}
