namespace PracticeHospital
{
    partial class FormSignUp
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.CmbRegisrtyPlace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbDoctor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RtbxFIO = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Rtbx4 = new System.Windows.Forms.RichTextBox();
            this.Rtbx3 = new System.Windows.Forms.RichTextBox();
            this.Rtbx2 = new System.Windows.Forms.RichTextBox();
            this.Rtbx1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnComplete = new System.Windows.Forms.Button();
            this.CheckCurrent = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.LblMin = new System.Windows.Forms.Label();
            this.LblQueue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(64, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(333, 28);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.DarkCyan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Запись на прием";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbRegisrtyPlace
            // 
            this.CmbRegisrtyPlace.AllowDrop = true;
            this.CmbRegisrtyPlace.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbRegisrtyPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbRegisrtyPlace.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbRegisrtyPlace.ForeColor = System.Drawing.Color.Black;
            this.CmbRegisrtyPlace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CmbRegisrtyPlace.Items.AddRange(new object[] {
            "г. Новозыбков",
            "Новозыбковский район",
            "Иной регион"});
            this.CmbRegisrtyPlace.Location = new System.Drawing.Point(21, 94);
            this.CmbRegisrtyPlace.Name = "CmbRegisrtyPlace";
            this.CmbRegisrtyPlace.Size = new System.Drawing.Size(314, 34);
            this.CmbRegisrtyPlace.TabIndex = 62;
            this.CmbRegisrtyPlace.MouseLeave += new System.EventHandler(this.CmbRegisrtyPlace_MouseLeave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightCyan;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 27);
            this.label2.TabIndex = 63;
            this.label2.Text = "Данные места регистрации";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CmbDoctor
            // 
            this.CmbDoctor.AllowDrop = true;
            this.CmbDoctor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CmbDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDoctor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CmbDoctor.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CmbDoctor.ForeColor = System.Drawing.Color.Black;
            this.CmbDoctor.FormattingEnabled = true;
            this.CmbDoctor.Items.AddRange(new object[] {
            "Врач-терапевт участковый",
            "Врач-хирург",
            "Врач-стоматолог",
            "Врач-психиатр"});
            this.CmbDoctor.Location = new System.Drawing.Point(122, 331);
            this.CmbDoctor.Name = "CmbDoctor";
            this.CmbDoctor.Size = new System.Drawing.Size(314, 34);
            this.CmbDoctor.TabIndex = 64;
            this.CmbDoctor.SelectedIndexChanged += new System.EventHandler(this.CmbDoctor_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LightCyan;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(175, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 27);
            this.label3.TabIndex = 65;
            this.label3.Text = "Квалификация врача";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RtbxFIO
            // 
            this.RtbxFIO.BackColor = System.Drawing.Color.White;
            this.RtbxFIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RtbxFIO.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RtbxFIO.ForeColor = System.Drawing.Color.DarkCyan;
            this.RtbxFIO.Location = new System.Drawing.Point(19, 3);
            this.RtbxFIO.Name = "RtbxFIO";
            this.RtbxFIO.Size = new System.Drawing.Size(395, 32);
            this.RtbxFIO.TabIndex = 66;
            this.RtbxFIO.Text = "Введите ФИО";
            this.RtbxFIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RtbxFIO_KeyPress);
            this.RtbxFIO.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RtbxLogin_MouseDown);
            this.RtbxFIO.MouseLeave += new System.EventHandler(this.RtbxFIO_MouseLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.RtbxFIO);
            this.panel3.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel3.Location = new System.Drawing.Point(21, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 40);
            this.panel3.TabIndex = 67;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Rtbx4);
            this.panel1.Controls.Add(this.Rtbx3);
            this.panel1.Controls.Add(this.Rtbx2);
            this.panel1.Controls.Add(this.Rtbx1);
            this.panel1.ForeColor = System.Drawing.Color.DarkCyan;
            this.panel1.Location = new System.Drawing.Point(21, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 40);
            this.panel1.TabIndex = 68;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkCyan;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(212, 3);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 27);
            this.label7.TabIndex = 72;
            this.label7.Text = "–";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkCyan;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(97, 3);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 27);
            this.label6.TabIndex = 71;
            this.label6.Text = "–";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rtbx4
            // 
            this.Rtbx4.BackColor = System.Drawing.Color.White;
            this.Rtbx4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtbx4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtbx4.ForeColor = System.Drawing.Color.DarkCyan;
            this.Rtbx4.Location = new System.Drawing.Point(351, 3);
            this.Rtbx4.Name = "Rtbx4";
            this.Rtbx4.Size = new System.Drawing.Size(51, 31);
            this.Rtbx4.TabIndex = 71;
            this.Rtbx4.Text = "";
            this.Rtbx4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtbx4_KeyPress);
            // 
            // Rtbx3
            // 
            this.Rtbx3.BackColor = System.Drawing.Color.White;
            this.Rtbx3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtbx3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtbx3.ForeColor = System.Drawing.Color.DarkCyan;
            this.Rtbx3.Location = new System.Drawing.Point(247, 3);
            this.Rtbx3.Name = "Rtbx3";
            this.Rtbx3.Size = new System.Drawing.Size(78, 31);
            this.Rtbx3.TabIndex = 71;
            this.Rtbx3.Text = "";
            this.Rtbx3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtbx3_KeyPress);
            // 
            // Rtbx2
            // 
            this.Rtbx2.BackColor = System.Drawing.Color.White;
            this.Rtbx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtbx2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtbx2.ForeColor = System.Drawing.Color.DarkCyan;
            this.Rtbx2.Location = new System.Drawing.Point(132, 3);
            this.Rtbx2.Name = "Rtbx2";
            this.Rtbx2.Size = new System.Drawing.Size(77, 31);
            this.Rtbx2.TabIndex = 67;
            this.Rtbx2.Text = "";
            this.Rtbx2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtbx2_KeyPress);
            // 
            // Rtbx1
            // 
            this.Rtbx1.BackColor = System.Drawing.Color.White;
            this.Rtbx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Rtbx1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Rtbx1.ForeColor = System.Drawing.Color.DarkCyan;
            this.Rtbx1.Location = new System.Drawing.Point(19, 3);
            this.Rtbx1.Name = "Rtbx1";
            this.Rtbx1.Size = new System.Drawing.Size(75, 31);
            this.Rtbx1.TabIndex = 66;
            this.Rtbx1.Text = "";
            this.Rtbx1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Rtbx1_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightCyan;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(19, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 27);
            this.label4.TabIndex = 69;
            this.label4.Text = "Персональные данные(ФИО)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightCyan;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(21, 219);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(351, 27);
            this.label5.TabIndex = 70;
            this.label5.Text = "Данные страхового свидетельства\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnComplete
            // 
            this.BtnComplete.BackColor = System.Drawing.Color.DarkCyan;
            this.BtnComplete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnComplete.Enabled = false;
            this.BtnComplete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.BtnComplete.FlatAppearance.BorderSize = 0;
            this.BtnComplete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BtnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnComplete.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnComplete.ForeColor = System.Drawing.Color.White;
            this.BtnComplete.Location = new System.Drawing.Point(64, 445);
            this.BtnComplete.Name = "BtnComplete";
            this.BtnComplete.Size = new System.Drawing.Size(333, 35);
            this.BtnComplete.TabIndex = 71;
            this.BtnComplete.Text = "Подтвердить запись\r\n\r\n";
            this.BtnComplete.UseVisualStyleBackColor = false;
            this.BtnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
            // 
            // CheckCurrent
            // 
            this.CheckCurrent.Interval = 400;
            this.CheckCurrent.Tick += new System.EventHandler(this.CheckCurrent_Tick);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.LightCyan;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(78, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(257, 27);
            this.label8.TabIndex = 72;
            this.label8.Text = "Среднее время ожидания:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblMin
            // 
            this.LblMin.BackColor = System.Drawing.Color.LightCyan;
            this.LblMin.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMin.ForeColor = System.Drawing.Color.Black;
            this.LblMin.Location = new System.Drawing.Point(334, 412);
            this.LblMin.Margin = new System.Windows.Forms.Padding(0);
            this.LblMin.Name = "LblMin";
            this.LblMin.Size = new System.Drawing.Size(76, 27);
            this.LblMin.TabIndex = 73;
            this.LblMin.Text = "0 мин\r\n";
            this.LblMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblQueue
            // 
            this.LblQueue.BackColor = System.Drawing.Color.LightCyan;
            this.LblQueue.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblQueue.ForeColor = System.Drawing.Color.Black;
            this.LblQueue.Location = new System.Drawing.Point(334, 379);
            this.LblQueue.Margin = new System.Windows.Forms.Padding(0);
            this.LblQueue.Name = "LblQueue";
            this.LblQueue.Size = new System.Drawing.Size(76, 27);
            this.LblQueue.TabIndex = 75;
            this.LblQueue.Text = "0 чел.";
            this.LblQueue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(74, 379);
            this.label10.Margin = new System.Windows.Forms.Padding(0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(266, 27);
            this.label10.TabIndex = 74;
            this.label10.Text = "Сейчас в очереди к врачу:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(460, 492);
            this.Controls.Add(this.LblQueue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LblMin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtnComplete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CmbDoctor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CmbRegisrtyPlace);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSignUp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "🧪 ГБУЗ Новозыбковская ЦРБ";
            this.Load += new System.EventHandler(this.FormSignUp_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormSignUp_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CmbRegisrtyPlace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbDoctor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RtbxFIO;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox Rtbx1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox Rtbx4;
        private System.Windows.Forms.RichTextBox Rtbx3;
        private System.Windows.Forms.RichTextBox Rtbx2;
        private System.Windows.Forms.Button BtnComplete;
        private System.Windows.Forms.Timer CheckCurrent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblMin;
        private System.Windows.Forms.Label LblQueue;
        private System.Windows.Forms.Label label10;
    }
}