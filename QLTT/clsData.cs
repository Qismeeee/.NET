using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QLTT
{
    internal class clsData
    {
        public static SqlConnection con;
        public static bool OpenConnection()
        {
            try
            {
                con = new SqlConnection("Server=.;Database=ThanhToan;Integrated Security=True");
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                if (con != null && con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đóng kết nối: " + ex.Message);
                return false;
            }
        }
    }
}