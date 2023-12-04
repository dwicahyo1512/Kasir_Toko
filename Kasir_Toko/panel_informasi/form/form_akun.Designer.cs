namespace Kasir_Toko.panel_informasi.form
{
    partial class form_akun
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
            this.email_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.box_telepon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.password_box = new System.Windows.Forms.TextBox();
            this.nama_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.clear_button = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_box
            // 
            this.email_box.Location = new System.Drawing.Point(46, 236);
            this.email_box.Name = "email_box";
            this.email_box.Size = new System.Drawing.Size(229, 22);
            this.email_box.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 16);
            this.label6.TabIndex = 27;
            this.label6.Text = "Email";
            // 
            // box_telepon
            // 
            this.box_telepon.Location = new System.Drawing.Point(46, 192);
            this.box_telepon.Name = "box_telepon";
            this.box_telepon.Size = new System.Drawing.Size(229, 22);
            this.box_telepon.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 25;
            this.label5.Text = "Telepon";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 148);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 22);
            this.dateTimePicker1.TabIndex = 24;
            this.dateTimePicker1.Value = new System.DateTime(2023, 12, 4, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tanggal lahir";
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(44, 104);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(229, 22);
            this.password_box.TabIndex = 22;
            // 
            // nama_box
            // 
            this.nama_box.Location = new System.Drawing.Point(45, 60);
            this.nama_box.Name = "nama_box";
            this.nama_box.Size = new System.Drawing.Size(229, 22);
            this.nama_box.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nama";
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Gainsboro;
            this.clear_button.Location = new System.Drawing.Point(127, 273);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(63, 51);
            this.clear_button.TabIndex = 38;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsave.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(46, 272);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(77, 52);
            this.btnsave.TabIndex = 37;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // form_akun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 391);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.email_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.box_telepon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.nama_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "form_akun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form akun";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox box_telepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox nama_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button btnsave;
    }
}