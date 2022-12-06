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
    public partial class FormOwner : Form
    {
        public FormOwner()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_HariHariSuki";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void FormOwner_Load(object sender, EventArgs e)
        {
            labelLaporan.Text = "";
            labelPendapatan.Text = "";

            DataTable dtTahun = new DataTable();
            sqlQuery = "select date_format(TGL_TRANSAKSI, '%Y') as 'TGL' from H_TRANSAKSI group by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTahun);
            cBoxTahun.DataSource = dtTahun;
            cBoxTahun.DisplayMember = "TGL";
            cBoxTahun.ValueMember = "TGL";

            DataTable dtBulan = new DataTable();
            sqlQuery = "select date_format(TGL_TRANSAKSI, '%M') as 'TGL', date_format(TGL_TRANSAKSI, '%m') as 'TglAngka' from H_TRANSAKSI group by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtBulan);
            cBoxBulan.DataSource = dtBulan;
            cBoxBulan.DisplayMember = "TGL";
            cBoxBulan.ValueMember = "TglAngka";

            DataTable dtTanggal = new DataTable();
            sqlQuery = "select date_format(TGL_TRANSAKSI, '%d') from H_TRANSAKSI group by 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTanggal);
            cBoxTanggal.DataSource = dtTanggal;
            cBoxTanggal.DisplayMember = "date_format(TGL_TRANSAKSI, '%d')";
            cBoxTanggal.ValueMember = "date_format(TGL_TRANSAKSI, '%d')";

            DataTable dtMenuLaris = new DataTable();
            sqlQuery = "select * from vMenuPalingLaris;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMenuLaris);
            dgvMenuLaris.DataSource = dtMenuLaris;

            DataTable dtInfoHarga = new DataTable();
            sqlQuery = "select * from vInfoPerubahanHarga;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtInfoHarga);
            dgvInfoHarga.DataSource = dtInfoHarga;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtRecap = new DataTable();
            DataTable dtPendapatan = new DataTable();
            DataTable dtPendapatanQris = new DataTable();
            if (cBoxTanggal.Text == "" && cBoxBulan.Text == "" && cBoxTahun.Text != "")
            {
                sqlQuery = "call pRekapTahunan('" + cBoxTahun.Text  + "')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRecap);
                dgvRecap.DataSource = dtRecap;

                sqlQuery = "select fPendapatanTahunan(" + cBoxTahun.Text + ");";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPendapatan);
                labelPendapatan.Text = dtPendapatan.Rows[0][0].ToString();
                labelLaporan.Text = "Laporan penjualan menu pada " + cBoxTahun.Text;

            }
            else if (cBoxTanggal.Text == "" && cBoxBulan.Text != "" && cBoxTahun.Text != "")
            {
                sqlQuery = "call pRekapBulanan('" + cBoxTahun.Text + cBoxBulan.SelectedValue.ToString() + cBoxTanggal.Text + "')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRecap);
                dgvRecap.DataSource = dtRecap;

                sqlQuery = "select fPendapatanBulanan(" + cBoxTahun.Text + cBoxBulan.SelectedValue.ToString() + cBoxTanggal.Text + ");";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPendapatan);
                labelPendapatan.Text = dtPendapatan.Rows[0][0].ToString();
                labelLaporan.Text = "Laporan penjualan menu pada " + cBoxBulan.Text +" "+ cBoxTahun.Text;
            }
            else if (cBoxTanggal.Text != "" && cBoxBulan.Text != "" && cBoxTahun.Text != "")
            {
                sqlQuery = "call pRekapHarian('" + cBoxTahun.Text + cBoxBulan.SelectedValue.ToString() + cBoxTanggal.Text + "')";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtRecap);
                dgvRecap.DataSource = dtRecap;

                sqlQuery = "select fPendapatanHarianTunai(" + cBoxTahun.Text + cBoxBulan.SelectedValue.ToString() + cBoxTanggal.Text + ");";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPendapatan);
                sqlQuery = "select fPendapatanHarianQris(" + cBoxTahun.Text + cBoxBulan.SelectedValue.ToString() + cBoxTanggal.Text + ");";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPendapatanQris);
                labelPendapatan.Text = dtPendapatan.Rows[0][0].ToString() + "\n" + dtPendapatanQris.Rows[0][0].ToString();
                labelLaporan.Text = "Laporan penjualan menu pada " + cBoxTanggal.Text + " " + cBoxBulan.Text + " " + cBoxTahun.Text;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
