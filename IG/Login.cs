using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IG
{
    public partial class Login : Form
    {
        Funcionalidades func = new Funcionalidades();
        public Login()
        {

            InitializeComponent();
        }

        private void SetBackColorDegrade(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Rectangle gradient_rect = new Rectangle(0, 0, Width, Height);
            Brush br = new LinearGradientBrush(gradient_rect, Color.FromArgb(11, 59, 120), Color.FromArgb(15, 110, 90), 90f);
            graphics.FillRectangle(br, gradient_rect);
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            SetBackColorDegrade(sender, e);
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(btnEntrarb, btnEntrar);
        }

        private void btnEntrarb_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(btnEntrar, btnEntrarb);
        }

        private void pictureBox2_MouseEnter_1(object sender, EventArgs e)
        {
            func.OnOF(btnFechar2, btnFechar1);
        }

        private void btnFechar2_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(btnFechar1, btnFechar2);
        }

        private void btnFechar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrarb_Click(object sender, EventArgs e)
        {
            Entrar();

        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }

        private void Entrar()
        {
            Main main = new Main();
            this.Hide();
            this.Controls.Clear();
            main.Show();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Entrar();
            }
        }
    }
}
