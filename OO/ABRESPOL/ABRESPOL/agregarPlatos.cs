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
    public partial class agregarPlatos : Form
    {
        public agregarPlatos()
        {
            InitializeComponent();
            if (Program.persona.Rol == "Administrador") {
                this.restaurantBox.ReadOnly = false;
            }else
                this.restaurantBox.Text = Program.persona.IdRestaurante;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlatilloDirector director = new PlatilloDirector();
            PlatilloBuilder builder = new PlatilloBuilder();
            director.setPlatoBuilder(builder);
            director.construirPlato(textNombre.Text, descripcionBox.Text, float.Parse(textPrecio.Text), servidoBox.Text, tipoBox.Text, categoriasBox.Text, restaurantBox.Text);

            Program.platos.Add(director.getPlatillo());

            StudentMain student = new StudentMain();
            student.Show();
            this.Dispose();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
