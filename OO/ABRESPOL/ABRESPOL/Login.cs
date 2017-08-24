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
            bool enter = false;
            if (userTextbox.Text.ToLower() == "jamytafy" && passwordTextbox.Text == "123") {
                Jamytafy jamy = new Jamytafy();
                jamy.ShowDialog();
                enter = true;
            }
            //
            //Si es un estudiante
            //
            if (userTextbox.Text.ToLower() == "user" && passwordTextbox.Text == "123") {
                StudentMain estudiante = new StudentMain();
                estudiante.Show();
                enter = true;
            }
            //
            //Si es admin o asistente
            //
            if(userTextbox.Text.ToLower() == "admin" && passwordTextbox.Text == "123"){
                Program.persona.Username = "admin";
                Program.persona.Password = "123";
                Program.persona.Rol = "Administrador";
                Program.persona.IdRestaurante = "";

                AssitMain asistente = new AssitMain();
                asistente.Show();
                enter = true;
            }
            if (userTextbox.Text.ToLower() == "asist" && passwordTextbox.Text == "123")
            {
                Program.persona.Username        =   "asist";
                Program.persona.Password        =   "123";
                Program.persona.Rol             =   "Ejecutivo";
                Program.persona.IdRestaurante   =   "Malicia";

                AssitMain asistente = new AssitMain();
                asistente.Show();
                enter = true;
            }
            if (enter)
            {
                this.Hide();
            }
            else
                Console.WriteLine("EEERRROOOR");
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
