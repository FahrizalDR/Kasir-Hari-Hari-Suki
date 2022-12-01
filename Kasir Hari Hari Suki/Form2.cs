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
                quantitySuki++;
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
                        quantitySuki++;
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
    }
}
