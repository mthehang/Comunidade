using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Runtime.InteropServices;


namespace IG
{
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Janela1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            btnMax.Visible = false;
            btnMaxF.Visible = false;
            btnResF.Visible = true;
            this.WindowState = FormWindowState.Maximized;
            
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            btnMaxF.Visible = true;
            btnRes.Visible = false;
            btnResF.Visible = false;
            this.WindowState = FormWindowState.Normal;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState != FormWindowState.Maximized) {
                btnMaxF.Visible = true;
                btnMax.Visible = false;
                btnRes.Visible = false;
                btnResF.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseF_MouseEnter(object sender, EventArgs e)
        {
            btnClose.Visible = true;

            btnCloseF.Visible = false;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.Visible = false;

            btnCloseF.Visible = true;
        }

        private void btnMinF_MouseEnter(object sender, EventArgs e)
        {
            btnMin.Visible = true;
            btnMinF.Visible = false;
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            btnMin.Visible = false;
            btnMinF.Visible = true;
        }

        private void btnMaxF_MouseEnter(object sender, EventArgs e)
        {
            btnMax.Visible = true;
            btnMaxF.Visible = false;
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            if (btnResF.Visible == false)
            {
                btnMax.Visible = false;
                btnMaxF.Visible = true;
            }
            else 
            {
                btnMax.Visible = false;
                btnMaxF.Visible = false;
            }
            
        }

        private void btnResF_MouseEnter(object sender, EventArgs e)
        {
            btnRes.Visible = true;

            btnResF.Visible = false;
        }

        private void btnRes_MouseLeave(object sender, EventArgs e)
        {
            if (btnMaxF.Visible == false)
            {
                btnRes.Visible = false;
                btnResF.Visible = true;
            }
            else {
                btnRes.Visible = false;
                btnResF.Visible = false;
            }
        }

        private void btnCadastros_MouseEnter(object sender, EventArgs e)
        {
            imgCad.Visible = false;
            imgCadF.Visible = true;
        }

        private void btnCadastros_MouseLeave(object sender, EventArgs e)
        {
            imgCad.Visible = true;
            imgCadF.Visible = false;
        }

        private void btnCadastros_MouseUp(object sender, MouseEventArgs e)
        {
            imgCadF.BackColor = Color.FromArgb(236, 47, 67);
        }

        private void btnCadastros_MouseDown(object sender, MouseEventArgs e)
        {
            imgCadF.BackColor = Color.FromArgb(145, 119, 117);
        }
    }
}