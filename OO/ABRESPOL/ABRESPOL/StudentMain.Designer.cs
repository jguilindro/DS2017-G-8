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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowEstudiantilPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowEjecutivoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.estudiantilLabel = new System.Windows.Forms.Label();
            this.ejecutivoLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.Facultad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowEjecutivoPrecio = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.FacultadImg.SuspendLayout();
            this.menuPanel.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1589, 140);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
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
            this.FacultadImg.Controls.Add(this.menuPanel);
            this.FacultadImg.Controls.Add(this.Facultad);
            this.FacultadImg.Controls.Add(this.panel3);
            this.FacultadImg.Location = new System.Drawing.Point(424, 142);
            this.FacultadImg.Name = "FacultadImg";
            this.FacultadImg.Size = new System.Drawing.Size(1162, 699);
            this.FacultadImg.TabIndex = 2;
            this.FacultadImg.Paint += new System.Windows.Forms.PaintEventHandler(this.FacultadImg_Paint);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.menuPanel.Controls.Add(this.flowLayoutPanel2);
            this.menuPanel.Controls.Add(this.flowEjecutivoPrecio);
            this.menuPanel.Controls.Add(this.button1);
            this.menuPanel.Controls.Add(this.flowEstudiantilPanel);
            this.menuPanel.Controls.Add(this.flowEjecutivoPanel);
            this.menuPanel.Controls.Add(this.estudiantilLabel);
            this.menuPanel.Controls.Add(this.ejecutivoLabel);
            this.menuPanel.Controls.Add(this.menuLabel);
            this.menuPanel.Location = new System.Drawing.Point(8, 400);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(1138, 299);
            this.menuPanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(885, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "¡Comprar!";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // flowEstudiantilPanel
            // 
            this.flowEstudiantilPanel.Location = new System.Drawing.Point(604, 139);
            this.flowEstudiantilPanel.Name = "flowEstudiantilPanel";
            this.flowEstudiantilPanel.Size = new System.Drawing.Size(395, 157);
            this.flowEstudiantilPanel.TabIndex = 4;
            // 
            // flowEjecutivoPanel
            // 
            this.flowEjecutivoPanel.Location = new System.Drawing.Point(63, 139);
            this.flowEjecutivoPanel.Name = "flowEjecutivoPanel";
            this.flowEjecutivoPanel.Size = new System.Drawing.Size(349, 157);
            this.flowEjecutivoPanel.TabIndex = 3;
            // 
            // estudiantilLabel
            // 
            this.estudiantilLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.estudiantilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estudiantilLabel.ForeColor = System.Drawing.Color.White;
            this.estudiantilLabel.Location = new System.Drawing.Point(582, 85);
            this.estudiantilLabel.Name = "estudiantilLabel";
            this.estudiantilLabel.Size = new System.Drawing.Size(436, 51);
            this.estudiantilLabel.TabIndex = 2;
            this.estudiantilLabel.Text = "Plato Estudiantil";
            // 
            // ejecutivoLabel
            // 
            this.ejecutivoLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ejecutivoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutivoLabel.ForeColor = System.Drawing.Color.White;
            this.ejecutivoLabel.Location = new System.Drawing.Point(56, 85);
            this.ejecutivoLabel.Name = "ejecutivoLabel";
            this.ejecutivoLabel.Size = new System.Drawing.Size(436, 51);
            this.ejecutivoLabel.TabIndex = 1;
            this.ejecutivoLabel.Text = "Plato Ejecutivo";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.White;
            this.menuLabel.Location = new System.Drawing.Point(56, 31);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(102, 39);
            this.menuLabel.TabIndex = 0;
            this.menuLabel.Text = "Menú";
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
            // flowEjecutivoPrecio
            // 
            this.flowEjecutivoPrecio.Location = new System.Drawing.Point(410, 139);
            this.flowEjecutivoPrecio.Name = "flowEjecutivoPrecio";
            this.flowEjecutivoPrecio.Size = new System.Drawing.Size(126, 157);
            this.flowEjecutivoPrecio.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(994, 139);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(120, 157);
            this.flowLayoutPanel2.TabIndex = 5;
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
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StudentMain_FormClosed);
            this.Load += new System.EventHandler(this.StudentMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.FacultadImg.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
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
        private Panel menuPanel;
        private Label menuLabel;
        private FlowLayoutPanel flowEstudiantilPanel;
        private FlowLayoutPanel flowEjecutivoPanel;
        private Label estudiantilLabel;
        private Label ejecutivoLabel;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowEjecutivoPrecio;
    }
}
