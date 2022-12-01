
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
            this.dgvHTransaksi.Size = new System.Drawing.Size(437, 427);
            this.dgvHTransaksi.TabIndex = 3;
            // 
            // dgvDTransaksi
            // 
            this.dgvDTransaksi.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDTransaksi.Location = new System.Drawing.Point(483, 65);
            this.dgvDTransaksi.Name = "dgvDTransaksi";
            this.dgvDTransaksi.Size = new System.Drawing.Size(442, 470);
            this.dgvDTransaksi.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Location = new System.Drawing.Point(264, 501);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(196, 34);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // cBoxTable
            // 
            this.cBoxTable.BackColor = System.Drawing.Color.White;
            this.cBoxTable.FormattingEnabled = true;
            this.cBoxTable.Location = new System.Drawing.Point(457, 25);
            this.cBoxTable.Name = "cBoxTable";
            this.cBoxTable.Size = new System.Drawing.Size(245, 21);
            this.cBoxTable.TabIndex = 14;
            // 
            // labelTgl
            // 
            this.labelTgl.AutoSize = true;
            this.labelTgl.Location = new System.Drawing.Point(45, 27);
            this.labelTgl.Name = "labelTgl";
            this.labelTgl.Size = new System.Drawing.Size(52, 13);
            this.labelTgl.TabIndex = 15;
            this.labelTgl.Text = "Tanggal :";
            this.labelTgl.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTable
            // 
            this.labelTable.AutoSize = true;
            this.labelTable.Location = new System.Drawing.Point(381, 28);
            this.labelTable.Name = "labelTable";
            this.labelTable.Size = new System.Drawing.Size(40, 13);
            this.labelTable.TabIndex = 16;
            this.labelTable.Text = "Table :";
            // 
            // FormRecap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(946, 547);
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
    }
}