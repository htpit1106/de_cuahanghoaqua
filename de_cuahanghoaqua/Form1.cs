using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de_cuahanghoaqua
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string chuoiketnoi = "Data Source=DESKTOP-GE1C4PK\\SQLEXPRESS;Initial Catalog=hoaqua;Integrated Security=True";
        SqlCommand cmd;
        SqlDataAdapter adapter = new SqlDataAdapter(); 
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }
        List<hoaqua> list = new List<hoaqua>()
        {
            new hoaqua(){loaihoaqua = "tao", dongia="100"},
            new hoaqua(){loaihoaqua = "cam", dongia="200"},
            new hoaqua(){loaihoaqua = "buoi", dongia="300"},
            new hoaqua(){loaihoaqua = "le", dongia="400"}
        };
        int tong;
        void loadData()
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = "select * from loaihoaqua";
            adapter.SelectCommand = cmd;
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(chuoiketnoi);
           conn.Open();
            cb_loaihoaqua.DataSource = list;
            cb_loaihoaqua.DisplayMember = "loaihoaqua";
            loadData();

        }
        class hoaqua
        {
            public string loaihoaqua { get; set; }
            public string dongia { get; set; }  
        }

        private void cb_loaihoaqua_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;   
            hoaqua x = cb.SelectedItem as hoaqua;
            tb_dongia.Text = x.dongia;
        }
        void runcommand( string query)
        {
            cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
        }

        private void btt_them_Click(object sender, EventArgs e)
        {
            int thanhtien =  Convert.ToInt32(tb_dongia.Text) * (int)num_soluong.Value;
            tong += thanhtien;

        
            if (num_soluong.Value == 0)
            {
                MessageBox.Show("so luong bang 0 ");
                num_soluong.Focus();
                return;

            }
            string query = "insert into loaihoaqua ([Tên sản phẩm], [Đơn giá], [Số lượng], [Thành tiền])values" +
                " ('"+cb_loaihoaqua.Text+"', '"+tb_dongia.Text+"', '"+num_soluong.Value.ToString()+"', '"+thanhtien.ToString()+"')";
            runcommand(query);
            loadData();
            tb_tongtien.Text = tong.ToString();
        }

        private void btt_xoa_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            i = (int)dataGridView1.Rows[i].Cells[0].Value;
            string query = "delete from loaihoaqua where STT = " + i;
            runcommand(query);
            loadData();
        }

        private void btt_hoanThanh_Click(object sender, EventArgs e)
        {
            ulong checktienkhach;
            if(ulong.TryParse(tb_tienkhach.Text, out checktienkhach)== false)
            {
                MessageBox.Show("tien khach dua chua dung");
                tb_tienkhach.Focus();
                return;
            }
 
            string query = "delete from loaihoaqua";
            runcommand(query);
            loadData();

        }


        private void tb_tienkhach_Leave(object sender, EventArgs e)
        {

            if (tb_tienkhach != null)
                tb_tientralai.Text = (Convert.ToInt32(tb_tienkhach.Text) - tong).ToString();
        }
    }
}
