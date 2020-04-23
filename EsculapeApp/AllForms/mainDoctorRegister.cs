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
    public partial class mainDoctorRegister : Form
    {

        
        
        public mainDoctorRegister()
        {
            InitializeComponent();
            mname.MaxLength = 20;
            msurname.MaxLength = 20;
            mssnumber.MaxLength = 20;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mname_TextChanged(object sender, EventArgs e)
        {

        }

        private void msurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void musername_TextChanged(object sender, EventArgs e)
        {

        }

        private void mpassword_TextChanged(object sender, EventArgs e)
        {

        }



        

        private bool validate_mregister(string name, string surname, string m_username, string m_password, string m_ssnumber)
        {

            Esculape call = new Esculape();
            string cat = "medecin";
            call.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "INSERT INTO medecins(mname, mregisterdate, msurname, mssnumber) VALUES ('" + mname.Text + "', '" + mregisterdate.Value.Date.ToString("dd/MM/yyyy") + "', '" + msurname.Text + "', '" + mssnumber.Text + "')";
            cmd.Connection = call.connect;
            MySqlDataReader register = cmd.ExecuteReader();
            
            
            call.db_connection();
            MySqlCommand cmd2 = new MySqlCommand();
            cmd2.CommandText = "INSERT INTO user_account(user_name, password, category, ssnumber) VALUES ('" + musername.Text + "', '" + mpassword.Text + "', '" + cat + "', '" + mssnumber.Text + "')";
            cmd2.Connection = call.connect;
            cmd2.ExecuteNonQuery();



            if (register.Read())
            {

                call.connect.Close();
                return true;
                
                

            }
            else
            {
                call.connect.Close();
                return false;
            }
        }

        private void mregister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = mname.Text;
                string surname = msurname.Text;
                string m_username = musername.Text;
                string m_password = mpassword.Text;
                string m_ssnumber = mssnumber.Text;




                if (name == "" || surname == "" || m_username == "" || m_password == "" || m_ssnumber == "")
                {
                    MessageBox.Show("Tout les champs doivent être complétés !");
                    return;
                }
                bool r = validate_mregister(name, surname, m_username, m_password, m_ssnumber);
                MessageBox.Show("Inscription du medecin : " + name + " " + surname);







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }




        private void exit_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Hide();

        }

        private void label789_Click(object sender, EventArgs e)
        {

        }
    }
}
