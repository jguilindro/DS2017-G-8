namespace ABRESPOL
{
    partial class agregarPersona
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
            this.Title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoPersona = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.restaurantBox = new System.Windows.Forms.ComboBox();
            this.userText = new System.Windows.Forms.TextBox();
            this.passText = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(165, 40);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(336, 58);
            this.Title.TabIndex = 0;
            this.Title.Text = "ABRESPOL";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.Title);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 142);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Image = global::ABRESPOL.Properties.Resources.logo;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 109);
            this.label1.TabIndex = 1;
            // 
            // tipoPersona
            // 
            this.tipoPersona.FormattingEnabled = true;
            this.tipoPersona.Items.AddRange(new object[] {
            "Asistente",
            "Estudiante"});
            this.tipoPersona.Location = new System.Drawing.Point(116, 247);
            this.tipoPersona.Name = "tipoPersona";
            this.tipoPersona.Size = new System.Drawing.Size(379, 24);
            this.tipoPersona.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de persona";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contraeña";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Restaurante";
            // 
            // restaurantBox
            // 
            this.restaurantBox.FormattingEnabled = true;
            this.restaurantBox.Items.AddRange(new object[] {
            "Asistente",
            "Estudiante"});
            this.restaurantBox.Location = new System.Drawing.Point(116, 576);
            this.restaurantBox.Name = "restaurantBox";
            this.restaurantBox.Size = new System.Drawing.Size(379, 24);
            this.restaurantBox.TabIndex = 9;
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(116, 358);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(379, 22);
            this.userText.TabIndex = 11;
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(117, 467);
            this.passText.Name = "passText";
            this.passText.PasswordChar = '*';
            this.passText.Size = new System.Drawing.Size(379, 22);
            this.passText.TabIndex = 12;
            this.passText.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Location = new System.Drawing.Point(338, 654);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 34);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Agregar";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(114, 654);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(136, 34);
            this.cancel.TabIndex = 14;
            this.cancel.Text = "Cancelar";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // agregarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 714);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.passText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.restaurantBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tipoPersona);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "agregarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar usuario";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox tipoPersona;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox restaurantBox;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancel;
    }
}