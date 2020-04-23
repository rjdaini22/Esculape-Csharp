using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginForm
{
    public partial class mainFormMedecin : Form
    {
        public string passing;
        
        
        public mainFormMedecin(string useralias)
        {
            InitializeComponent();
           
            nom_user.Text = useralias;
            
        }

        private void user_label_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void mainFormMedecin_Load(object sender, EventArgs e)
        {
            

        }

        private void pregister_Click(object sender, EventArgs e)
        {
            mainPatientRegister mf = new mainPatientRegister();
            mf.Show();

        }

        private void user_login_name_Click(object sender, EventArgs e)
        {

            string passing = nom_user.Text;
            MessageBox.Show(passing, "Nom d'utilisateur");





        }

    }

    
}
