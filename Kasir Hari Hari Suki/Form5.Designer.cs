
namespace Kasir_Hari_Hari_Suki
{
    partial class FormOwner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelBulan = new System.Windows.Forms.Label();
            this.labelTgl = new System.Windows.Forms.Label();
            this.dgvRecap = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelTahun = new System.Windows.Forms.Label();
            this.cBoxTahun = new System.Windows.Forms.ComboBox();
            this.cBoxBulan = new System.Windows.Forms.ComboBox();
            this.cBoxTanggal = new System.Windows.Forms.ComboBox();
            this.labelJudul = new System.Windows.Forms.Label();
            this.labelPendapatan = new System.Windows.Forms.Label();
            this.labelLaporan = new System.Windows.Forms.Label();
            this.dgvMenuLaris = new System.Windows.Forms.DataGridView();
            this.dgvInfoHarga = new System.Windows.Forms.DataGridView();
            this.labelMenuLaris = new System.Windows.Forms.Label();
            this.labelInfoHarga = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuLaris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoHarga)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBulan
            // 
            this.labelBulan.AutoSize = true;
            this.labelBulan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBulan.Location = new System.Drawing.Point(267, 99);
            this.labelBulan.Name = "labelBulan";
            this.labelBulan.Size = new System.Drawing.Size(47, 13);
            this.labelBulan.TabIndex = 24;
            this.labelBulan.Text = "Bulan :";
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgl.Location = new System.Drawing.Point(493, 99);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(61, 13);
            this.labelTgl.TabIndex = 23;
            this.labelTgl.Text = "Tanggal :";
            // 
            // dgvRecap
            // 
            this.dgvRecap.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvRecap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecap.Location = new System.Drawing.Point(36, 204);
            this.dgvRecap.Name = "dgvRecap";
            this.dgvRecap.Size = new System.Drawing.Size(396, 331);
            this.dgvRecap.TabIndex = 20;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(840, 99);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(759, 98);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelTahun
            // 
            this.labelTahun.AutoSize = true;
            this.labelTahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTahun.Location = new System.Drawing.Point(33, 98);
            this.labelTahun.Name = "labelTahun";
            this.labelTahun.Size = new System.Drawing.Size(51, 13);
            this.labelTahun.TabIndex = 26;
            this.labelTahun.Text = "Tahun :";
            // 
            // cBoxTahun
            // 
            this.cBoxTahun.FormattingEnabled = true;
            this.cBoxTahun.Location = new System.Drawing.Point(90, 95);
            this.cBoxTahun.Name = "cBoxTahun";
            this.cBoxTahun.Size = new System.Drawing.Size(153, 21);
            this.cBoxTahun.TabIndex = 27;
            // 
            // cBoxBulan
            // 
            this.cBoxBulan.FormattingEnabled = true;
            this.cBoxBulan.Location = new System.Drawing.Point(320, 95);
            this.cBoxBulan.Name = "cBoxBulan";
            this.cBoxBulan.Size = new System.Drawing.Size(153, 21);
            this.cBoxBulan.TabIndex = 28;
            // 
            // cBoxTanggal
            // 
            this.cBoxTanggal.FormattingEnabled = true;
            this.cBoxTanggal.Location = new System.Drawing.Point(560, 95);
            this.cBoxTanggal.Name = "cBoxTanggal";
            this.cBoxTanggal.Size = new System.Drawing.Size(153, 21);
            this.cBoxTanggal.TabIndex = 29;
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Superstar M54", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJudul.Location = new System.Drawing.Point(26, 21);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(350, 57);
            this.labelJudul.TabIndex = 30;
            this.labelJudul.Text = "Owner Report";
            // 
            // labelPendapatan
            // 
            this.labelPendapatan.AutoSize = true;
            this.labelPendapatan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPendapatan.Location = new System.Drawing.Point(33, 136);
            this.labelPendapatan.Name = "labelPendapatan";
            this.labelPendapatan.Size = new System.Drawing.Size(43, 16);
            this.labelPendapatan.TabIndex = 31;
            this.labelPendapatan.Text = "label";
            // 
            // labelLaporan
            // 
            this.labelLaporan.AutoSize = true;
            this.labelLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLaporan.Location = new System.Drawing.Point(33, 179);
            this.labelLaporan.Name = "labelLaporan";
            this.labelLaporan.Size = new System.Drawing.Size(227, 16);
            this.labelLaporan.TabIndex = 32;
            this.labelLaporan.Text = "Laporan penjualan menu pada ";
            // 
            // dgvMenuLaris
            // 
            this.dgvMenuLaris.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvMenuLaris.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenuLaris.Location = new System.Drawing.Point(455, 235);
            this.dgvMenuLaris.Name = "dgvMenuLaris";
            this.dgvMenuLaris.Size = new System.Drawing.Size(460, 61);
            this.dgvMenuLaris.TabIndex = 33;
            // 
            // dgvInfoHarga
            // 
            this.dgvInfoHarga.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvInfoHarga.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfoHarga.Location = new System.Drawing.Point(455, 355);
            this.dgvInfoHarga.Name = "dgvInfoHarga";
            this.dgvInfoHarga.Size = new System.Drawing.Size(460, 180);
            this.dgvInfoHarga.TabIndex = 34;
            // 
            // labelMenuLaris
            // 
            this.labelMenuLaris.AutoSize = true;
            this.labelMenuLaris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuLaris.Location = new System.Drawing.Point(452, 204);
            this.labelMenuLaris.Name = "labelMenuLaris";
            this.labelMenuLaris.Size = new System.Drawing.Size(136, 16);
            this.labelMenuLaris.TabIndex = 35;
            this.labelMenuLaris.Text = "Menu Paling Laris";
            // 
            // labelInfoHarga
            // 
            this.labelInfoHarga.AutoSize = true;
            this.labelInfoHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoHarga.Location = new System.Drawing.Point(452, 316);
            this.labelInfoHarga.Name = "labelInfoHarga";
            this.labelInfoHarga.Size = new System.Drawing.Size(164, 16);
            this.labelInfoHarga.TabIndex = 36;
            this.labelInfoHarga.Text = "Info Perubahan Harga";
            this.labelInfoHarga.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.labelInfoHarga);
            this.Controls.Add(this.labelMenuLaris);
            this.Controls.Add(this.dgvInfoHarga);
            this.Controls.Add(this.dgvMenuLaris);
            this.Controls.Add(this.labelLaporan);
            this.Controls.Add(this.labelPendapatan);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.cBoxTanggal);
            this.Controls.Add(this.cBoxBulan);
            this.Controls.Add(this.cBoxTahun);
            this.Controls.Add(this.labelTahun);
            this.Controls.Add(this.labelBulan);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.dgvRecap);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Name = "FormOwner";
            this.Text = "Form Recap";
            this.Load += new System.EventHandler(this.FormOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenuLaris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoHarga)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBulan;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.DataGridView dgvRecap;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTahun;
        private System.Windows.Forms.ComboBox cBoxTahun;
        private System.Windows.Forms.ComboBox cBoxBulan;
        private System.Windows.Forms.ComboBox cBoxTanggal;
        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.Label labelPendapatan;
        private System.Windows.Forms.Label labelLaporan;
        private System.Windows.Forms.DataGridView dgvMenuLaris;
        private System.Windows.Forms.DataGridView dgvInfoHarga;
        private System.Windows.Forms.Label labelMenuLaris;
        private System.Windows.Forms.Label labelInfoHarga;
    }
}