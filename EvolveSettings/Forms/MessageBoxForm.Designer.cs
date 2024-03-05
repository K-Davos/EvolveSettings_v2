namespace EvolveSettings
{
    partial class MessageBoxForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxForm));
            this.pnlTitleBar = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblCaption = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelInfoBody = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.ShadowFormMsgBox = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.btn1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pnlTitleBar.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.panelInfoBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTitleBar.Controls.Add(this.btnClose);
            this.pnlTitleBar.Controls.Add(this.lblCaption);
            this.pnlTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(350, 35);
            this.pnlTitleBar.TabIndex = 3;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTitleBar_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(315, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 17;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.ForeColor = System.Drawing.Color.White;
            this.lblCaption.Location = new System.Drawing.Point(7, 9);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(81, 17);
            this.lblCaption.TabIndex = 4;
            this.lblCaption.Text = "labelCaption";
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlButtons.Controls.Add(this.button3);
            this.pnlButtons.Controls.Add(this.button2);
            this.pnlButtons.Controls.Add(this.button1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 90);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(350, 60);
            this.pnlButtons.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(231, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 35);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(125, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(19, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panelInfoBody
            // 
            this.panelInfoBody.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInfoBody.Controls.Add(this.lblMessage);
            this.panelInfoBody.Controls.Add(this.pictureBoxIcon);
            this.panelInfoBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInfoBody.Location = new System.Drawing.Point(0, 35);
            this.panelInfoBody.Name = "panelInfoBody";
            this.panelInfoBody.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.panelInfoBody.Size = new System.Drawing.Size(350, 115);
            this.panelInfoBody.TabIndex = 5;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(50, 10);
            this.lblMessage.MaximumSize = new System.Drawing.Size(600, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(5, 5, 10, 15);
            this.lblMessage.Size = new System.Drawing.Size(104, 37);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "labelMessage";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxIcon.Image = global::EvolveSettings.Properties.Resources.chat;
            this.pictureBoxIcon.Location = new System.Drawing.Point(10, 10);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(40, 105);
            this.pictureBoxIcon.TabIndex = 0;
            this.pictureBoxIcon.TabStop = false;
            // 
            // ShadowFormMsgBox
            // 
            this.ShadowFormMsgBox.BorderRadius = 0;
            this.ShadowFormMsgBox.TargetForm = this;
            // 
            // btn1
            // 
            this.btn1.BorderRadius = 5;
            this.btn1.TargetControl = this.button1;
            // 
            // btn2
            // 
            this.btn2.BorderRadius = 5;
            this.btn2.TargetControl = this.button2;
            // 
            // btn3
            // 
            this.btn3.BorderRadius = 5;
            this.btn3.TargetControl = this.button3;
            // 
            // MessageBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 150);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.panelInfoBody);
            this.Controls.Add(this.pnlTitleBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageBoxForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MessageBoxForm";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.panelInfoBody.ResumeLayout(false);
            this.panelInfoBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitleBar;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel panelInfoBody;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private System.Windows.Forms.Button btnClose;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowFormMsgBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2Elipse btn1;
        private Guna.UI2.WinForms.Guna2Elipse btn2;
        private Guna.UI2.WinForms.Guna2Elipse btn3;
    }
}