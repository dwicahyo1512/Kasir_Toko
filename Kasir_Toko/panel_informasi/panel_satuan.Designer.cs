namespace Kasir_Toko.panel_informasi
{
    partial class panel_satuan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Create_button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.satuan_nama = new System.Windows.Forms.TextBox();
            this.satuan_keterangan = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clear_button = new System.Windows.Forms.Button();
            this.search_label = new System.Windows.Forms.Label();
            this.Search_tabel = new System.Windows.Forms.TextBox();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(125, 328);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(67, 28);
            this.Delete_Button.TabIndex = 0;
            this.Delete_Button.Text = "delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Create_button
            // 
            this.Create_button.Location = new System.Drawing.Point(198, 328);
            this.Create_button.Name = "Create_button";
            this.Create_button.Size = new System.Drawing.Size(67, 28);
            this.Create_button.TabIndex = 1;
            this.Create_button.Text = "create";
            this.Create_button.UseVisualStyleBackColor = true;
            this.Create_button.Click += new System.EventHandler(this.Create_button_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Location = new System.Drawing.Point(271, 328);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(67, 28);
            this.Update_Button.TabIndex = 2;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Satuan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Satuan Keterangan";
            // 
            // satuan_nama
            // 
            this.satuan_nama.Location = new System.Drawing.Point(115, 193);
            this.satuan_nama.Name = "satuan_nama";
            this.satuan_nama.Size = new System.Drawing.Size(223, 23);
            this.satuan_nama.TabIndex = 5;
            // 
            // satuan_keterangan
            // 
            this.satuan_keterangan.Location = new System.Drawing.Point(114, 256);
            this.satuan_keterangan.Name = "satuan_keterangan";
            this.satuan_keterangan.Size = new System.Drawing.Size(224, 47);
            this.satuan_keterangan.TabIndex = 6;
            this.satuan_keterangan.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Satuan";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Search_tabel);
            this.panel3.Controls.Add(this.search_label);
            this.panel3.Controls.Add(this.clear_button);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.satuan_keterangan);
            this.panel3.Controls.Add(this.satuan_nama);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Update_Button);
            this.panel3.Controls.Add(this.Create_button);
            this.panel3.Controls.Add(this.Delete_Button);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(838, 475);
            this.panel3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.satuan,
            this.id,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(376, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(434, 327);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(253, 123);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(85, 28);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "Clear form";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Location = new System.Drawing.Point(373, 55);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(51, 17);
            this.search_label.TabIndex = 11;
            this.search_label.Text = "Search";
            // 
            // Search_tabel
            // 
            this.Search_tabel.Location = new System.Drawing.Point(430, 55);
            this.Search_tabel.Name = "Search_tabel";
            this.Search_tabel.Size = new System.Drawing.Size(258, 23);
            this.Search_tabel.TabIndex = 12;
            this.Search_tabel.TextChanged += new System.EventHandler(this.Search_tabel_TextChanged);
            // 
            // satuan
            // 
            this.satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.satuan.DataPropertyName = "Id_satuan";
            this.satuan.HeaderText = "#";
            this.satuan.MinimumWidth = 6;
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 46;
            // 
            // id
            // 
            this.id.HeaderText = "Column1";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Satuan";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 82;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Satuan Keterangan";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // panel_satuan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 475);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "panel_satuan";
            this.Text = "panel_satuan";
            this.Load += new System.EventHandler(this.panel_satuan_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Create_button;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox satuan_nama;
        private System.Windows.Forms.RichTextBox satuan_keterangan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.TextBox Search_tabel;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}