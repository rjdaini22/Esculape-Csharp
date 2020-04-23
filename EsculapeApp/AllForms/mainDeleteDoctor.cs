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
    public partial class mainDeleteDoctor : Form
    {

        
        public mainDeleteDoctor()
        {
            InitializeComponent();
           
        }


        

        private bool validate_mdelete(string name)
        {
           
            
            Esculape call = new Esculape();

            
            call.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "DELETE medecins, user_account FROM user_account INNER JOIN medecins ON user_account.ssnumber = medecins.mssnumber WHERE user_account.user_name = '" + comboBox1.Text + "'; ";
            cmd.Connection = call.connect;
            MySqlDataReader delete = cmd.ExecuteReader();

            MessageBox.Show("Supression du médecin : " + name + "");





            if (delete.Read())
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
        private void mainDeleteDoctor_Load(object sender, EventArgs e)
        {
            Fillcombobox();

        }
    

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        void Fillcombobox()
        {
            Esculape call = new Esculape();

            call.db_connection();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT user_name FROM user_account WHERE category = 'medecin'";
            cmd.Connection = call.connect;
            MySqlDataReader combo = cmd.ExecuteReader();
            while (combo.Read())
            {
                for (int i = 0; i < combo.FieldCount; i++)
                {
                    comboBox1.Items.Add(combo.GetString(i));

                }
            }
            combo.Close();
            call.connect.Close();

        }


        private void mdelete_Click(object sender, EventArgs e)
        {
            try
            {
               
                string name = comboBox1.Text;
                



                if (name == "")
                {
                    MessageBox.Show("Un médecin doit être sélectionné !");
                    return;
                }
                bool r = validate_mdelete(name);
                







            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
