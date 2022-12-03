using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kasir_Hari_Hari_Suki
{
    public partial class FormRecap : Form
    {
        public FormRecap()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_HariHariSuki";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void FormRecap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKasir formKasir = new FormKasir();
            formKasir.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvHTransaksi.DataSource = null;
            dgvDTransaksi.DataSource = null;
            DataTable dtHTransaksi = new DataTable();
            sqlQuery = "select ID_TRANSAKSI, TOTAL_TRANSAKSI, PAJAK_TRANSAKSI, METODE_BAYAR from H_TRANSAKSI where TGL_TRANSAKSI = '"+dtpTglTransaksi.Value.ToString("yyyy-MM-dd")+"' and NO_MEJA = '"+cBoxTable.Text.Substring(6)+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHTransaksi);
            dgvHTransaksi.DataSource = dtHTransaksi;

        }

        private void dgvHTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvHTransaksi.SelectedRows.Count > 0)
            {
                DataGridViewRow rowTerpilih = this.dgvHTransaksi.SelectedRows[0];
                DataTable dtDTransaksi = new DataTable();
                sqlQuery = "select m.NAMA_MENU, dt.JUMLAH, dt.HARGA_MENU, dt.SUBTOTAL from D_TRANSAKSI dt, MENU m where dt.ID_TRANSAKSI='" + rowTerpilih.Cells["ID_TRANSAKSI"].Value.ToString() + "' and m.ID_MENU = dt.ID_MENU;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtDTransaksi);
                dgvDTransaksi.DataSource = dtDTransaksi;
            }
        }

        private void dgvDTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDTransaksi.SelectedRows.Count > 0)
            {
                DataGridViewRow rowTerpilih = this.dgvDTransaksi.SelectedRows[0];
                tbUbah.Text = rowTerpilih.Cells["JUMLAH"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow rowTerpilih1 = this.dgvHTransaksi.SelectedRows[0];
            DataGridViewRow rowTerpilih = this.dgvDTransaksi.SelectedRows[0];
            DataTable dtIdMenu = new DataTable();
            sqlQuery = "select ID_MENU from MENU where NAMA_MENU = '"+ rowTerpilih.Cells["NAMA_MENU"].Value.ToString() + "'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdMenu);
            string idMenu = dtIdMenu.Rows[0][0].ToString();
            if (tbUbah.Text == "0")
            {
                sqlQuery = "delete from D_TRANSAKSI where ID_TRANSAKSI = '" + rowTerpilih1.Cells["ID_TRANSAKSI"].Value.ToString() + "' and ID_MENU = '" +idMenu+ "';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                string message1 = "Penghapusan Menu Sudah Berhasil!";
                string title1 = "Success";
                MessageBox.Show(message1, title1);
            }
            else
            {
                sqlQuery = "update D_TRANSAKSI set JUMLAH = "+ tbUbah.Text +" where ID_TRANSAKSI = '"+ rowTerpilih1.Cells["ID_TRANSAKSI"].Value.ToString() + "' and ID_MENU = '"+idMenu+"';";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                string message1 = "Pengeditan Menu Sudah Berhasil!";
                string title1 = "Success";
                MessageBox.Show(message1, title1);
            }
            dgvHTransaksi.DataSource = null;
            dgvDTransaksi.DataSource = null;
            tbUbah.Text = "";
        }

        private void tbUbah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgvHTransaksi.SelectedRows.Count > 0)
            {
                FormEdit formEdit = new FormEdit();
                formEdit.Show();
            }
        }
    }
}
