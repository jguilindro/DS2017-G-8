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
    public partial class AssitMain : Form
    {
        public AssitMain()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            agregarPersona persona = new agregarPersona();
            persona.ShowDialog();

        }

        private void AssitMain_Load(object sender, EventArgs e)
        {

        }
        
        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            agregarPlatos platos = new agregarPlatos();
            platos.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            agregarRestaurant rest = new agregarRestaurant();
            rest.ShowDialog();
        }
        void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
                this.Dispose();
        }

        private void AssitMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
