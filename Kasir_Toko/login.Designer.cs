namespace Kasir_Toko
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_new_kasir = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.password_login = new System.Windows.Forms.TextBox();
            this.nama_login = new System.Windows.Forms.TextBox();
            this.password_nama = new System.Windows.Forms.Label();
            this.nama_label_login = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(189)))), ((int)(((byte)(255)))));
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.create_new_kasir);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.password_login);
            this.panel1.Controls.Add(this.nama_login);
            this.panel1.Controls.Add(this.password_nama);
            this.panel1.Controls.Add(this.nama_label_login);
            this.panel1.Controls.Add(this.login_label);
            this.panel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(262, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 472);
            this.panel1.TabIndex = 0;
            // 
            // create_new_kasir
            // 
            this.create_new_kasir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_new_kasir.Location = new System.Drawing.Point(191, 349);
            this.create_new_kasir.Name = "create_new_kasir";
            this.create_new_kasir.Size = new System.Drawing.Size(106, 42);
            this.create_new_kasir.TabIndex = 7;
            this.create_new_kasir.Text = "register";
            this.create_new_kasir.UseVisualStyleBackColor = true;
            this.create_new_kasir.Click += new System.EventHandler(this.create_new_kasir_Click);
            // 
            // login_button
            // 
            this.login_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(61, 349);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(106, 42);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "LOGIN";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // password_login
            // 
            this.password_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.password_login.Location = new System.Drawing.Point(61, 280);
            this.password_login.Name = "password_login";
            this.password_login.PasswordChar = '*';
            this.password_login.Size = new System.Drawing.Size(274, 42);
            this.password_login.TabIndex = 4;
            this.password_login.UseSystemPasswordChar = true;
            // 
            // nama_login
            // 
            this.nama_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(174)))), ((int)(((byte)(248)))));
            this.nama_login.Location = new System.Drawing.Point(61, 183);
            this.nama_login.Name = "nama_login";
            this.nama_login.Size = new System.Drawing.Size(274, 42);
            this.nama_login.TabIndex = 3;
            this.nama_login.UseWaitCursor = true;
            // 
            // password_nama
            // 
            this.password_nama.AutoSize = true;
            this.password_nama.BackColor = System.Drawing.Color.Transparent;
            this.password_nama.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_nama.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password_nama.Location = new System.Drawing.Point(58, 262);
            this.password_nama.Name = "password_nama";
            this.password_nama.Size = new System.Drawing.Size(84, 15);
            this.password_nama.TabIndex = 2;
            this.password_nama.Text = "PASSWORD";
            // 
            // nama_label_login
            // 
            this.nama_label_login.AutoSize = true;
            this.nama_label_login.BackColor = System.Drawing.Color.Transparent;
            this.nama_label_login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_label_login.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nama_label_login.Location = new System.Drawing.Point(58, 165);
            this.nama_label_login.Name = "nama_label_login";
            this.nama_label_login.Size = new System.Drawing.Size(46, 15);
            this.nama_label_login.TabIndex = 1;
            this.nama_label_login.Text = "NAMA";
            // 
            // login_label
            // 
            this.login_label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login_label.AutoSize = true;
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Ravie", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.login_label.Location = new System.Drawing.Point(120, 28);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(135, 44);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "Login";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CalendarForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateTimePicker1.CustomFormat = "YYYY-MM-DD";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2023, 11, 28, 16, 9, 20, 0);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 537);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.TextBox password_login;
        private System.Windows.Forms.TextBox nama_login;
        private System.Windows.Forms.Label password_nama;
        private System.Windows.Forms.Label nama_label_login;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button create_new_kasir;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

