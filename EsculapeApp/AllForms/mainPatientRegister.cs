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
    public partial class mainPatientRegister : Form
    {
        
        public mainPatientRegister()
        {
            InitializeComponent();
            pname.MaxLength = 20;
            psurname.MaxLength = 20;
            pssnumber.MaxLength = 50;
        }

        

        private bool validate_pregister(string name, string surname, string ssnumber)
        {

            Esculape call = new Esculape();

            call.db_connection();
            MySqlCommand cmd = new MySqlCommand();

            cmd.CommandText = "INSERT INTO patients(name, bday, ssnumber, surname) VALUES ('" + pname.Text + "', '" + bdayPicker.Value.Date.ToString("dd/MM/yyyy") + "', '" + pssnumber.Text + "', '" + psurname.Text + "') ";
            cmd.Connection = call.connect;
            MySqlDataReader register = cmd.ExecuteReader();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }



        private void pregister_Click(object sender, EventArgs e)
        {
            try
            {
                string name = pname.Text;
                string surname = psurname.Text;
                string ssnumber = psurname.Text;

                

                if (name == "" || surname == "" || ssnumber == "") 
                {
                    MessageBox.Show("Tout les champs doivent être complétés !");
                    return;
                }
                bool r = validate_pregister(name, surname, ssnumber);
                MessageBox.Show("Inscription du patient : " + name + " " + surname);







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




        private void mainPatientRegister_Load(object sender, EventArgs e)
        {

        }

        private void bdayPicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
