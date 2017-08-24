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
    public partial class StudentMain : Form
    {

        public StudentMain()
        {
            InitializeComponent();
            OwnInitializeComponent();

        }
        private void OwnInitializeComponent()
        {
            this.restaurant = new System.Collections.Generic.List<Restaurant>();
            this.panelComida = new List<Panel>();

            // 
            // Agregando paneles automáticos en vista.
            // 
            restaurant.Add(new Restaurant("Malicia", Properties.Resources.malicia));
            restaurant.Add(new Restaurant("Lo mejor de lo nuestro", Properties.Resources.rectorado));
            restaurant.Add(new Restaurant("Frutanga", Properties.Resources.fcnm));
            restaurant.Add(new Restaurant("Neo", Properties.Resources.Edcom));
            restaurant.Add(new Restaurant("Coke-Cola", Properties.Resources.fiec));
            restaurant.Add(new Restaurant("comedor FCSH", Properties.Resources.fcsh));

            foreach (Restaurant rest in restaurant)
            {
                FlowMenuLayout.Controls.Add(crearLabel(rest));
            }
        }

        private System.Collections.Generic.List<Restaurant> restaurant;
        private System.Collections.Generic.List<System.Windows.Forms.Panel> panelComida;
        void panelClickHandler(object sender, EventArgs e, Restaurant rest)
        {
            flowEjecutivoPanel.Controls.Clear();
            flowEjecutivoPrecio.Controls.Clear();
            //Aquí habrá el evento cuando clické algún restaurant. La imagen e pondrá el de la facultad.
            FacultadImg.BackgroundImage = rest.getImagen();
            this.Facultad.Text = rest.getNombre();
            //
            //Busco los platos por el nombre de restaurante.
            //
            float total = 0f;
            foreach (Platillo plato in Program.platos) {
                if (plato.Restaurante.ToLower() == rest.getNombre().ToLower() ) {                   
                    flowEjecutivoPanel.Controls.Add(crearLabelPlato(plato));
                    total += plato.Precio;                    
                }
            }
            flowEjecutivoPrecio.Controls.Add(crearLabelPrecio(total));
            //
            //Fin
            //
        }
        private System.Windows.Forms.Label crearLabel(Restaurant rest)
        {
            System.Windows.Forms.Label titulo = new System.Windows.Forms.Label();
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.ForeColor = System.Drawing.Color.White;
            titulo.Name = rest.getNombre() + "-restaurant";
            titulo.Size = new System.Drawing.Size(420, 75);
            titulo.TabIndex = 0;
            titulo.Text = rest.getNombre();
            titulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            //Events right here
            //
            titulo.Click += (sender, e) => { panelClickHandler(sender, e, rest); };
            titulo.MouseEnter += (sender, e) => { Titulo_MouseEnter(sender, e, titulo); };
            titulo.MouseLeave += (sender, e) => { Titulo_MouseLeave(sender, e, titulo); };
            return titulo;
        }

        private Label crearLabelPlato(Platillo plato) {
            Label titulo = new Label();
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.ForeColor = System.Drawing.Color.White;
            titulo.Name = plato.Nombre;
            titulo.Size = new System.Drawing.Size(347, 50);
            titulo.TabIndex = 0;
            titulo.Text = plato.Nombre;
            titulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            return titulo;
        }

        private Label crearLabelPrecio(float plato)
        {
            Label titulo = new Label();
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.ForeColor = System.Drawing.Color.White;
            titulo.Name = Convert.ToString(plato);
            titulo.Size = new System.Drawing.Size(347, 50);
            titulo.TabIndex = 0;
            titulo.Text = Convert.ToString(plato);
            titulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;

            return titulo;
        }

        private void Titulo_MouseEnter(object sender, EventArgs e, System.Windows.Forms.Label titulo)
        {
            this.Cursor = Cursors.Hand;
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
        }
        private void Titulo_MouseLeave(object sender, EventArgs e, System.Windows.Forms.Label titulo)
        {
            this.Cursor = Cursors.Default;
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
        }

        private void FacultadImg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void StudentMain_Load(object sender, EventArgs e)
        {

        }

        private void StudentMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}