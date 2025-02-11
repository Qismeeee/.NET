using System.Data;
using System.Data.SqlClient;

namespace QLTT
{
    public partial class frmThanhtoan : Form
    {
        public frmThanhtoan()
        {
            InitializeComponent();
            LoadPhong();
            SetInitialState();
        }

        private void LoadPhong()
        {
            try
            {
                clsData.OpenConnection();
                string sql = "SELECT *FROM Phong";
                SqlDataAdapter da = new SqlDataAdapter(sql, clsData.con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                cboPhong.DataSource = dt;
                cboPhong.DisplayMember = "TenPhong";
                cboPhong.ValueMember = "MaPhong";
                cboPhong.SelectedIndex = -1;

                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load phòng: " + ex.Message);
            }
        }

        private void SetInitialState()
        {
            txtSoHD.Enabled = false;
            dtpNgayTT.Value = DateTime.Now;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                clsData.OpenConnection();
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(MAX(SoHD), 0) FROM KhachHang", clsData.con);
                int maxHD = Convert.ToInt32(cmd.ExecuteScalar());
                clsData.CloseConnection();

                txtSoHD.Text = (maxHD + 1).ToString();
                txtHoTen.Clear();
                txtCMND.Clear();
                txtSoTien.Clear();
                cboPhong.SelectedIndex = -1;
                dtpNgayTT.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert = "INSERT INTO KhachHang VALUES(@SoHD, @TenKH, @SoCMND, @SoTien, @NgayTT, @Phong)";
                clsData.OpenConnection();
                SqlCommand com = new SqlCommand(strInsert, clsData.con);

                SqlParameter p1 = new SqlParameter("@SoHD", SqlDbType.Int);
                p1.Value = int.Parse(txtSoHD.Text);

                SqlParameter p2 = new SqlParameter("@TenKH", SqlDbType.NVarChar);
                p2.Value = txtHoTen.Text;

                SqlParameter p3 = new SqlParameter("@SoCMND", SqlDbType.VarChar);
                p3.Value = txtCMND.Text;

                SqlParameter p4 = new SqlParameter("@SoTien", SqlDbType.Decimal);
                p4.Value = decimal.Parse(txtSoTien.Text);

                SqlParameter p5 = new SqlParameter("@NgayTT", SqlDbType.DateTime);
                p5.Value = dtpNgayTT.Value;

                SqlParameter p6 = new SqlParameter("@Phong", SqlDbType.Int);
                p6.Value = cboPhong.SelectedValue;

                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.Parameters.Add(p6);

                com.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn thành công!");
                clsData.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
