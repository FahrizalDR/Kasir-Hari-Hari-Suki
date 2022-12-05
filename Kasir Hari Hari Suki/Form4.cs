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
    public partial class FormEdit : Form
    {
        public FormEdit()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_HariHariSuki";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        public string idTransaksi { get; set; }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            labelIdTransaksi.Text = labelIdTransaksi.Text + idTransaksi;

            DataTable dtNamaMenu = new DataTable();
            sqlQuery = "select ID_MENU, NAMA_MENU from MENU;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNamaMenu);
            cBoxNama.DataSource = dtNamaMenu;
            cBoxNama.DisplayMember = "NAMA_MENU";
            cBoxNama.ValueMember = "ID_MENU";

            DataTable dtHarga = new DataTable();
            sqlQuery = "select ID_MENU, HARGA_MENU from MENU where ID_MENU = '" + cBoxNama.SelectedValue.ToString() + "';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHarga);

            tbHarga.Text = dtHarga.Rows[0][1].ToString();

        }

        private void cBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string cekSama = "";
            DataTable dtMenuYangAda = new DataTable();
            sqlQuery = "select m.NAMA_MENU from MENU m, D_TRANSAKSI d where d.ID_MENU = m.ID_MENU and d.ID_TRANSAKSI = '"+idTransaksi+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMenuYangAda);

            for (int i = 0; i<dtMenuYangAda.Rows.Count; i++)
            {
                if (cBoxNama.Text == dtMenuYangAda.Rows[i][0].ToString())
                {
                    cekSama = "sama";
                    string message1 = "Menu yang ditambah sudah ada!";
                    string title1 = "Error";
                    MessageBox.Show(message1, title1);

                }
            }
            if (cekSama == "")
            {
                sqlQuery = "insert into D_TRANSAKSI values('" + idTransaksi + "', '" + cBoxNama.SelectedValue.ToString() + "', '" + tbJumlah.Text + "','" + tbHarga.Text + "', 0,'F');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
                string message1 = "Penambahan Berhasil!";
                string title1 = "Success";
                MessageBox.Show(message1, title1);
                this.Close();
            }
        }
    }
}
