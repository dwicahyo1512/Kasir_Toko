namespace Kasir_Toko
{
    partial class registrasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registrasi));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.back_login = new System.Windows.Forms.Button();
            this.create_registrasi = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.email_registrasi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.confirm_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telepon_registrasi = new System.Windows.Forms.TextBox();
            this.TGL_lahir = new System.Windows.Forms.Label();
            this.password_registrasi = new System.Windows.Forms.TextBox();
            this.nama_registrasi = new System.Windows.Forms.TextBox();
            this.password_nama_registrasi = new System.Windows.Forms.Label();
            this.nama_label_registerasi = new System.Windows.Forms.Label();
            this.Register_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.back_login);
            this.panel1.Controls.Add(this.create_registrasi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.email_registrasi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.confirm_password);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.telepon_registrasi);
            this.panel1.Controls.Add(this.TGL_lahir);
            this.panel1.Controls.Add(this.password_registrasi);
            this.panel1.Controls.Add(this.nama_registrasi);
            this.panel1.Controls.Add(this.password_nama_registrasi);
            this.panel1.Controls.Add(this.nama_label_registerasi);
            this.panel1.Controls.Add(this.Register_label);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(67, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(806, 495);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CustomFormat = "dd-M-yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(424, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(274, 31);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 28, 0, 0, 0, 0);
            // 
            // back_login
            // 
            this.back_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_login.Location = new System.Drawing.Point(266, 332);
            this.back_login.Name = "back_login";
            this.back_login.Size = new System.Drawing.Size(148, 52);
            this.back_login.TabIndex = 15;
            this.back_login.Text = "back to login";
            this.back_login.UseVisualStyleBackColor = true;
            this.back_login.Click += new System.EventHandler(this.back_login_Click);
            // 
            // create_registrasi
            // 
            this.create_registrasi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_registrasi.Location = new System.Drawing.Point(92, 332);
            this.create_registrasi.Name = "create_registrasi";
            this.create_registrasi.Size = new System.Drawing.Size(148, 52);
            this.create_registrasi.TabIndex = 14;
            this.create_registrasi.Text = "registrasi";
            this.create_registrasi.UseVisualStyleBackColor = true;
            this.create_registrasi.Click += new System.EventHandler(this.create_registrasi_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(421, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "EMAIL";
            // 
            // email_registrasi
            // 
            this.email_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.email_registrasi.Location = new System.Drawing.Point(424, 269);
            this.email_registrasi.Name = "email_registrasi";
            this.email_registrasi.Size = new System.Drawing.Size(274, 42);
            this.email_registrasi.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(91, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "CONFIRM PASSWORD";
            // 
            // confirm_password
            // 
            this.confirm_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.confirm_password.Location = new System.Drawing.Point(94, 269);
            this.confirm_password.Name = "confirm_password";
            this.confirm_password.Size = new System.Drawing.Size(274, 42);
            this.confirm_password.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(421, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "NO TELEPON";
            // 
            // telepon_registrasi
            // 
            this.telepon_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.telepon_registrasi.Location = new System.Drawing.Point(424, 191);
            this.telepon_registrasi.Name = "telepon_registrasi";
            this.telepon_registrasi.Size = new System.Drawing.Size(274, 42);
            this.telepon_registrasi.TabIndex = 8;
            // 
            // TGL_lahir
            // 
            this.TGL_lahir.AutoSize = true;
            this.TGL_lahir.BackColor = System.Drawing.Color.Transparent;
            this.TGL_lahir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TGL_lahir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TGL_lahir.Location = new System.Drawing.Point(421, 101);
            this.TGL_lahir.Name = "TGL_lahir";
            this.TGL_lahir.Size = new System.Drawing.Size(76, 15);
            this.TGL_lahir.TabIndex = 7;
            this.TGL_lahir.Text = "TGL LAHIR";
            // 
            // password_registrasi
            // 
            this.password_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.password_registrasi.Location = new System.Drawing.Point(94, 191);
            this.password_registrasi.Name = "password_registrasi";
            this.password_registrasi.Size = new System.Drawing.Size(274, 42);
            this.password_registrasi.TabIndex = 4;
            // 
            // nama_registrasi
            // 
            this.nama_registrasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.nama_registrasi.Location = new System.Drawing.Point(94, 119);
            this.nama_registrasi.Name = "nama_registrasi";
            this.nama_registrasi.Size = new System.Drawing.Size(274, 42);
            this.nama_registrasi.TabIndex = 3;
            this.nama_registrasi.TextChanged += new System.EventHandler(this.nama_login_TextChanged);
            // 
            // password_nama_registrasi
            // 
            this.password_nama_registrasi.AutoSize = true;
            this.password_nama_registrasi.BackColor = System.Drawing.Color.Transparent;
            this.password_nama_registrasi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_nama_registrasi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_nama_registrasi.Location = new System.Drawing.Point(91, 173);
            this.password_nama_registrasi.Name = "password_nama_registrasi";
            this.password_nama_registrasi.Size = new System.Drawing.Size(84, 15);
            this.password_nama_registrasi.TabIndex = 2;
            this.password_nama_registrasi.Text = "PASSWORD";
            // 
            // nama_label_registerasi
            // 
            this.nama_label_registerasi.AutoSize = true;
            this.nama_label_registerasi.BackColor = System.Drawing.Color.Transparent;
            this.nama_label_registerasi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_label_registerasi.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nama_label_registerasi.Location = new System.Drawing.Point(91, 101);
            this.nama_label_registerasi.Name = "nama_label_registerasi";
            this.nama_label_registerasi.Size = new System.Drawing.Size(46, 15);
            this.nama_label_registerasi.TabIndex = 1;
            this.nama_label_registerasi.Text = "NAMA";
            // 
            // Register_label
            // 
            this.Register_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Register_label.AutoSize = true;
            this.Register_label.BackColor = System.Drawing.Color.Transparent;
            this.Register_label.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Register_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Register_label.Location = new System.Drawing.Point(115, 36);
            this.Register_label.Name = "Register_label";
            this.Register_label.Size = new System.Drawing.Size(219, 44);
            this.Register_label.TabIndex = 0;
            this.Register_label.Text = "Register";
            // 
            // registrasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(933, 575);
            this.Controls.Add(this.panel1);
            this.Name = "registrasi";
            this.Text = "registrasi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox password_registrasi;
        private System.Windows.Forms.TextBox nama_registrasi;
        private System.Windows.Forms.Label password_nama_registrasi;
        private System.Windows.Forms.Label nama_label_registerasi;
        private System.Windows.Forms.Label Register_label;
        private System.Windows.Forms.Label TGL_lahir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox email_registrasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox confirm_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telepon_registrasi;
        private System.Windows.Forms.Button back_login;
        private System.Windows.Forms.Button create_registrasi;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}