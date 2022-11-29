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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_HariHariSuki";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;

        private void FormLogin_Load(object sender, EventArgs e)
        {
            labelPasswordSalah.Text = "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            DataTable dtStaff = new DataTable();
            sqlQuery = "select NAMA_STAFF from STAFF where NAMA_STAFF = '"+textBoxUsername.Text+"' and PASS_STAFF = '"+textBoxPassword.Text+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStaff);

            if (dtStaff.Rows.Count > 0)
            {
                this.Hide();
                FormKasir formKasir = new FormKasir();
                formKasir.Show();
            }
            else if (dtStaff.Rows.Count == 0)
            {
                labelPasswordSalah.Text = "Password Anda Salah!";
                textBoxUsername.Text = "Username";
                textBoxPassword.Text = "Password";
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void textBoxUsername_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
