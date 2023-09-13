
namespace BCardLink
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnsettings = new System.Windows.Forms.Button();
            this.txtUID = new System.Windows.Forms.TextBox();
            this.cboDevices = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.874327F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.12567F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel1.Controls.Add(this.lblMessage, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnsettings, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cboDevices, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 640F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 768);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(123, 730);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(1093, 38);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "place card on the reader to scan until you see a loading bar.";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnsettings
            // 
            this.btnsettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsettings.BackgroundImage")));
            this.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnsettings.Location = new System.Drawing.Point(1239, 5);
            this.btnsettings.Margin = new System.Windows.Forms.Padding(20, 5, 3, 3);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(78, 44);
            this.btnsettings.TabIndex = 3;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUID
            // 
            this.txtUID.BackColor = System.Drawing.Color.White;
            this.txtUID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtUID.Location = new System.Drawing.Point(120, 62);
            this.txtUID.Margin = new System.Windows.Forms.Padding(0);
            this.txtUID.Multiline = true;
            this.txtUID.Name = "txtUID";
            this.txtUID.ReadOnly = true;
            this.txtUID.Size = new System.Drawing.Size(371, 29);
            this.txtUID.TabIndex = 4;
            this.txtUID.Visible = false;
            // 
            // cboDevices
            // 
            this.cboDevices.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDevices.FormattingEnabled = true;
            this.cboDevices.Location = new System.Drawing.Point(150, 18);
            this.cboDevices.Margin = new System.Windows.Forms.Padding(30, 18, 30, 30);
            this.cboDevices.Name = "cboDevices";
            this.cboDevices.Size = new System.Drawing.Size(204, 28);
            this.cboDevices.TabIndex = 2;
            this.cboDevices.SelectedIndexChanged += new System.EventHandler(this.cboDevices_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 20);
            this.label1.Size = new System.Drawing.Size(65, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "device:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "UID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(1267, 729);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.tableLayoutPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDevices;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.TextBox txtUID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

