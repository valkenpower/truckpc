namespace BCardLink
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Logintxt = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.PictureBox();
            this.username = new System.Windows.Forms.PictureBox();
            this.valkenpower_logo = new System.Windows.Forms.PictureBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valkenpower_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logintxt
            // 
            this.Logintxt.Font = new System.Drawing.Font("Arial Narrow", 20F, System.Drawing.FontStyle.Bold);
            this.Logintxt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Logintxt.Location = new System.Drawing.Point(126, 137);
            this.Logintxt.Name = "Logintxt";
            this.Logintxt.Size = new System.Drawing.Size(181, 73);
            this.Logintxt.TabIndex = 1;
            this.Logintxt.Text = "Login";
            this.Logintxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            this.password.Image = ((System.Drawing.Image)(resources.GetObject("password.Image")));
            this.password.Location = new System.Drawing.Point(67, 260);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(29, 28);
            this.password.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.password.TabIndex = 2;
            this.password.TabStop = false;
            // 
            // username
            // 
            this.username.Image = ((System.Drawing.Image)(resources.GetObject("username.Image")));
            this.username.Location = new System.Drawing.Point(67, 213);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(29, 28);
            this.username.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.username.TabIndex = 2;
            this.username.TabStop = false;
            // 
            // valkenpower_logo
            // 
            this.valkenpower_logo.Image = ((System.Drawing.Image)(resources.GetObject("valkenpower_logo.Image")));
            this.valkenpower_logo.Location = new System.Drawing.Point(65, 12);
            this.valkenpower_logo.Name = "valkenpower_logo";
            this.valkenpower_logo.Size = new System.Drawing.Size(306, 122);
            this.valkenpower_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.valkenpower_logo.TabIndex = 0;
            this.valkenpower_logo.TabStop = false;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlogin.Location = new System.Drawing.Point(65, 322);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(306, 46);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Log in";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(12, 442);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(63, 36);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "<";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtusername.Location = new System.Drawing.Point(115, 213);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(256, 28);
            this.txtusername.TabIndex = 7;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtpassword.Location = new System.Drawing.Point(115, 260);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(256, 28);
            this.txtpassword.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(442, 492);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.username);
            this.Controls.Add(this.Logintxt);
            this.Controls.Add(this.valkenpower_logo);
            this.Controls.Add(this.password);
            this.Location = new System.Drawing.Point(150, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valkenpower_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox valkenpower_logo;
        private System.Windows.Forms.Label Logintxt;
        private System.Windows.Forms.PictureBox username;
        private System.Windows.Forms.PictureBox password;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
    }
}