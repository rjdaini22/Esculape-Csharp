namespace loginForm
{
    partial class mainPatientRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPatientRegister));
            this.exit = new System.Windows.Forms.Button();
            this.pregister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pssnumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.psurname = new System.Windows.Forms.TextBox();
            this.bdayPicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.exit.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.exit.Location = new System.Drawing.Point(461, 182);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 27);
            this.exit.TabIndex = 10;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pregister
            // 
            this.pregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.pregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.pregister.Location = new System.Drawing.Point(356, 182);
            this.pregister.Name = "pregister";
            this.pregister.Size = new System.Drawing.Size(99, 27);
            this.pregister.TabIndex = 11;
            this.pregister.Text = "Enregistrer";
            this.pregister.UseVisualStyleBackColor = false;
            this.pregister.Click += new System.EventHandler(this.pregister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Inscrire un patient :";
            // 
            // pname
            // 
            this.pname.Location = new System.Drawing.Point(356, 43);
            this.pname.MaxLength = 20;
            this.pname.Name = "pname";
            this.pname.Size = new System.Drawing.Size(180, 22);
            this.pname.TabIndex = 8;
            this.pname.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label3.Location = new System.Drawing.Point(216, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 5;
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
            this.label1.TabIndex = 6;
            this.label1.Text = "Nom :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label4.Location = new System.Drawing.Point(216, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date de naissance :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // pssnumber
            // 
            this.pssnumber.Location = new System.Drawing.Point(356, 128);
            this.pssnumber.MaxLength = 20;
            this.pssnumber.Name = "pssnumber";
            this.pssnumber.Size = new System.Drawing.Size(180, 22);
            this.pssnumber.TabIndex = 9;
            this.pssnumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label5.Location = new System.Drawing.Point(216, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.label6.Location = new System.Drawing.Point(216, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "N° sécurité sociale :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // psurname
            // 
            this.psurname.Location = new System.Drawing.Point(356, 72);
            this.psurname.MaxLength = 20;
            this.psurname.Name = "psurname";
            this.psurname.Size = new System.Drawing.Size(180, 22);
            this.psurname.TabIndex = 9;
            this.psurname.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // bdayPicker
            // 
            this.bdayPicker.CustomFormat = "dd/MM/yyyy";
            this.bdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bdayPicker.Location = new System.Drawing.Point(356, 99);
            this.bdayPicker.Name = "bdayPicker";
            this.bdayPicker.Size = new System.Drawing.Size(180, 22);
            this.bdayPicker.TabIndex = 12;
            this.bdayPicker.Value = new System.DateTime(2020, 2, 27, 0, 0, 0, 0);
            this.bdayPicker.ValueChanged += new System.EventHandler(this.bdayPicker_ValueChanged);
            // 
            // mainPatientRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 279);
            this.Controls.Add(this.bdayPicker);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.pregister);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.psurname);
            this.Controls.Add(this.pssnumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "mainPatientRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inscrire un patient";
            this.Load += new System.EventHandler(this.mainPatientRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button pregister;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pssnumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox psurname;
        private System.Windows.Forms.DateTimePicker bdayPicker;
    }
}