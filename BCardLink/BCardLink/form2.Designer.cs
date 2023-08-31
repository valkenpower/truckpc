namespace BCardLink
{
    partial class wijzig_url
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
            this.label1 = new System.Windows.Forms.Label();
            this.txturlchanger = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change URL:";
            // 
            // txturlchanger
            // 
            this.txturlchanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txturlchanger.Location = new System.Drawing.Point(179, 49);
            this.txturlchanger.Name = "txturlchanger";
            this.txturlchanger.Size = new System.Drawing.Size(387, 26);
            this.txturlchanger.TabIndex = 1;
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnsave.Location = new System.Drawing.Point(155, 108);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(119, 35);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnexit.Location = new System.Drawing.Point(12, 108);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(119, 35);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // wijzig_url
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(602, 155);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txturlchanger);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wijzig_url";
            this.Text = "form2";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturlchanger;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnexit;
    }
}