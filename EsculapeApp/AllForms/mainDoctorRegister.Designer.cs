namespace loginForm
{
    partial class mainDoctorRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainDoctorRegister));
            this.mregisterdate = new System.Windows.Forms.DateTimePicker();
            this.exit = new System.Windows.Forms.Button();
            this.mregister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.musername = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label789 = new System.Windows.Forms.Label();
            this.mssnumber = new System.Windows.Forms.TextBox();
            this.mname = new System.Windows.Forms.TextBox();
            this.msurname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mregisterdate
            // 
            this.mregisterdate.CustomFormat = "dd/MM/yyyy";
            this.mregisterdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.mregisterdate.Location = new System.Drawing.Point(356, 99);
            this.mregisterdate.Name = "mregisterdate";
            this.mregisterdate.Size = new System.Drawing.Size(180, 22);
            this.mregisterdate.TabIndex = 25;
            this.mregisterdate.Value = new System.DateTime(2020, 2, 26, 0, 0, 0, 0);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.exit.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.exit.Location = new System.Drawing.Point(461, 211);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 27);
            this.exit.TabIndex = 23;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mregister
            // 
            this.mregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.mregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.mregister.Location = new System.Drawing.Point(356, 211);
            this.mregister.Name = "mregister";
            this.mregister.Size = new System.Drawing.Size(99, 27);
            this.mregister.TabIndex = 24;
            this.mregister.Text = "Enregistrer";
            this.mregister.UseVisualStyleBackColor = false;
            this.mregister.Click += new System.EventHandler(this.mregister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Inscrire un medecin :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label4.Location = new System.Drawing.Point(216, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date d\'inscription :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label3.Location = new System.Drawing.Point(216, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Prénom :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(216, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nom :";
            // 
            // musername
            // 
            this.musername.Location = new System.Drawing.Point(356, 127);
            this.musername.MaxLength = 20;
            this.musername.Name = "musername";
            this.musername.Size = new System.Drawing.Size(180, 22);
            this.musername.TabIndex = 21;
            this.musername.TextChanged += new System.EventHandler(this.musername_TextChanged);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label45.Location = new System.Drawing.Point(216, 132);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(124, 17);
            this.label45.TabIndex = 17;
            this.label45.Text = "Nom d\'utilisateur :";
            // 
            // label789
            // 
            this.label789.AutoSize = true;
            this.label789.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label789.Location = new System.Drawing.Point(216, 188);
            this.label789.Name = "label789";
            this.label789.Size = new System.Drawing.Size(131, 17);
            this.label789.TabIndex = 17;
            this.label789.Text = "N° sécurité sociale :";
            this.label789.Click += new System.EventHandler(this.label789_Click);
            // 
            // mssnumber
            // 
            this.mssnumber.Location = new System.Drawing.Point(356, 183);
            this.mssnumber.MaxLength = 20;
            this.mssnumber.Name = "mssnumber";
            this.mssnumber.Size = new System.Drawing.Size(180, 22);
            this.mssnumber.TabIndex = 21;
            this.mssnumber.TextChanged += new System.EventHandler(this.mpassword_TextChanged);
            // 
            // mname
            // 
            this.mname.Location = new System.Drawing.Point(356, 44);
            this.mname.MaxLength = 20;
            this.mname.Name = "mname";
            this.mname.Size = new System.Drawing.Size(180, 22);
            this.mname.TabIndex = 26;
            // 
            // msurname
            // 
            this.msurname.Location = new System.Drawing.Point(356, 72);
            this.msurname.MaxLength = 20;
            this.msurname.Name = "msurname";
            this.msurname.Size = new System.Drawing.Size(180, 22);
            this.msurname.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label5.Location = new System.Drawing.Point(216, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mot de passe :";
            this.label5.Click += new System.EventHandler(this.label789_Click);
            // 
            // mpassword
            // 
            this.mpassword.Location = new System.Drawing.Point(356, 155);
            this.mpassword.MaxLength = 20;
            this.mpassword.Name = "mpassword";
            this.mpassword.Size = new System.Drawing.Size(180, 22);
            this.mpassword.TabIndex = 21;
            this.mpassword.TextChanged += new System.EventHandler(this.mpassword_TextChanged);
            // 
            // mainDoctorRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 279);
            this.Controls.Add(this.msurname);
            this.Controls.Add(this.mname);
            this.Controls.Add(this.mregisterdate);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mregister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mpassword);
            this.Controls.Add(this.mssnumber);
            this.Controls.Add(this.musername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label789);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "mainDoctorRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrire un medecin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker mregisterdate;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mregister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox musername;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label789;
        private System.Windows.Forms.TextBox mssnumber;
        private System.Windows.Forms.TextBox mname;
        private System.Windows.Forms.TextBox msurname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox mpassword;
    }
}