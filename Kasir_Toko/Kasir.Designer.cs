namespace Kasir_Toko
{
    partial class Kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.kasir_count = new System.Windows.Forms.Button();
            this.barang = new System.Windows.Forms.Button();
            this.kategori = new System.Windows.Forms.Button();
            this.Satuan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.kasir_count);
            this.panel1.Controls.Add(this.barang);
            this.panel1.Controls.Add(this.kategori);
            this.panel1.Controls.Add(this.Satuan);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 673);
            this.panel1.TabIndex = 1;
            // 
            // kasir_count
            // 
            this.kasir_count.Location = new System.Drawing.Point(22, 430);
            this.kasir_count.Name = "kasir_count";
            this.kasir_count.Size = new System.Drawing.Size(143, 67);
            this.kasir_count.TabIndex = 4;
            this.kasir_count.Text = "kasir";
            this.kasir_count.UseVisualStyleBackColor = true;
            this.kasir_count.Click += new System.EventHandler(this.kasir_count_Click);
            // 
            // barang
            // 
            this.barang.Location = new System.Drawing.Point(22, 357);
            this.barang.Name = "barang";
            this.barang.Size = new System.Drawing.Size(143, 67);
            this.barang.TabIndex = 3;
            this.barang.Text = "barang";
            this.barang.UseVisualStyleBackColor = true;
            this.barang.Click += new System.EventHandler(this.barang_Click);
            // 
            // kategori
            // 
            this.kategori.Location = new System.Drawing.Point(22, 284);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(143, 67);
            this.kategori.TabIndex = 2;
            this.kategori.Text = "kategori";
            this.kategori.UseVisualStyleBackColor = true;
            this.kategori.Click += new System.EventHandler(this.kategori_Click);
            // 
            // Satuan
            // 
            this.Satuan.Location = new System.Drawing.Point(21, 211);
            this.Satuan.Name = "Satuan";
            this.Satuan.Size = new System.Drawing.Size(143, 67);
            this.Satuan.TabIndex = 1;
            this.Satuan.Text = "satuan";
            this.Satuan.UseVisualStyleBackColor = true;
            this.Satuan.Click += new System.EventHandler(this.Satuan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1062, 74);
            this.panel2.TabIndex = 2;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(820, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 54);
            this.button7.TabIndex = 5;
            this.button7.Text = "data kasir";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(943, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 54);
            this.button2.TabIndex = 0;
            this.button2.Text = "LOG OUT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(200, 74);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1062, 599);
            this.mainpanel.TabIndex = 3;
            this.mainpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Kasir
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Kasir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasir";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button barang;
        private System.Windows.Forms.Button kategori;
        private System.Windows.Forms.Button Satuan;
        private System.Windows.Forms.Button kasir_count;
        private System.Windows.Forms.Button button7;
    }
}