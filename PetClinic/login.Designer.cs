namespace PetClinic
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox8_petcliniclogo = new System.Windows.Forms.PictureBox();
            this.comboBox_role = new System.Windows.Forms.ComboBox();
            this.label_username = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_login = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8_petcliniclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Lucida Sans Unicode", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.Color.SteelBlue;
            this.lbl_welcome.Location = new System.Drawing.Point(251, 52);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(401, 39);
            this.lbl_welcome.TabIndex = 84;
            this.lbl_welcome.Text = "Welcome To Pet Clinic !";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Location = new System.Drawing.Point(-4, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 385);
            this.panel3.TabIndex = 89;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox8_petcliniclogo
            // 
            this.pictureBox8_petcliniclogo.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8_petcliniclogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8_petcliniclogo.Image")));
            this.pictureBox8_petcliniclogo.Location = new System.Drawing.Point(-1, 3);
            this.pictureBox8_petcliniclogo.Name = "pictureBox8_petcliniclogo";
            this.pictureBox8_petcliniclogo.Size = new System.Drawing.Size(206, 183);
            this.pictureBox8_petcliniclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8_petcliniclogo.TabIndex = 91;
            this.pictureBox8_petcliniclogo.TabStop = false;
            // 
            // comboBox_role
            // 
            this.comboBox_role.FormattingEnabled = true;
            this.comboBox_role.Items.AddRange(new object[] {
            "Admin",
            "Receptionist",
            "Doctor"});
            this.comboBox_role.Location = new System.Drawing.Point(308, 158);
            this.comboBox_role.Name = "comboBox_role";
            this.comboBox_role.Size = new System.Drawing.Size(279, 28);
            this.comboBox_role.TabIndex = 92;
            this.comboBox_role.Text = "Role";
            this.comboBox_role.SelectedIndexChanged += new System.EventHandler(this.comboBox_role_SelectedIndexChanged);
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(304, 215);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(91, 20);
            this.label_username.TabIndex = 93;
            this.label_username.Text = "UserName";
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(308, 248);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(279, 32);
            this.textBox_username.TabIndex = 94;
            this.textBox_username.TextChanged += new System.EventHandler(this.textBox_username_TextChanged);
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(304, 312);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(83, 20);
            this.label_password.TabIndex = 95;
            this.label_password.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(308, 346);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(279, 32);
            this.textBox_password.TabIndex = 96;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.MediumBlue;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_login.Font = new System.Drawing.Font("Lucida Sans Unicode", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.White;
            this.button_login.Location = new System.Drawing.Point(384, 413);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(132, 45);
            this.button_login.TabIndex = 97;
            this.button_login.Text = "Login";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // button_close
            // 
            this.button_close.BackColor = System.Drawing.Color.Red;
            this.button_close.ForeColor = System.Drawing.Color.Black;
            this.button_close.Location = new System.Drawing.Point(627, 12);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(34, 31);
            this.button_close.TabIndex = 99;
            this.button_close.Text = "X";
            this.button_close.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 491);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.comboBox_role);
            this.Controls.Add(this.pictureBox8_petcliniclogo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lbl_welcome);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8_petcliniclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8_petcliniclogo;
        private System.Windows.Forms.ComboBox comboBox_role;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_close;
    }
}