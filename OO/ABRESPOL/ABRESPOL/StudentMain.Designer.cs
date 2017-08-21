using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABRESPOL
{
    partial class StudentMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowMenuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FacultadImg = new System.Windows.Forms.Panel();
            this.Facultad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();

            this.restaurant = new System.Collections.Generic.List<Restaurant>();
            this.panelComida = new System.Collections.Generic.List<System.Windows.Forms.Panel>();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FacultadImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FlowMenuLayout);
            this.panel1.Location = new System.Drawing.Point(0, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 725);
            this.panel1.TabIndex = 0;
            // 
            // FlowMenuLayout
            // 
            this.FlowMenuLayout.AutoScroll = true;
            this.FlowMenuLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowMenuLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.FlowMenuLayout.Location = new System.Drawing.Point(0, 0);
            this.FlowMenuLayout.Name = "FlowMenuLayout";
            this.FlowMenuLayout.Size = new System.Drawing.Size(426, 725);
            this.FlowMenuLayout.TabIndex = 0;
            this.FlowMenuLayout.WrapContents = false;
            // 
            // Agregando paneles automáticos en vista.
            // 
            restaurant.Add(new Restaurant("Malicia", Properties.Resources.malicia));
            restaurant.Add(new Restaurant("Lo mejor de lo nuestro", Properties.Resources.rectorado));
            restaurant.Add(new Restaurant("Frutang", Properties.Resources.malicia));
            restaurant.Add(new Restaurant("Neo", Properties.Resources.malicia));
            restaurant.Add(new Restaurant("Coke-Cola", Properties.Resources.malicia));
            restaurant.Add(new Restaurant("comedor FCSH", Properties.Resources.malicia));

            foreach (Restaurant rest in restaurant) {
                FlowMenuLayout.Controls.Add(crearLabel(rest));
            }
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1589, 140);
            this.panel2.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(495, 44);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(390, 58);
            this.Title.TabIndex = 0;
            this.Title.Text = "ABRESPOL";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Image = global::ABRESPOL.Properties.Resources.logo;
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 107);
            this.label1.TabIndex = 1;
            // 
            // FacultadImg
            // 
            this.FacultadImg.BackgroundImage = global::ABRESPOL.Properties.Resources.rectorado;
            this.FacultadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FacultadImg.Controls.Add(this.Facultad);
            this.FacultadImg.Controls.Add(this.panel3);
            this.FacultadImg.Location = new System.Drawing.Point(424, 142);
            this.FacultadImg.Name = "FacultadImg";
            this.FacultadImg.Size = new System.Drawing.Size(1146, 699);
            this.FacultadImg.TabIndex = 2;
            // 
            // Facultad
            // 
            this.Facultad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.Facultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Facultad.ForeColor = System.Drawing.Color.White;
            this.Facultad.Location = new System.Drawing.Point(65, 133);
            this.Facultad.Name = "Facultad";
            this.Facultad.Padding = new System.Windows.Forms.Padding(150, 0, 0, 0);
            this.Facultad.Size = new System.Drawing.Size(1034, 56);
            this.Facultad.TabIndex = 0;
            this.Facultad.Text = "Facultad";
            this.Facultad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel3.Location = new System.Drawing.Point(64, 124);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 81);
            this.panel3.TabIndex = 1;
            // 
            // StudentMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.FacultadImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "StudentMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.FacultadImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel FlowMenuLayout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel FacultadImg;
        private System.Windows.Forms.Label Facultad;
        private System.Windows.Forms.Panel panel3;

        private System.Collections.Generic.List<Restaurant> restaurant;
        private System.Collections.Generic.List<System.Windows.Forms.Panel> panelComida;
        void panelClickHandler(object sender, EventArgs e, Bitmap image)
        {
            Console.Write("ads");
            FacultadImg.BackgroundImage = image;
        }
        private System.Windows.Forms.Label crearLabel(Restaurant rest) {
            System.Windows.Forms.Label titulo = new System.Windows.Forms.Label();
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titulo.ForeColor = System.Drawing.Color.White;
            titulo.Name = rest.getNombre() + "-restaurant";
            titulo.Size = new System.Drawing.Size(420, 75);
            titulo.TabIndex = 0;
            titulo.Text = rest.getNombre() ;
            titulo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            //Events right here
            //
            titulo.Click += (sender, e) => { panelClickHandler(sender, e, rest.getImagen()); };
            titulo.MouseEnter += (sender, e) => { Titulo_MouseEnter(sender, e, titulo); };
            titulo.MouseLeave += (sender, e) => { Titulo_MouseLeave(sender, e, titulo); };
            return titulo;
        }

        private void Titulo_MouseEnter(object sender, EventArgs e, System.Windows.Forms.Label titulo){
            this.Cursor = Cursors.Hand;
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
        }
        private void Titulo_MouseLeave(object sender, EventArgs e, System.Windows.Forms.Label titulo) {
            this.Cursor = Cursors.Default;
            titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
        }
    }
}
