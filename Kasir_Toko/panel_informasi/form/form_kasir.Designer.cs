namespace Kasir_Toko.panel_informasi.form
{
    partial class form_kasir
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
            this.btnsave = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxnama_barang = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.textBoxharga_barang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Stok_tersedia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_kategori = new System.Windows.Forms.TextBox();
            this.kategori = new System.Windows.Forms.Label();
            this.textBox_satuan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(200, 162);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(110, 57);
            this.btnsave.TabIndex = 17;
            this.btnsave.Text = "Tambah";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(37, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 23);
            this.textBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Total stock";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 25);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Barang";
            // 
            // textBoxnama_barang
            // 
            this.textBoxnama_barang.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnama_barang.Location = new System.Drawing.Point(370, 141);
            this.textBoxnama_barang.Name = "textBoxnama_barang";
            this.textBoxnama_barang.ReadOnly = true;
            this.textBoxnama_barang.Size = new System.Drawing.Size(206, 23);
            this.textBoxnama_barang.TabIndex = 19;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(367, 121);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(101, 17);
            this.label.TabIndex = 18;
            this.label.Text = "Nama barang";
            // 
            // textBoxharga_barang
            // 
            this.textBoxharga_barang.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxharga_barang.Location = new System.Drawing.Point(370, 196);
            this.textBoxharga_barang.Name = "textBoxharga_barang";
            this.textBoxharga_barang.ReadOnly = true;
            this.textBoxharga_barang.Size = new System.Drawing.Size(206, 23);
            this.textBoxharga_barang.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Harga Barang";
            // 
            // Stok_tersedia
            // 
            this.Stok_tersedia.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stok_tersedia.Location = new System.Drawing.Point(370, 252);
            this.Stok_tersedia.Name = "Stok_tersedia";
            this.Stok_tersedia.ReadOnly = true;
            this.Stok_tersedia.Size = new System.Drawing.Size(206, 23);
            this.Stok_tersedia.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(367, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stok Tersedia";
            // 
            // textBox_kategori
            // 
            this.textBox_kategori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_kategori.Location = new System.Drawing.Point(370, 95);
            this.textBox_kategori.Name = "textBox_kategori";
            this.textBox_kategori.ReadOnly = true;
            this.textBox_kategori.Size = new System.Drawing.Size(206, 23);
            this.textBox_kategori.TabIndex = 27;
            // 
            // kategori
            // 
            this.kategori.AutoSize = true;
            this.kategori.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategori.Location = new System.Drawing.Point(367, 75);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(63, 17);
            this.kategori.TabIndex = 26;
            this.kategori.Text = "Kategori";
            // 
            // textBox_satuan
            // 
            this.textBox_satuan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_satuan.Location = new System.Drawing.Point(370, 49);
            this.textBox_satuan.Name = "textBox_satuan";
            this.textBox_satuan.ReadOnly = true;
            this.textBox_satuan.Size = new System.Drawing.Size(206, 23);
            this.textBox_satuan.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 28;
            this.label7.Text = "Satuan";
            // 
            // form_kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 305);
            this.Controls.Add(this.textBox_satuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_kategori);
            this.Controls.Add(this.kategori);
            this.Controls.Add(this.Stok_tersedia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxharga_barang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxnama_barang);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Kasir";
            this.Load += new System.EventHandler(this.form_kasir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxnama_barang;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBoxharga_barang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Stok_tersedia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_kategori;
        private System.Windows.Forms.Label kategori;
        private System.Windows.Forms.TextBox textBox_satuan;
        private System.Windows.Forms.Label label7;
    }
}