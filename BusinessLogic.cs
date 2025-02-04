using CRUD_API.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CRUD_API.Models.BL
{
    public class BusinessLogic
    {
        DataTable dt;
        SqlCon sql;
      
        public DataTable InsertData(Student st)
        {
            
            sql = new SqlCon();
            dt = new DataTable();
            SqlCommand cmd = new SqlCommand("sp_Crud_Tbl", sql.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 2);
            cmd.Parameters.AddWithValue("@FirstName", st.FirstName);
            cmd.Parameters.AddWithValue("@LastName", st.LastName);
            //cmd.Parameters.AddWithValue("@DateOfBirth", Convert.ToDateTime(st.DateOfBirth));
            cmd.Parameters.AddWithValue("@Email", st.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", st.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", st.Address);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            
            da.Fill(dt);
            return dt;
        }

        public DataTable GetData()
          {
            sql = new SqlCon();
            //SqlCommand cmd = new SqlCommand("select * from Employee", sql.con);
            SqlCommand cmd = new SqlCommand("sp_Crud_Tbl", sql.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 1);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

        public DataTable GetId(int StudentId) 
        {
          
            sql = new SqlCon();
            SqlCommand cmd = new SqlCommand("sp_Crud_Tbl", sql.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 3);
            cmd.Parameters.AddWithValue("@StudentID", StudentId);
           
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable UpdateData( Student st)
        {
            sql = new SqlCon();
            SqlCommand cmd = new SqlCommand("sp_Crud_Tbl", sql.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 4);
            cmd.Parameters.AddWithValue("@StudentId", st.StudentId);
            cmd.Parameters.AddWithValue("@FirstName", st.FirstName);
            cmd.Parameters.AddWithValue("@LastName", st.LastName);
            // Uncomment if DateOfBirth is required
            cmd.Parameters.AddWithValue("@DateOfBirth", st.DateOfBirth);
            cmd.Parameters.AddWithValue("@Email", st.Email);
            cmd.Parameters.AddWithValue("@PhoneNumber", st.PhoneNumber);
            cmd.Parameters.AddWithValue("@Address", st.Address);

            //sql.con.Open();
            cmd.ExecuteNonQuery();
            sql.con.Close();
            return dt;
        }

        public DataTable DeleteData(int StudentId)
        {
            sql = new SqlCon();
            SqlCommand cmd = new SqlCommand("sp_Crud_Tbl", sql.con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Ind", 3);
            cmd.Parameters.AddWithValue("@StudentID", StudentId);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

    }
}



   
