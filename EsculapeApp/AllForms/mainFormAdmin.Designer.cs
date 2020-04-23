namespace loginForm
{
    partial class mainFormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainFormAdmin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.patientregister = new System.Windows.Forms.Button();
            this.user_label = new System.Windows.Forms.Label();
            this.mregister = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nom_user = new System.Windows.Forms.Label();
            this.mdelete = new System.Windows.Forms.Button();
            this.pdelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(216, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bienvenue sur l\'application Esculape";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.exit.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.exit.Location = new System.Drawing.Point(12, 324);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // patientregister
            // 
            this.patientregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.patientregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.patientregister.Location = new System.Drawing.Point(12, 244);
            this.patientregister.Name = "patientregister";
            this.patientregister.Size = new System.Drawing.Size(198, 23);
            this.patientregister.TabIndex = 4;
            this.patientregister.Text = "Inscrire un(e) patient(e)";
            this.patientregister.UseVisualStyleBackColor = false;
            this.patientregister.Click += new System.EventHandler(this.patientregister_Click);
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.user_label.Location = new System.Drawing.Point(217, 60);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(282, 17);
            this.user_label.TabIndex = 3;
            this.user_label.Text = "Bienvenue sur l\'application Esculape Admin";
            this.user_label.Click += new System.EventHandler(this.user_label_Click);
            // 
            // mregister
            // 
            this.mregister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.mregister.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.mregister.Location = new System.Drawing.Point(12, 215);
            this.mregister.Name = "mregister";
            this.mregister.Size = new System.Drawing.Size(198, 23);
            this.mregister.TabIndex = 9;
            this.mregister.Text = "Inscrire un médecin";
            this.mregister.UseVisualStyleBackColor = false;
            this.mregister.Click += new System.EventHandler(this.mregisteradmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(550, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 58);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // nom_user
            // 
            this.nom_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nom_user.AutoSize = true;
            this.nom_user.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.nom_user.Location = new System.Drawing.Point(547, 74);
            this.nom_user.Name = "nom_user";
            this.nom_user.Size = new System.Drawing.Size(131, 17);
            this.nom_user.TabIndex = 20;
            this.nom_user.Text = "Nom de l\'utilisateur";
            this.nom_user.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // mdelete
            // 
            this.mdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.mdelete.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.mdelete.Location = new System.Drawing.Point(216, 109);
            this.mdelete.Name = "mdelete";
            this.mdelete.Size = new System.Drawing.Size(198, 23);
            this.mdelete.TabIndex = 4;
            this.mdelete.Text = "Supprimer un médecin";
            this.mdelete.UseVisualStyleBackColor = false;
            this.mdelete.Click += new System.EventHandler(this.mdelete_Click);
            // 
            // pdelete
            // 
            this.pdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.pdelete.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.pdelete.Location = new System.Drawing.Point(216, 80);
            this.pdelete.Name = "pdelete";
            this.pdelete.Size = new System.Drawing.Size(198, 23);
            this.pdelete.TabIndex = 4;
            this.pdelete.Text = "Supprimer un patient";
            this.pdelete.UseVisualStyleBackColor = false;
            this.pdelete.Click += new System.EventHandler(this.pdelete_Click);
            // 
            // mainFormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 359);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.nom_user);
            this.Controls.Add(this.mregister);
            this.Controls.Add(this.pdelete);
            this.Controls.Add(this.mdelete);
            this.Controls.Add(this.patientregister);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "mainFormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button patientregister;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Button mregister;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nom_user;
        private System.Windows.Forms.Button mdelete;
        private System.Windows.Forms.Button pdelete;
    }
}