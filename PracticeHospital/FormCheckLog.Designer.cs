namespace PracticeHospital
{
    partial class FormCheckLog
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
            this.PanelDrag = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RtbxPass = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RtbxLogin = new System.Windows.Forms.RichTextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.PanelDrag.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDrag
            // 
            this.PanelDrag.BackColor = System.Drawing.Color.DarkCyan;
            this.PanelDrag.Controls.Add(this.BtnClose);
            this.PanelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelDrag.Location = new System.Drawing.Point(0, 0);
            this.PanelDrag.Name = "PanelDrag";
            this.PanelDrag.Size = new System.Drawing.Size(385, 34);
            this.PanelDrag.TabIndex = 0;
            this.PanelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseDown);
            this.PanelDrag.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseMove);
            this.PanelDrag.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseUp);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnClose.FlatAppearance.BorderSize = 0;
            this.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClose.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.Location = new System.Drawing.Point(343, 3);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(39, 29);
            this.BtnClose.TabIndex = 21;
            this.BtnClose.Text = "✖️";
            this.BtnClose.UseVisualStyleBackColor = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(38, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 2);
            this.panel2.TabIndex = 19;
            // 
            // RtbxPass
            // 
            this.RtbxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxPass.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxPass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxPass.Location = new System.Drawing.Point(38, 108);
            this.RtbxPass.Name = "RtbxPass";
            this.RtbxPass.Size = new System.Drawing.Size(314, 34);
            this.RtbxPass.TabIndex = 18;
            this.RtbxPass.Text = "Введите пароль";
            this.RtbxPass.Enter += new System.EventHandler(this.RtbxPass_Enter);
            this.RtbxPass.Leave += new System.EventHandler(this.RtbxPass_Leave);
            this.RtbxPass.MouseLeave += new System.EventHandler(this.RtbxPass_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(38, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(314, 2);
            this.panel3.TabIndex = 17;
            // 
            // RtbxLogin
            // 
            this.RtbxLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxLogin.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxLogin.ForeColor = System.Drawing.SystemColors.GrayText;
            this.RtbxLogin.Location = new System.Drawing.Point(38, 53);
            this.RtbxLogin.Name = "RtbxLogin";
            this.RtbxLogin.Size = new System.Drawing.Size(314, 34);
            this.RtbxLogin.TabIndex = 16;
            this.RtbxLogin.Text = "Введите логин";
            this.RtbxLogin.Enter += new System.EventHandler(this.RtbxLogin_Enter);
            this.RtbxLogin.Leave += new System.EventHandler(this.RtbxLogin_Leave);
            this.RtbxLogin.MouseLeave += new System.EventHandler(this.RtbxLogin_MouseLeave);
            // 
            // BtnEnter
            // 
            this.BtnEnter.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnEnter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnEnter.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnEnter.FlatAppearance.BorderSize = 0;
            this.BtnEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnEnter.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnEnter.ForeColor = System.Drawing.Color.White;
            this.BtnEnter.Location = new System.Drawing.Point(124, 169);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(129, 30);
            this.BtnEnter.TabIndex = 20;
            this.BtnEnter.Text = "Войти";
            this.BtnEnter.UseVisualStyleBackColor = false;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // FormCheckLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(385, 217);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.RtbxPass);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.RtbxLogin);
            this.Controls.Add(this.PanelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormCheckLog";
            this.Shown += new System.EventHandler(this.FormCheckLog_Shown);
            this.PanelDrag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelDrag;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox RtbxPass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox RtbxLogin;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnClose;
    }
}