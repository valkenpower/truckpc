﻿namespace BCardLink
{
    partial class form2
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
            this.btnwijzig = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change URL:";
            // 
            // txturlchanger
            // 
            this.txturlchanger.Location = new System.Drawing.Point(301, 250);
            this.txturlchanger.Name = "txturlchanger";
            this.txturlchanger.Size = new System.Drawing.Size(100, 20);
            this.txturlchanger.TabIndex = 1;
            this.txturlchanger.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(419, 295);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(145, 110);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnwijzig
            // 
            this.btnwijzig.Location = new System.Drawing.Point(419, 147);
            this.btnwijzig.Name = "btnwijzig";
            this.btnwijzig.Size = new System.Drawing.Size(145, 107);
            this.btnwijzig.TabIndex = 5;
            this.btnwijzig.Text = "wijzig";
            this.btnwijzig.UseVisualStyleBackColor = true;
            this.btnwijzig.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(584, 250);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(145, 110);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(741, 559);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnwijzig);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txturlchanger);
            this.Controls.Add(this.label1);
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txturlchanger;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnwijzig;
        private System.Windows.Forms.Button btnexit;
    }
}