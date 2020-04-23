namespace loginForm
{
    partial class mainDeleteDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainDeleteDoctor));
            this.exit = new System.Windows.Forms.Button();
            this.mdelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.exit.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.exit.Location = new System.Drawing.Point(468, 131);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 27);
            this.exit.TabIndex = 37;
            this.exit.Text = "Quitter";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // mdelete
            // 
            this.mdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(116)))), ((int)(((byte)(181)))));
            this.mdelete.Font = new System.Drawing.Font("Roboto Lt", 7.8F);
            this.mdelete.Location = new System.Drawing.Point(363, 131);
            this.mdelete.Name = "mdelete";
            this.mdelete.Size = new System.Drawing.Size(99, 27);
            this.mdelete.TabIndex = 38;
            this.mdelete.Text = "Supprimer";
            this.mdelete.UseVisualStyleBackColor = false;
            this.mdelete.Click += new System.EventHandler(this.mdelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 197);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Cn", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "Supprimer un médecin";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(363, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Lt", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 17);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nom d\'utilisateur :";
            // 
            // mainDeleteDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 279);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.mdelete);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "mainDeleteDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Supprimer un médecin";
            this.Load += new System.EventHandler(this.mainDeleteDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button mdelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}