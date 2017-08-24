using System.Windows.Forms;

namespace ABRESPOL
{
    partial class AssitMain
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlowMenuLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.platosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FacultadImg = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowEstudiantilPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowEjecutivoPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.estudiantilLabel = new System.Windows.Forms.Label();
            this.ejecutivoLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.Facultad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.platosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.agregarToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.FacultadImg.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
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
            this.panel2.Controls.Add(this.menuStrip1);
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.platosToolStripMenuItem1,
            this.restaurantsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1589, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // platosToolStripMenuItem1
            // 
            this.platosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem1,
            this.eliminarToolStripMenuItem});
            this.platosToolStripMenuItem1.Name = "platosToolStripMenuItem1";
            this.platosToolStripMenuItem1.Size = new System.Drawing.Size(61, 24);
            this.platosToolStripMenuItem1.Text = "Platos";
            // 
            // agregarToolStripMenuItem1
            // 
            this.agregarToolStripMenuItem1.Name = "agregarToolStripMenuItem1";
            this.agregarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.agregarToolStripMenuItem1.Size = new System.Drawing.Size(191, 26);
            this.agregarToolStripMenuItem1.Text = "Agregar";
            this.agregarToolStripMenuItem1.Click += new System.EventHandler(this.agregarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // restaurantsToolStripMenuItem
            // 
            this.restaurantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem2,
            this.eliminarToolStripMenuItem1});
            this.restaurantsToolStripMenuItem.Name = "restaurantsToolStripMenuItem";
            this.restaurantsToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.restaurantsToolStripMenuItem.Text = "Restaurants";
            // 
            // FacultadImg
            // 
            this.FacultadImg.BackgroundImage = global::ABRESPOL.Properties.Resources.rectorado;
            this.FacultadImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FacultadImg.Controls.Add(this.label2);
            this.FacultadImg.Controls.Add(this.addBtn);
            this.FacultadImg.Controls.Add(this.menuPanel);
            this.FacultadImg.Controls.Add(this.Facultad);
            this.FacultadImg.Controls.Add(this.panel3);
            this.FacultadImg.Location = new System.Drawing.Point(424, 142);
            this.FacultadImg.Name = "FacultadImg";
            this.FacultadImg.Size = new System.Drawing.Size(1162, 699);
            this.FacultadImg.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1041, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agregar personas";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.addBtn.Location = new System.Drawing.Point(1045, -1);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addBtn.Size = new System.Drawing.Size(60, 60);
            this.addBtn.TabIndex = 3;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
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
            this.flowEstudiantilPanel.Size = new System.Drawing.Size(487, 157);
            this.flowEstudiantilPanel.TabIndex = 4;
            // 
            // flowEjecutivoPanel
            // 
            this.flowEjecutivoPanel.Location = new System.Drawing.Point(63, 139);
            this.flowEjecutivoPanel.Name = "flowEjecutivoPanel";
            this.flowEjecutivoPanel.Size = new System.Drawing.Size(487, 157);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 28);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.platosToolStripMenuItem,
            this.agregarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(115, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // platosToolStripMenuItem
            // 
            this.platosToolStripMenuItem.Name = "platosToolStripMenuItem";
            this.platosToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.platosToolStripMenuItem.Text = "Platos";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.agregarToolStripMenuItem.Text = "Agregar";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // agregarToolStripMenuItem2
            // 
            this.agregarToolStripMenuItem2.Name = "agregarToolStripMenuItem2";
            this.agregarToolStripMenuItem2.Size = new System.Drawing.Size(181, 26);
            this.agregarToolStripMenuItem2.Text = "Agregar";
            this.agregarToolStripMenuItem2.Click += new System.EventHandler(this.agregarToolStripMenuItem2_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            // 
            // AssitMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.FacultadImg);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1600, 900);
            this.MinimumSize = new System.Drawing.Size(1600, 900);
            this.Name = "AssitMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentMain";
            this.Load += new System.EventHandler(this.AssitMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.FacultadImg.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
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
        private Button addBtn;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem platosToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem platosToolStripMenuItem1;
        private ToolStripMenuItem agregarToolStripMenuItem1;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private ToolStripMenuItem restaurantsToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem agregarToolStripMenuItem2;
        private ToolStripMenuItem eliminarToolStripMenuItem1;
    }
}