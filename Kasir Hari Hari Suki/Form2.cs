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
    public partial class FormKasir : Form
    {

        public string idStaff { get; set; }
        public string NamaStaff { get; set; }

        public FormKasir()
        {
            InitializeComponent();
        }

        public static string sqlConnection = "server=139.255.11.84;uid=student;pwd=isbmantap;database=SAD_HariHariSuki";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); // sbg data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; // memindahkan query
        public MySqlDataAdapter sqlAdapter; // penampung data
        public MySqlDataReader sqlDataReader;
        public string sqlQuery;
        DataTable dtPenjualan = new DataTable();
        DataColumn dtColumn;
        DataRow dtRow;
        int quantityTomYum = 0;
        int quantityOdeng = 0;
        int quantitySuki = 0;
        int quantityNasi = 0;
        int quantityTopokki = 0;
        int quantityEsTeh = 0;
        int quantityTehPanas = 0;
        int quantityKopi = 0;
        int quantityEsKopi = 0;
        int quantityAir = 0;
        int quantityCola = 0;
        int quantityFanta = 0;
        int quantitySprite = 0;

        private void FormKasir_Load(object sender, EventArgs e)
        {

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(string);
            dtColumn.ColumnName = "Item";
            dtColumn.Caption = "Item";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = true;

            dtPenjualan.Columns.Add(dtColumn);

            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "Harga";
            dtColumn.Caption = "Harga";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPenjualan.Columns.Add(dtColumn);


            dtColumn = new DataColumn();
            dtColumn.DataType = typeof(int);
            dtColumn.ColumnName = "Quantity";
            dtColumn.Caption = "Quantity";
            dtColumn.ReadOnly = false;
            dtColumn.Unique = false;

            dtPenjualan.Columns.Add(dtColumn);

            dgvPenjualan.DataSource = dtPenjualan;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private void btnPlusTomYum_Click(object sender, EventArgs e)
        {
            int barisTomYum = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Tom Yum";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityTomYum++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Tom Yum")
                    {
                        quantityTomYum = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityTomYum + 1;
                    }
                }
                while (dtPenjualan.Rows[barisTomYum]["Item"].ToString() != "Tom Yum")
                {
                    barisTomYum++;
                    if (barisTomYum == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Tom Yum";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityTomYum++;
                    }
                }
            }
        }
        

        private void btnPlusOdeng_Click(object sender, EventArgs e)
        {
            int barisOdeng = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Odeng";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityOdeng++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Odeng")
                    {
                        quantityOdeng = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityOdeng + 1;
                    }
                }
                while (dtPenjualan.Rows[barisOdeng]["Item"].ToString() != "Odeng")
                {
                    barisOdeng++;
                    if(barisOdeng == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Odeng";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityOdeng++;
                    }
                }
            }
        }

        private void btnPlusSuki_Click(object sender, EventArgs e)
        {
            int barisSuki = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Suki";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantitySuki++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Suki")
                    {
                        quantitySuki = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantitySuki + 1;
                    }
                }
                while (dtPenjualan.Rows[barisSuki]["Item"].ToString() != "Suki")
                {
                    barisSuki++;
                    if (barisSuki == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Suki";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantitySuki++;
                    }
                }
            }
        }

        private void btnPlusNasi_Click(object sender, EventArgs e)
        {
            int barisNasi = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Nasi";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantitySuki++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Nasi")
                    {
                        quantityNasi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityNasi + 1;
                    }
                }
                while (dtPenjualan.Rows[barisNasi]["Item"].ToString() != "Nasi")
                {
                    barisNasi++;
                    if (barisNasi == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Nasi";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityNasi++;
                    }
                }
            }
        }

        private void btnPlusTopokki_Click(object sender, EventArgs e)
        {
            int barisTopokki = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Topokki";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityTopokki++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Topokki")
                    {
                        quantityTopokki = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityTopokki + 1;
                    }
                }
                while (dtPenjualan.Rows[barisTopokki]["Item"].ToString() != "Topokki")
                {
                    barisTopokki++;
                    if (barisTopokki == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Topokki";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityTopokki++;
                    }
                }
            }
        }

        private void btnPlusEsTeh_Click(object sender, EventArgs e)
        {
            int barisEsteh = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Es Teh";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityEsTeh++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Es Teh")
                    {
                        quantityEsTeh = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityEsTeh + 1;
                    }
                }
                while (dtPenjualan.Rows[barisEsteh]["Item"].ToString() != "Es Teh")
                {
                    barisEsteh++;
                    if (barisEsteh == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Es Teh";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityEsTeh++;
                    }
                }
            }
        }

        private void btnPlusTehPanas_Click(object sender, EventArgs e)
        {
            int barisTehPanas = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Teh Panas";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityTehPanas++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Teh Panas")
                    { 
                        quantityTehPanas = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityTehPanas + 1;
                    }
                }
                while (dtPenjualan.Rows[barisTehPanas]["Item"].ToString() != "Teh Panas")
                {
                    barisTehPanas++;
                    if (barisTehPanas == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Teh Panas";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityTehPanas++;
                    }
                }
            }
        }

        private void btnPlusKopi_Click(object sender, EventArgs e)
        {
            int barisKopi = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Kopi";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantitySuki++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Kopi")
                    {
                        quantityKopi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityKopi + 1;
                    }
                }
                while (dtPenjualan.Rows[barisKopi]["Item"].ToString() != "Kopi")
                {
                    barisKopi++;
                    if (barisKopi == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Kopi";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityKopi++;
                    }
                }
            }
        }

        private void btnPlusEsKopi_Click(object sender, EventArgs e)
        {
            int barisEskopi = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Es Kopi";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityEsKopi++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Es Kopi")
                    {
                        quantityEsKopi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityEsKopi + 1;
                    }
                }
                while (dtPenjualan.Rows[barisEskopi]["Item"].ToString() != "Es Kopi")
                {
                    barisEskopi++;
                    if (barisEskopi == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Es Kopi";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityEsKopi++;
                    }
                }
            }
        }

        private void btnPlusAir_Click(object sender, EventArgs e)
        {
            int barisAir = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Air Mineral";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityAir++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Air Mineral")
                    {
                        quantityAir = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityAir + 1;
                    }
                }
                while (dtPenjualan.Rows[barisAir]["Item"].ToString() != "Air Mineral")
                {
                    barisAir++;
                    if (barisAir == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Air Mineral";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityAir++;
                    }
                }
            }
        }

        private void btnPlusCola_Click(object sender, EventArgs e)
        {
            int barisCola = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Coca Cola";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityCola++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Coca Cola")
                    {
                        quantityCola = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityCola + 1;
                    }
                }
                while (dtPenjualan.Rows[barisCola]["Item"].ToString() != "Coca Cola")
                {
                    barisCola++;
                    if (barisCola == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Coca Cola";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityCola++;
                    }
                }
            }
        }

        private void btnPlusFanta_Click(object sender, EventArgs e)
        {
            int barisFanta = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Fanta";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantityFanta++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Fanta")
                    {
                        quantityFanta = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantityFanta + 1;
                    }
                }
                while (dtPenjualan.Rows[barisFanta]["Item"].ToString() != "Fanta")
                {
                    barisFanta++;
                    if (barisFanta == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Fanta";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantityFanta++;
                    }
                }
            }
        }

        private void btnPlusSprite_Click(object sender, EventArgs e)
        {
            int barisSprite = 0;
            if (dtPenjualan.Rows.Count == 0)
            {
                dtRow = dtPenjualan.NewRow();
                dtRow["Item"] = "Sprite";
                dtRow["Harga"] = 5000;
                dtRow["Quantity"] = 1;
                dtPenjualan.Rows.Add(dtRow);
                quantitySprite++;
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                {
                    if (dtPenjualan.Rows[i]["Item"].ToString() == "Sprite")
                    {
                        quantitySprite = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                        dtPenjualan.Rows[i]["Quantity"] = quantitySprite + 1;
                    }
                }
                while (dtPenjualan.Rows[barisSprite]["Item"].ToString() != "Sprite")
                {
                    barisSprite++;
                    if (barisSprite == dtPenjualan.Rows.Count)
                    {
                        dtRow = dtPenjualan.NewRow();
                        dtRow["Item"] = "Sprite";
                        dtRow["Harga"] = 5000;
                        dtRow["Quantity"] = 1;
                        dtPenjualan.Rows.Add(dtRow);
                        quantitySprite++;
                    }
                }
            }
        }

        private void btnMinTomYum_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Tom Yum")
                {
                    quantityTomYum = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityTomYum == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Tom Yum")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityTomYum - 1;
                    }
                }
            }
        }

        private void btnMinOdeng_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Odeng")
                {
                    quantityOdeng = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityOdeng == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Odeng")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityOdeng - 1;
                    }
                }
            }
        }

        private void btnMinSuki_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Suki")
                {
                    quantitySuki = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantitySuki == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Suki")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantitySuki - 1;
                    }
                }
            }
        }

        private void btnMinNasi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Nasi")
                {
                    quantityNasi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityNasi == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Nasi")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityNasi - 1;
                    }
                }
            }
        }

        private void btnMinTopokki_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Topokki")
                {
                    quantityTopokki = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityTopokki == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Topokki")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityTopokki - 1;
                    }
                }
            }
        }

        private void btnMinEsTeh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Es Teh")
                {
                    quantityEsTeh = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityEsTeh == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Es Teh")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityEsTeh - 1;
                    }
                }
            }
        }

        private void btnMinTehPanas_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Teh Panas")
                {
                    quantityTehPanas = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityTehPanas == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Teh Panas")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityTehPanas - 1;
                    }
                }
            }
        }

        private void btnMinKopi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Kopi")
                {
                    quantityKopi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityKopi == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Kopi")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityKopi - 1;
                    }
                }
            }
        }

        private void btnMinEsKopi_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Es Kopi")
                {
                    quantityEsKopi = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityEsKopi == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Es Kopi")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityEsKopi - 1;
                    }
                }
            }
        }

        private void btnMinAir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Air Mineral")
                {
                    quantityAir = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityAir == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Air Mineral")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityAir - 1;
                    }
                }
            }
        }

        private void btnMinCola_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Coca Cola")
                {
                    quantityCola = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityCola == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Coca Cola")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityCola - 1;
                    }
                }
            }
        }

        private void btnMinFanta_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Fanta")
                {
                    quantityFanta = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantityFanta == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Fanta")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantityFanta - 1;
                    }
                }
            }
        }

        private void btnMinSprite_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                if (dtPenjualan.Rows[i]["Item"].ToString() == "Sprite")
                {
                    quantitySprite = int.Parse(dtPenjualan.Rows[i]["Quantity"].ToString());
                    if (quantitySprite == 1)
                    {
                        DataRow dr = dtPenjualan.Rows[i];
                        if (dr["Item"].ToString() == "Sprite")
                        {
                            dr.Delete();
                        }
                    }
                    else
                    {
                        dtPenjualan.Rows[i]["Quantity"] = quantitySprite - 1;
                    }
                }
            }
        }

        private void btnVoid_Click(object sender, EventArgs e)
        {
            dtPenjualan.Rows.Clear();
        }

        private void brnRecap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRecap formRecap = new FormRecap();
            formRecap.Show();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string nomorTable = "";
            string metodeBayar = "";
            if(cbQris.Checked == true)
            {
                metodeBayar = cbQris.Text;
            }
            if (cbTunai.Checked == true)
            {
                metodeBayar = cbTunai.Text;
            }
            if (RBTable1.Checked == true)
            {
                nomorTable = RBTable1.Text.Substring(6);
            }
            if (RBTable2.Checked == true)
            {
                nomorTable = RBTable2.Text.Substring(6);
            }
            if (RBTable3.Checked == true)
            {
                nomorTable = RBTable3.Text.Substring(6);
            }
            if (RBTable4.Checked == true)
            {
                nomorTable = RBTable4.Text.Substring(6);
            }
            if (RBTable5.Checked == true)
            {
                nomorTable = RBTable5.Text.Substring(6);
            }
            if (RBTable6.Checked == true)
            {
                nomorTable = RBTable6.Text.Substring(6);
            }
            if (RBTable7.Checked == true)
            {
                nomorTable = RBTable7.Text.Substring(6);
            }
            if (RBTable8.Checked == true)
            {
                nomorTable = RBTable8.Text.Substring(6);
            }
            if (dtPenjualan.Rows.Count == 0)
            {
                string message = "Input salah! \n Tidak ada input pembelian menu!";
                string title = "Error";
                MessageBox.Show(message, title);
            }
            else if (dtPenjualan.Rows.Count > 0)
            {
                if (metodeBayar == "" && nomorTable != "")
                {
                    string message1 = "Input salah! \n Tidak ada input metode pembayaran!";
                    string title1 = "Error";
                    MessageBox.Show(message1, title1);
                }
                else if (metodeBayar != "" && nomorTable == "")
                {
                    string message1 = "Input salah! \n Tidak ada input nomor table!";
                    string title1 = "Error";
                    MessageBox.Show(message1, title1);
                }
                else if(metodeBayar == "" && nomorTable == "")
                {
                    string message1 = "Input salah! \n Tidak ada input nomor table dan metode pembayaran!";
                    string title1 = "Error";
                    MessageBox.Show(message1, title1);
                }
                else
                {
                    string idTransaksi = "";
                    sqlQuery = "insert into H_TRANSAKSI values('T','" + idStaff + "',curdate()," + nomorTable + ", 0, 0, '" + metodeBayar + "', 'F');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    DataTable dtIdTransaksi = new DataTable();
                    sqlQuery = "select ID_TRANSAKSI from H_TRANSAKSI order by 1 desc limit 1;";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtIdTransaksi);
                    idTransaksi = dtIdTransaksi.Rows[0][0].ToString();

                    for (int i = 0; i < dtPenjualan.Rows.Count; i++)
                    {
                        sqlQuery = "insert into D_TRANSAKSI values('"+idTransaksi+"', (select ID_MENU from MENU where NAMA_MENU = '" + dtPenjualan.Rows[i]["Item"].ToString() + "'), " + dtPenjualan.Rows[i]["Quantity"].ToString() + ", " + dtPenjualan.Rows[i]["Harga"].ToString() + ", 0, 'F');";
                        sqlConnect.Open();
                        sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                        sqlCommand.ExecuteNonQuery();
                        sqlConnect.Close();
                    }
                    PrintDialog printdialog1 = new PrintDialog();
                    printdialog1.Document = printDocument1;

                    DialogResult result = printdialog1.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        printPreviewDialog1.Document = printDocument1;
                        printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);
                        printPreviewDialog1.ShowDialog();
                    }

                    string message = "Pembelian Telah Terkonfirmasi";
                    string title = "Konfirmasi";
                    MessageBox.Show(message, title);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string idTransaksi = "";
            DataTable dtIdTransaksi = new DataTable();
            sqlQuery = "select ID_TRANSAKSI from H_TRANSAKSI order by 1 desc limit 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtIdTransaksi);
            idTransaksi = dtIdTransaksi.Rows[0][0].ToString();

            DataTable dtDTrans = new DataTable();
            sqlQuery = "select concat('Rp ', format(d.SUBTOTAL,0,'id_ID')), concat('Rp ', format(d.HARGA_MENU,0,'id_ID')), m.NAMA_MENU, d.JUMLAH  from D_TRANSAKSI d, MENU m where d.ID_TRANSAKSI = '"+idTransaksi+"' and m.ID_MENU = d.ID_MENU;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDTrans);

            DataTable dtHTrans = new DataTable();
            sqlQuery = "select NO_MEJA, METODE_BAYAR, concat('Rp ', format(TOTAL_TRANSAKSI - PAJAK_TRANSAKSI,0,'id_ID')), concat('Rp ', format(TOTAL_TRANSAKSI,0,'id_ID')), concat('Rp ', format(PAJAK_TRANSAKSI,0,'id_ID')) from H_TRANSAKSI where ID_TRANSAKSI = '" + idTransaksi+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHTrans);

            e.Graphics.DrawString("HARIHARISUKI", new Font("Arial", 14, FontStyle.Bold), Brushes.Black, new Point(75, 10));
            e.Graphics.DrawString("Sale Recipt", new Font("Arial", 11, FontStyle.Bold), Brushes.Black, new Point(100, 40));

            e.Graphics.DrawString("_______________________________________________________________________________________________________________________________________________________________________________________________________________________________________", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(0, 100));
            e.Graphics.DrawString("Order    : " + idTransaksi.Substring(9), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(15, 140));
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(200, 140));
            e.Graphics.DrawString("Cashier : " + NamaStaff, new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(15, 160));
            e.Graphics.DrawString(DateTime.Now.ToString("hh:mm:ss"), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(213, 160));
            e.Graphics.DrawString("Table    : " + dtHTrans.Rows[0][0].ToString(), new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(15, 180));

            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString("Item Name", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(15, 220));
            e.Graphics.DrawString("Price", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(170, 220));
            e.Graphics.DrawString("Subtotal", new Font("Arial", 8, FontStyle.Regular), Brushes.Black, new Point(220, 220));
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, 240));

            int baris = 260;
            for (int i = 0; i < dtPenjualan.Rows.Count; i++)
            {
                e.Graphics.DrawString(dtDTrans.Rows[i][2].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(15, baris));
                e.Graphics.DrawString(dtDTrans.Rows[i][1].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(170, baris));
                baris = baris + 10;
                e.Graphics.DrawString(dtDTrans.Rows[i][3].ToString() + "x", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(25, baris));
                e.Graphics.DrawString(dtDTrans.Rows[i][0].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
                baris = baris + 20;
            }
            e.Graphics.DrawString("---------------------------------------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(10, baris));
            baris += 20;

            e.Graphics.DrawString("Total Amount : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString(dtHTrans.Rows[0][2].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 20;
            e.Graphics.DrawString("Tax (10%)     : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString(dtHTrans.Rows[0][4].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 10;
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(145, baris));
            baris += 20;
            e.Graphics.DrawString("Total to Pay  : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString(dtHTrans.Rows[0][3].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 20;
            e.Graphics.DrawString("Pay Method   : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString(dtHTrans.Rows[0][1].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 10;
            e.Graphics.DrawString("-----------------------------", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(145, baris));
            baris += 20;
            e.Graphics.DrawString("Received     : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString(dtHTrans.Rows[0][3].ToString(), new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 20;
            e.Graphics.DrawString("Change       : ", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(150, baris));
            e.Graphics.DrawString("Rp  0", new Font("Arial", 6, FontStyle.Regular), Brushes.Black, new Point(220, baris));
            baris += 40;
            e.Graphics.DrawString("THANKYOU FOR PURCHASING!", new Font("Arial", 8, FontStyle.Bold), Brushes.Black, new Point(60, baris));

        }
    }
}
