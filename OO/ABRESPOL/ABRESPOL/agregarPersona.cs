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
    public partial class agregarPersona : Form
    {
        public agregarPersona()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(userText.Text, passText.Text, tipoPersona.Text);
            this.Dispose();
        }
    }
}
