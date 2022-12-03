
namespace Kasir_Hari_Hari_Suki
{
    partial class FormRecap
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
            this.dtpTglTransaksi = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvHTransaksi = new System.Windows.Forms.DataGridView();
            this.dgvDTransaksi = new System.Windows.Forms.DataGridView();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cBoxTable = new System.Windows.Forms.ComboBox();
            this.labelTgl = new System.Windows.Forms.Label();
            this.labelTable = new System.Windows.Forms.Label();
            this.tbUbah = new System.Windows.Forms.TextBox();
            this.labelUbah = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpTglTransaksi
            // 
            this.dtpTglTransaksi.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTglTransaksi.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtpTglTransaksi.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtpTglTransaksi.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtpTglTransaksi.Location = new System.Drawing.Point(122, 25);
            this.dtpTglTransaksi.Name = "dtpTglTransaksi";
            this.dtpTglTransaksi.Size = new System.Drawing.Size(231, 20);
            this.dtpTglTransaksi.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.Location = new System.Drawing.Point(745, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnBack.Location = new System.Drawing.Point(826, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dgvHTransaksi
            // 
            this.dgvHTransaksi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvHTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHTransaksi.Location = new System.Drawing.Point(23, 65);
            this.dgvHTransaksi.Name = "dgvHTransaksi";
            this.dgvHTransaksi.Size = new System.Drawing.Size(437, 470);
            this.dgvHTransaksi.TabIndex = 3;
            this.dgvHTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHTransaksi_CellClick);
            // 
            // dgvDTransaksi
            // 
            this.dgvDTransaksi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTransaksi.Location = new System.Drawing.Point(483, 65);
            this.dgvDTransaksi.Name = "dgvDTransaksi";
            this.dgvDTransaksi.Size = new System.Drawing.Size(442, 444);
            this.dgvDTransaksi.TabIndex = 4;
            this.dgvDTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDTransaksi_CellClick);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Location = new System.Drawing.Point(667, 519);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(258, 20);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cBoxTable
            // 
            this.cBoxTable.BackColor = System.Drawing.Color.White;
            this.cBoxTable.FormattingEnabled = true;
            this.cBoxTable.Items.AddRange(new object[] {
            "Table 1",
            "Table 2",
            "Table 3",
            "Table 4",
            "Table 5",
            "Table 6",
            "Table 7",
            "Table 8"});
            this.cBoxTable.Location = new System.Drawing.Point(457, 25);
            this.cBoxTable.Name = "cBoxTable";
            this.cBoxTable.Size = new System.Drawing.Size(245, 21);
            this.cBoxTable.TabIndex = 14;
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTgl.Location = new System.Drawing.Point(45, 27);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(61, 13);
            this.labelTgl.TabIndex = 15;
            this.labelTgl.Text = "Tanggal :";
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTable.Location = new System.Drawing.Point(381, 28);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(47, 13);
            this.labelTable.TabIndex = 16;
            this.labelTable.Text = "Table :";
            // 
            // tbUbah
            // 
            this.tbUbah.Location = new System.Drawing.Point(536, 519);
            this.tbUbah.Name = "tbUbah";
            this.tbUbah.Size = new System.Drawing.Size(118, 20);
            this.tbUbah.TabIndex = 17;
            this.tbUbah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUbah_KeyPress);
            // 
            // labelUbah
            // 
            this.labelUbah.AutoSize = true;
            this.labelUbah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUbah.Location = new System.Drawing.Point(483, 521);
            this.labelUbah.Name = "labelUbah";
            this.labelUbah.Size = new System.Drawing.Size(49, 15);
            this.labelUbah.TabIndex = 18;
            this.labelUbah.Text = "Ubah :";
            // 
            // FormRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.labelUbah);
            this.Controls.Add(this.tbUbah);
            this.Controls.Add(this.labelTable);
            this.Controls.Add(this.labelTgl);
            this.Controls.Add(this.cBoxTable);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvDTransaksi);
            this.Controls.Add(this.dgvHTransaksi);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpTglTransaksi);
            this.Name = "FormRecap";
            this.Text = "Form Recap";
            this.Load += new System.EventHandler(this.FormRecap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTglTransaksi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvHTransaksi;
        private System.Windows.Forms.DataGridView dgvDTransaksi;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cBoxTable;
        private System.Windows.Forms.Label labelTgl;
        private System.Windows.Forms.Label labelTable;
        private System.Windows.Forms.TextBox tbUbah;
        private System.Windows.Forms.Label labelUbah;
    }
}