﻿namespace loginForm
{
    partial class mainFormSecretaire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormSecretaire));
            this.mregister = new System.Windows.Forms.Button();
            this.pregister = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nom_user = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // mregister
            // 
            this.mregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.mregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.mregister.Location = new System.Drawing.Point(12, 215);
            this.mregister.Name = "mregister";
            this.mregister.Size = new System.Drawing.Size(198, 23);
            this.mregister.TabIndex = 8;
            this.mregister.Text = "Inscrire un médecin";
            this.mregister.UseVisualStyleBackColor = false;
            this.mregister.Click += new System.EventHandler(this.mregister_Click);
            // 
            // pregister
            // 
            this.pregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.pregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.pregister.Location = new System.Drawing.Point(12, 244);
            this.pregister.Name = "pregister";
            this.pregister.Size = new System.Drawing.Size(198, 23);
            this.pregister.TabIndex = 10;
            this.pregister.Text = "Inscrire un(e) patient(e)";
            this.pregister.UseVisualStyleBackColor = false;
            this.pregister.Click += new System.EventHandler(this.pregister_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.exit.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.exit.Location = new System.Drawing.Point(12, 324);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 11;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.user_label.Location = new System.Drawing.Point(213, 61);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(305, 17);
            this.user_label.TabIndex = 6;
            this.user_label.Text = "Bienvenue sur l\'application Esculape Secretaire";
            this.user_label.Click += new System.EventHandler(this.user_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(212, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bienvenue sur l\'application Esculape";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // nom_user
            // 
            this.nom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_user.AutoSize = true;
            this.nom_user.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.nom_user.Location = new System.Drawing.Point(547, 73);
            this.nom_user.Name = "nom_user";
            this.nom_user.Size = new System.Drawing.Size(131, 17);
            this.nom_user.TabIndex = 6;
            this.nom_user.Text = "Nom de l\'utilisateur";
            this.nom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nom_user.Click += new System.EventHandler(this.user_label_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(550, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 58);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.button1.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.button1.Location = new System.Drawing.Point(216, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Nom d\'utilisateur";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mainFormSecretaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 359);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.mregister);
            this.Controls.Add(this.pregister);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.nom_user);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainFormSecretaire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secretaire";
            this.Load += new System.EventHandler(this.mainFormSecretaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mregister;
        private System.Windows.Forms.Button pregister;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label nom_user;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}