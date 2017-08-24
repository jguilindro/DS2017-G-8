using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABRESPOL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (userTextbox.Text == "Jamytafy" && passwordTextbox.Text == "123") {
                Jamytafy jamy = new Jamytafy();
                jamy.Show();
            }
            //
            //Si es un estudiante
            //
            //StudentMain estudiante = new StudentMain();
            //estudiante.Show();
            //
            //Si es admin o asistente
            //
            else {
                AssitMain asistente = new AssitMain();
                asistente.Show();
            }
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CheckEnter(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Enter key pressed
                logButton.PerformClick();
            }
        }
    }
}
