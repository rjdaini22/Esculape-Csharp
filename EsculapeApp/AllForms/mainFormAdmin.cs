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
    public partial class mainFormAdmin : Form
    {
        public mainFormAdmin(string useralias)
        {
            InitializeComponent();
            nom_user.Text = useralias;
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void patientregister_Click(object sender, EventArgs e)
        {
            mainPatientRegister mf = new mainPatientRegister();
            mf.Show();
            
        }

        private void pdelete_Click(object sender, EventArgs e)
        {
            mainDeletePatient mf = new mainDeletePatient();
            mf.Show();

        }

        private void user_label_Click(object sender, EventArgs e)
        {
            

        }

        private void mregisteradmin_Click(object sender, EventArgs e)
        {
            mainDoctorRegister mf = new mainDoctorRegister();
            mf.Show();

        }

        private void mdelete_Click(object sender, EventArgs e)
        {
            mainDeleteDoctor mf = new mainDeleteDoctor();
            mf.Show();

        }
    }
}
