using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeHospital
{
    public partial class FormCheckLog : Form
    {
        public FormCheckLog()
        {
            InitializeComponent();
        }

        private Point _dragStartPoint;

        private void PanelDrag_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStartPoint = new Point(e.X, e.Y);
            }
        }

        private void RtbxLogin_Leave(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "")
                RtbxLogin.Text = "Введите логин";

        }

        private void RtbxLogin_Enter(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "Введите логин")
                RtbxLogin.Text = "";

        }

        private void RtbxPass_Leave(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "")
                RtbxPass.Text = "Введите пароль";

        }

        private void RtbxPass_Enter(object sender, EventArgs e)
        {
            if (RtbxPass.Text == "Введите пароль")
                RtbxPass.Text = "";

        }

        private void FormCheckLog_Shown(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void PanelDrag_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStartPoint = Point.Empty;
            }
        }

        private void PanelDrag_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(-_dragStartPoint.X, -_dragStartPoint.Y);
                this.Location = newPoint;
            }
        }

        private void RtbxLogin_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void RtbxPass_MouseLeave(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (RtbxLogin.Text == "a" && RtbxPass.Text == "a")
            {
                Form1.Key = 1;
                MessageBox.Show("Права админа активированы");
                this.Close();
            }
            else { };
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
