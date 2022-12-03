
namespace Kasir_Hari_Hari_Suki
{
    partial class FormEdit
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
            this.labelEdit = new System.Windows.Forms.Label();
            this.labelNama = new System.Windows.Forms.Label();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.labelHarga = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cBocNama = new System.Windows.Forms.ComboBox();
            this.tbJumlah = new System.Windows.Forms.TextBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelEdit
            // 
            this.labelEdit.AutoSize = true;
            this.labelEdit.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdit.Location = new System.Drawing.Point(12, 22);
            this.labelEdit.Name = "labelEdit";
            this.labelEdit.Size = new System.Drawing.Size(288, 34);
            this.labelEdit.TabIndex = 16;
            this.labelEdit.Text = "Edit Tambah Menu";
            // 
            // labelNama
            // 
            this.labelNama.AutoSize = true;
            this.labelNama.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNama.Location = new System.Drawing.Point(15, 76);
            this.labelNama.Name = "labelNama";
            this.labelNama.Size = new System.Drawing.Size(82, 13);
            this.labelNama.TabIndex = 17;
            this.labelNama.Text = "Nama Menu :";
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(15, 116);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(82, 13);
            this.labelJumlah.TabIndex = 18;
            this.labelJumlah.Text = "Jumlah        :";
            // 
            // labelHarga
            // 
            this.labelHarga.AutoSize = true;
            this.labelHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHarga.Location = new System.Drawing.Point(15, 158);
            this.labelHarga.Name = "labelHarga";
            this.labelHarga.Size = new System.Drawing.Size(81, 13);
            this.labelHarga.TabIndex = 19;
            this.labelHarga.Text = "Harga         :";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Location = new System.Drawing.Point(250, 204);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 31);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // cBocNama
            // 
            this.cBocNama.FormattingEnabled = true;
            this.cBocNama.Location = new System.Drawing.Point(105, 73);
            this.cBocNama.Name = "cBocNama";
            this.cBocNama.Size = new System.Drawing.Size(221, 21);
            this.cBocNama.TabIndex = 21;
            // 
            // tbJumlah
            // 
            this.tbJumlah.Location = new System.Drawing.Point(105, 113);
            this.tbJumlah.Name = "tbJumlah";
            this.tbJumlah.Size = new System.Drawing.Size(220, 20);
            this.tbJumlah.TabIndex = 22;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(105, 155);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(220, 20);
            this.tbHarga.TabIndex = 23;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(352, 253);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.tbJumlah);
            this.Controls.Add(this.cBocNama);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.labelHarga);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.labelNama);
            this.Controls.Add(this.labelEdit);
            this.Name = "FormEdit";
            this.Text = "Form Edit Penjualan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEdit;
        private System.Windows.Forms.Label labelNama;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.Label labelHarga;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cBocNama;
        private System.Windows.Forms.TextBox tbJumlah;
        private System.Windows.Forms.TextBox tbHarga;
    }
}