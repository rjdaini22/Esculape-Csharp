using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace loginForm
{
    public partial class Esculape : Form
    {

        





        public String conn;
        public MySqlConnection connect;
        public Esculape()
        {
            InitializeComponent();
            username.MaxLength = 20;
            password.MaxLength = 20;
        }

        public void db_connection()
        {
            try
            {
                conn = "Server=localhost;Database=esculape;Uid=root;Password=;";
                connect = new MySqlConnection(conn);
                connect.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool validate_login(string user, string pass)
        {
            db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM user_account where user_name = '" + username.Text + "' and password = '" + password.Text + "' ";
            cmd.Connection = connect;
            MySqlDataReader login = cmd.ExecuteReader();

            if (login.Read())
            {
                connect.Close();
                return true;
            }
            else
            {
                connect.Close();
                return false;
            }
        }





        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        public void login_Click(object sender, EventArgs e)
        {

            try
            {

                string user = username.Text;


                string pass = password.Text;

                if (user == "" || pass == "")
                {
                    MessageBox.Show("Tout les champs doivent être complétés !");
                    return;
                }

                bool r = validate_login(user, pass);

                if (r)
                {

                    db_connection();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.CommandText = "SELECT category FROM user_account where user_name = '" + username.Text + "'";
                    cmd.Connection = connect;
                    MySqlDataReader cat = cmd.ExecuteReader();

                    while (cat.Read())
                    {
                        string category = cat["category"].ToString();
                        MessageBox.Show(string.Format(category));

                        if (category == "admin")
                        {
                            mainFormAdmin useraliasadmin = new mainFormAdmin(username.Text);
                            useraliasadmin.Show(this);
                            this.Hide();
                        }
                        else
                        {
                            if (category == "secretaire")
                            {

                                mainFormSecretaire useraliassecret = new mainFormSecretaire(username.Text);
                                useraliassecret.Show(this);
                                this.Hide();
                            }
                            else
                            {
                                if (category == "medecin")
                                {


                                    mainFormMedecin useraliasmedecin = new mainFormMedecin(username.Text);
                                    useraliasmedecin.Show(this);
                                    this.Hide();
                                }
                            }
                        }


                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Esculape_Load(object sender, EventArgs e)
        {

        }
    }

}
