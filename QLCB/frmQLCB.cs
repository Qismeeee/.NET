using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using prjDVD;

namespace QLCB
{
    public partial class frmQLCB : Form
    {
        public frmQLCB()
        {
            InitializeComponent();
            getChucVu();
            SetInitialState();
        }

        private void SetInitialState()
        {
            txtMSCB.Enabled = false;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
        }

        private void getChucVu()
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM ChucVu", clsDatabase.con);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dr.Close();
                clsDatabase.CloseConnection();

                cboChucvu.DataSource = dt;
                cboChucvu.DisplayMember = "TenCV";
                cboChucvu.ValueMember = "MaCV";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load chức vụ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "Insert Into CanBo Values(@MSCB, @TenCB, @ChucVuCB, @SoGioGiang, @DonGia)";
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsDatabase.con);

                SqlParameter p1 = new SqlParameter("@MSCB", SqlDbType.Int);
                p1.Value = int.Parse(txtMSCB.Text);

                SqlParameter p2 = new SqlParameter("@TenCB", SqlDbType.NVarChar);
                p2.Value = txtHotenCB.Text;

                SqlParameter p3 = new SqlParameter("@ChucVuCB", SqlDbType.Int);
                p3.Value = cboChucvu.SelectedValue;

                SqlParameter p4 = new SqlParameter("@SoGioGiang", SqlDbType.Int);
                p4.Value = int.Parse(txtSogiogiang.Text);

                SqlParameter p5 = new SqlParameter("@DonGia", SqlDbType.Money);
                p5.Value = decimal.Parse(txtDongia.Text);

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);

                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!!");
                clsDatabase.CloseConnection();
                ResetFields(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsDatabase.OpenConnection();
                SqlCommand com = new SqlCommand("SELECT MAX(MaCB) FROM CanBo", clsDatabase.con);
                object result = com.ExecuteScalar();

                if (result == DBNull.Value)
                {
                    txtMSCB.Text = "1";
                }
                else
                {
                    txtMSCB.Text = (Convert.ToInt32(result) + 1).ToString();
                }

                clsDatabase.CloseConnection();
                ResetFields(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetFields(bool status)
        {
            txtHotenCB.Clear();
            txtSogiogiang.Clear();
            txtDongia.Clear();
            cboChucvu.SelectedIndex = -1;
            btnLuu.Enabled = status;
            btnThem.Enabled = !status;
            txtHotenCB.Focus();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}