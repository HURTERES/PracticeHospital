using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHospital
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string TxtCon = @"Data Source=213.155.192.79,3002;Initial Catalog=PracticeHospital;Persist Security Info=True;User ID=u21obolen;Password=s8kd";

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'practiceHospitalDataSet1.Request' table. You can move, or remove it, as needed.
            this.requestTableAdapter.Fill(this.practiceHospitalDataSet1.Request);
            // TODO: This line of code loads data into the 'DSRequest.Request' table. You can move, or remove it, as needed.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BtnEnter.Text == "Записаться на прием")
            {
                FormSignUp Frm = new FormSignUp();
                Frm.ShowDialog();
                this.requestTableAdapter.Fill(this.practiceHospitalDataSet1.Request);
            }
            else
            {
                Btnefficiency.Visible = false;
                DgvPatients.Visible = true;
            }
              
        }
        public static int Key = 0;
        private void label4_Click(object sender, EventArgs e)
        {
            if (Key==0 && DgvPatients.Visible != true)
            {
                FormCheckLog Frm = new FormCheckLog();
                Frm.ShowDialog();
                if (Key == 1)
                {
                    Btnefficiency.Visible = true;
                    BtnEnter.Text = "Просмотр записей";
                    Key = 0;
                }

            }
            else
            {
                DgvPatients.Visible = false;
                Btnefficiency.Visible = false;
                BtnEnter.Text = "Записаться на прием";
            }
        }

        private void Btnefficiency_Click(object sender, EventArgs e)
        {
            FormFormulas Frm = new FormFormulas();
            Frm.ShowDialog();
        }
    }
}
