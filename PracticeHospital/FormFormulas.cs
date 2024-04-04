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
using System.Windows.Forms.DataVisualization.Charting;

namespace PracticeHospital
{
    public partial class FormFormulas : Form
    {
        public FormFormulas()
        {
            InitializeComponent();
        }

        double  m = 4, t=5;
        double KefZagruzki, Intensivnost, VerOtkaz, IntensivnostObsluz, SrednTimeOzid, SrednZayavok, Count=0;
        List<int> LstOldRows = new List<int>();
        private void FormFormulas_Shown(object sender, EventArgs e)
        {
            DateTime Dt = DateTime.Now;
            string Fdt = Dt.ToString("yyyy/MM/dd HH");

            SqlConnection Con = new SqlConnection(Form1.TxtCon);
            SqlCommand Cmd = new SqlCommand("select * from Request", Con);
            Con.Open();
            SqlDataReader Res = Cmd.ExecuteReader();
            while (Res.Read())
            {
                // Просчет интенсивности заявок за прошедший час и приведение их к формуле
                string DtFromBase = DateTime.Parse(Res["TimeRequest"].ToString()).ToString("yyyy/MM/dd HH");
                if (Fdt.Split(' ')[0] == DtFromBase.Split(' ')[0] && int.Parse(Fdt.Split(' ')[1])  == int.Parse(DtFromBase.Split(' ')[1]))
                    LstOldRows.Add(1);
            }
            Con.Close();

            SqlCommand Cmd1 = new SqlCommand("select * from Request where State='New'", Con);
            Con.Open();
            SqlDataReader Res1 = Cmd1.ExecuteReader();
            while (Res1.Read())
            {
                Count++;
            }

            Con.Close();
            DateTime DtEndDay = DateTime.Parse(Dt.ToString("yyyy-MM-dd 18:00")); // Время 18:00 на текущий день

            // Вычисляем разницу между 18:00 и текущим временем
            TimeSpan difference = DtEndDay - DateTime.Parse(Dt.ToString("yyy/MM/dd HH:mm"));
            double EndOfDay = difference.Hours;

            Intensivnost = LstOldRows.Count;
            LblIntensivnost.Text = Intensivnost.ToString() + " чел/ч";

            IntensivnostObsluz = 1 / t;
            LblIntensObluz.Text = IntensivnostObsluz.ToString() +" чел/м";

            // Просчет коэффициента загрузки всех врачей за час, если показатель = 1, тогда все перегружены
            // Для демонстации изменить 60 на 5(мин) и необходимо, чтобы кол-во пациентов было >=4 
            KefZagruzki = Intensivnost / (m*IntensivnostObsluz)/60;
            if (KefZagruzki.ToString().Length>5)
                LblKefZagr.Text = KefZagruzki.ToString().Substring(0,5);
            else LblKefZagr.Text = KefZagruzki.ToString();


            //SrednZayavok = Intensivnost * IntensivnostObsluz;
            SrednZayavok = (Intensivnost * Intensivnost) / m * (IntensivnostObsluz * (m * KefZagruzki));
            if (SrednZayavok.ToString().Length > 5)
                LblSrednZayavok.Text = SrednZayavok.ToString().Substring(0, 5);
            else LblSrednZayavok.Text = SrednZayavok.ToString();


            if((SrednZayavok / Intensivnost).ToString().Length>5)
                LblTimeOzid.Text = (SrednZayavok / Intensivnost).ToString().Substring(0,5) + " мин";
            else LblTimeOzid.Text = (SrednZayavok / Intensivnost).ToString() + " мин";

            if (KefZagruzki >= 1)
                LblNote2.Text = "Все доступные врачи на текущий час заняты, пожалуйста, примите меры!";
            if ((SrednZayavok / Intensivnost) > 5)
                LblNote.Text = "Время на ожидание превышает обслуживаемое!";

            // Для демонстрации
            //if (1== 1)
            //    LblNote2.Text = "Все доступные врачи на текущий час заняты, примите меры!";
            //if (5== 5)
            //    LblNote.Text = "Время на ожидание превышает обслуживаемое!";
        }
        static double Factorial(double n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
}
