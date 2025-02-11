using System;
using System.Data;
using System.Data.SqlClient;

namespace prjDVD
{
    class clsDatabase
    {
        public static SqlConnection con;

        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=Qismeeee; Database=QLCB;Integrated Security=True");
                con.Open();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static bool CloseConnection()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
