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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PracticeHospital
{
    public partial class FormSignUp : Form
    {
        public FormSignUp()
        {
            InitializeComponent();
        }

        private void CmbRegisrtyPlace_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void FormSignUp_MouseMove(object sender, MouseEventArgs e)
        {
            this.ActiveControl = null;
        }

        List<string> LstDoctors= new List<string>();
        private void FormSignUp_Load(object sender, EventArgs e)
        {
            CheckCurrent.Start();

            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("yyyy-MM-dd HH:mm"));

            using (SqlConnection Con = new SqlConnection(Form1.TxtCon))
            {
                SqlCommand Cmd = new SqlCommand("SELECT * FROM Request", Con);
                Con.Open();

                using (SqlDataReader Res = Cmd.ExecuteReader())
                {
                    while (Res.Read())
                    {
                        if (Fdt < DateTime.Parse(Res["TimeRequest"].ToString()))
                        {
                            LstDoctors.Add($"{Res["TimeRequest"]}&{Res["Doctor"]}");
                        }
                        else
                        {
                            int requestId = int.Parse(Res["IdRequest"].ToString());
                            using (SqlConnection ConTwo = new SqlConnection(Form1.TxtCon))
                            {
                                SqlCommand command = new SqlCommand($"DELETE FROM Request WHERE IdRequest = {requestId}", ConTwo);
                                ConTwo.Open();
                                command.ExecuteNonQuery();
                                ConTwo.Close();
                            }
                        }
                    }
                }
                Con.Close();
            }
        }

        private void RtbxLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if(RtbxFIO.Text == "Введите ФИО")
            RtbxFIO.SelectionStart = 0;
        }

        private void RtbxFIO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RtbxFIO.Text == "Введите ФИО")
                RtbxFIO.Text = "";
        }

        private void RtbxFIO_MouseLeave(object sender, EventArgs e)
        {
            if (RtbxFIO.Text == "")
                RtbxFIO.Text = "Введите ФИО";
        }

        private void BtnComplete_Click(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            DateTime Fdt = DateTime.Parse(Dt.ToString("dd/MM/yyyy HH:mm:ss"));
            Fdt = Fdt.AddMinutes(5);

            using (SqlConnection Con = new SqlConnection(Form1.TxtCon))
            {
                string CurrentSNILS = $"{Rtbx1.Text}-{Rtbx2.Text}-{Rtbx3.Text} {Rtbx4.Text}";
                string query = "INSERT INTO Request (TimeRequest, Region, FIO, SNILS, Doctor) VALUES (@Fdt, @Region, @FIO, @SNILS, @Doctor)";

                using (SqlCommand Cmd = new SqlCommand(query, Con))
                {
                    Cmd.Parameters.AddWithValue("@Fdt", Fdt);
                    Cmd.Parameters.AddWithValue("@Region", CmbRegisrtyPlace.Text);
                    Cmd.Parameters.AddWithValue("@FIO", RtbxFIO.Text);
                    Cmd.Parameters.AddWithValue("@SNILS", CurrentSNILS);
                    Cmd.Parameters.AddWithValue("@Doctor", CmbDoctor.Text);

                    Con.Open();
                    Cmd.ExecuteNonQuery();
                }
            }
                MessageBox.Show("Пожалуйста, проходите к кабинету", "Будьте здоровы!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
        }

        private void CheckCurrent_Tick(object sender, EventArgs e)
        {
            if(CmbRegisrtyPlace.Text!="" && RtbxFIO.Text!="Введите ФИО"
                && Rtbx1.Text!="" && Rtbx2.Text != "" && Rtbx3.Text != "" && Rtbx4.Text != "" && CmbDoctor.Text!="")
                BtnComplete.Enabled = true;
            else BtnComplete.Enabled = false;
        }

        private void CmbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Count = 0;
            for (int i = 0; i < LstDoctors.Count; i++)
                if (LstDoctors[i].Split('&')[1] == CmbDoctor.Text)
                    Count++;
            LblMin.Text = Count*5+" мин";
            LblQueue.Text = Count + " чел.";

            DateTime Dt = DateTime.Now;
            DateTime DtEndDay= DateTime.Parse(Dt.ToString("yyyy-MM-dd 18:00"));
            DateTime Fdt = DateTime.Parse(Dt.ToString("yyyy-MM-dd HH:mm"));
            Fdt=Fdt.AddMinutes(Count*5);
            if (Fdt >= DtEndDay && CmbDoctor.SelectedIndex!=-1)
            {
                MessageBox.Show("Конец рабочего дня, запись невозможна");
                CmbDoctor.SelectedIndex = -1;
            }
        }

        private void Rtbx1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || Rtbx1.Text.Length>2)
                e.Handled = true;
            if (Rtbx1.Text.Length == 2 && e.KeyChar!='\b' && char.IsDigit(e.KeyChar))
                Rtbx2.Focus();
        }

        private void Rtbx2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || Rtbx2.Text.Length >2)
                e.Handled = true;
            if (Rtbx2.Text.Length == 2 && e.KeyChar != '\b' && char.IsDigit(e.KeyChar))
                Rtbx3.Focus();
            if (Rtbx2.Text.Length == 0 && e.KeyChar == '\b')
                Rtbx1.Focus();
        }

        private void Rtbx3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || Rtbx3.Text.Length >2)
                e.Handled = true;
            if (Rtbx3.Text.Length == 2 && e.KeyChar != '\b' && char.IsDigit(e.KeyChar))
                Rtbx4.Focus();
            if (Rtbx3.Text.Length == 0 && e.KeyChar == '\b')
                Rtbx2.Focus();
        }

        private void Rtbx4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' || Rtbx4.Text.Length >1)
                e.Handled = true;
            if (Rtbx4.Text.Length == 0 && e.KeyChar == '\b')
                Rtbx3.Focus();
        }
    }
}
