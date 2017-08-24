namespace ABRESPOL
{
    partial class Login
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
            this.userTextbox = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.logButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoWhite = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel1.Location = new System.Drawing.Point(-11, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 21);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // userTextbox
            // 
            this.userTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTextbox.Location = new System.Drawing.Point(246, 229);
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.Size = new System.Drawing.Size(272, 26);
            this.userTextbox.TabIndex = 1;
            this.userTextbox.TextChanged += new System.EventHandler(this.userTextbox_TextChanged);
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.Location = new System.Drawing.Point(102, 226);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(107, 29);
            this.User.TabIndex = 2;
            this.User.Text = "Usuario:";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(77, 328);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(157, 29);
            this.password.TabIndex = 4;
            this.password.Text = "Contraseña: ";
            this.password.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(246, 331);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '*';
            this.passwordTextbox.Size = new System.Drawing.Size(272, 26);
            this.passwordTextbox.TabIndex = 3;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.logButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.White;
            this.logButton.Location = new System.Drawing.Point(224, 455);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(258, 53);
            this.logButton.TabIndex = 5;
            this.logButton.Text = "Iniciar sesión";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 58);
            this.label1.TabIndex = 6;
            this.label1.Text = "ABRESPOL";
            // 
            // logoWhite
            // 
            this.logoWhite.Image = global::ABRESPOL.Properties.Resources.dark_logo;
            this.logoWhite.Location = new System.Drawing.Point(105, 33);
            this.logoWhite.Name = "logoWhite";
            this.logoWhite.Size = new System.Drawing.Size(129, 110);
            this.logoWhite.TabIndex = 7;
            this.logoWhite.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(34)))), ((int)(((byte)(63)))));
            this.panel2.Location = new System.Drawing.Point(-2, 558);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 10);
            this.panel2.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 569);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.logoWhite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.User);
            this.Controls.Add(this.userTextbox);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox userTextbox;
        private System.Windows.Forms.Label User;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label logoWhite;
        private System.Windows.Forms.Panel panel2;
    }
}

