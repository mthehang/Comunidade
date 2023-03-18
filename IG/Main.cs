using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Runtime.InteropServices;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;


namespace IG
{
    public partial class Main : Form
    {
        Funcionalidades func = new Funcionalidades();

        public Main()
        {
            InitializeComponent();
            openChildFormInPanel(new TelaInicio());
            this.WindowState = FormWindowState.Maximized;


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
            this.Size = new Size(1280, 720);
            this.WindowState = FormWindowState.Normal;
            this.CenterToScreen();

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            if (this.WindowState != FormWindowState.Maximized)
            {
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
            func.OnOF(btnClose, btnCloseF);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(btnCloseF, btnClose);
        }

        private void btnMinF_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(btnMin, btnMinF);
        }

        private void btnMin_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(btnMinF, btnMin);
        }

        private void btnMaxF_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(btnMax, btnMaxF);
        }

        private void btnMax_MouseLeave(object sender, EventArgs e)
        {
            if (btnResF.Visible == false)
            {
                func.OnOF(btnMaxF, btnMax);
            }
            else
            {
                btnMax.Visible = false;
                btnMaxF.Visible = false;
            }

        }

        private void btnResF_MouseEnter(object sender, EventArgs e)
        {

            func.OnOF(btnRes, btnResF);
        }

        private void btnRes_MouseLeave(object sender, EventArgs e)
        {
            if (btnMaxF.Visible == false)
            {
                func.OnOF(btnResF, btnRes);
            }
            else
            {
                btnRes.Visible = false;
                btnResF.Visible = false;
            }
        }

        private void btnCadastros_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgCadF, imgCad);
        }

        private void btnCadastros_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgCad, imgCadF);
        }

        private void btnCadastros_MouseUp(object sender, MouseEventArgs e)
        {
            imgCadF.BackColor = Color.FromArgb(253, 100, 116);

        }

        private void btnCadastros_MouseDown(object sender, MouseEventArgs e)
        {
            imgCadF.BackColor = Color.FromArgb(145, 119, 117);

        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgRelF, imgRel);
        }

        private void btnRelatorios_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgRel, imgRelF);
        }

        private void btnRelatorios_MouseDown(object sender, MouseEventArgs e)
        {
            imgRelF.BackColor = Color.FromArgb(145, 119, 117);

        }

        private void btnRelatorios_MouseUp(object sender, MouseEventArgs e)
        {
            imgRelF.BackColor = Color.FromArgb(165, 191, 146);

        }

        private void btnCheckIn_MouseDown(object sender, MouseEventArgs e)
        {
            imgCheckInF.BackColor = Color.FromArgb(145, 119, 117);
        }

        private void btnCheckIn_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgCheckInF, imgCheckIn);
        }

        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgCheckIn, imgCheckInF);
        }

        private void btnCheckIn_MouseUp(object sender, MouseEventArgs e)
        {
            imgCheckInF.BackColor = Color.FromArgb(161, 193, 191);
        }

        private void btnCheckOut_MouseDown(object sender, MouseEventArgs e)
        {
            imgCheckOutF.BackColor = Color.FromArgb(145, 119, 117);
        }

        private void btnHome_MouseDown(object sender, MouseEventArgs e)
        {
            imgHomeF.BackColor = Color.FromArgb(145, 119, 117);
        }

        private void btnHome_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgHomeF, imgHome);
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgHome, imgHomeF);
        }

        private void btnHome_MouseUp(object sender, MouseEventArgs e)
        {
            imgHomeF.BackColor = Color.FromArgb(93, 106, 137);
        }

        private void btnCheckOut_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgCheckOutF, imgCheckOut);
        }

        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {

            func.OnOF(imgCheckOut, imgCheckOutF);
        }

        private void btnCheckOut_MouseUp(object sender, MouseEventArgs e)
        {
            imgCheckOutF.BackColor = Color.FromArgb(201, 154, 122);
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            if (subMenuCad.Visible == false)
            {

                subMenuCad.Visible = true;
                subMenuCad.BringToFront();
                subMenuRel.Visible = false;
            }
            else
            {
                subMenuCad.Visible = false;
            }

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            if (subMenuRel.Visible == false)
            {
                subMenuRel.Visible = true;
                subMenuRel.BringToFront();
                subMenuCad.Visible = false;

            }
            else
            {
                subMenuRel.Visible = false;
            }
        }

        private void btnMenu_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(btnMenuF, btnMenu);
        }

        private void btnMenuF_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnMenuF_MouseLeave(object sender, EventArgs e)
        {

            func.OnOF(btnMenu, btnMenuF);
        }

        private void btnCrianca_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroC());
            HideAll();
            panelBack.Visible = true;
            Title.Text = "Cadastramento de Crianças";
            Title.Visible = true;
            panelBack.BringToFront();
        }

        private void HideAll()
        {
            if (MenuBar.Width == 220)
            {
                MenuBar.Width = 55;
                LogoComuna.Visible = false;
                btnHome.Visible = false;
                btnCadastros.Visible = false;
                btnRelatorios.Visible = false;
                btnCheckIn.Visible = false;
                btnCheckOut.Visible = false;
                subMenuCad.Visible = false;
                subMenuRel.Visible = false;
                btnMenu.Location = new Point(12, 6);
                btnMenuF.Location = new Point(12, 6);
            }
            else
            {
                MenuBar.Width = 220;
                LogoComuna.Visible = true;
                btnHome.Visible = true;
                btnCadastros.Visible = true;
                btnRelatorios.Visible = true;
                btnCheckIn.Visible = true;
                btnCheckOut.Visible = true;
                btnMenu.Location = new Point(12, 6);
                btnMenuF.Location = new Point(12, 6);
            }
        }

        private void ShowAll()
        {

            MenuBar.Width = 220;
            LogoComuna.Visible = true;
            panelHome.Visible = true;
            panelCad.Visible = true;
            panelRel.Visible = true;
            panelCheck.Visible = true;
            panelChackOut.Visible = true;
            imgHome.Visible = true;
            imgCad.Visible = true;
            imgRel.Visible = true;
            imgCheckIn.Visible = true;
            imgCheckOut.Visible = true;
            btnHome.Visible = true;
            btnCadastros.Visible = true;
            btnRelatorios.Visible = true;
            btnCheckIn.Visible = true;
            btnCheckOut.Visible = true;
            btnMenu.Location = new Point(12, 6);
            btnMenuF.Location = new Point(12, 6);

        }
        private void btnResponsavel_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroResp());
            HideAll();
            panelBack.Visible = true;
            Title.Text = "Cadastramento de Responsáveis";
            Title.Visible = true;
            panelBack.BringToFront();

        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnRelCad_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnRelCheck_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnRelFreq_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnRelVisitantes_Click(object sender, EventArgs e)
        {
            HideAll();
        }
        private Form activeForm = null!;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            Fundo.Visible = true;
            Fundo.Controls.Add(childForm);
            Fundo.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TelaInicio());
            panelBack.Visible = false;

        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(btnBackF, btnBack);
        }

        private void btnBackF_MouseLeave(object sender, EventArgs e)
        {

            func.OnOF(btnBack, btnBackF);
        }

        private void btnBackF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TelaInicio());
            panelBack.Visible = false;
        }

        private void btnCrianca_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgKidF, imgKid);
        }

        private void btnCrianca_MouseLeave(object sender, EventArgs e)
        {

            func.OnOF(imgKid, imgKidF);
        }

        private void btnResponsavel_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgRespF, imgResp);
        }

        private void btnResponsavel_MouseLeave(object sender, EventArgs e)
        {

            func.OnOF(imgResp, imgRespF);
        }

        private void imgHome_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgHomeF, imgHome);
                fundoHome.Visible = true;
            }
            else
            {
                func.OnOF(imgHomeF, imgHome);
                btnHome.BackColor = Color.FromArgb(93, 106, 137);
            }
        }

        private void imgHomeF_MouseLeave(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgHome, imgHomeF);
                fundoHome.Visible = false;
            }
            else
            {
                func.OnOF(imgHome, imgHomeF);
                btnHome.BackColor = Color.FromArgb(40, 31, 30);
            }
        }

        private void imgHomeF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TelaInicio());
            panelBack.Visible = false;
        }

        private void imgCad_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgCadF, imgCad);
                fundoCad.Visible = true;
                btnCadastros.BackColor = Color.FromArgb(253, 100, 116);
            }
            else
            {
                func.OnOF(imgCadF, imgCad);
                btnCadastros.BackColor = Color.FromArgb(253, 100, 116);
            }
        }

        private void imgCadF_MouseLeave(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgCad, imgCadF);
                fundoCad.Visible = false;
                btnCadastros.BackColor = Color.FromArgb(40, 31, 30);
            }
            else
            {
                func.OnOF(imgCad, imgCadF);
                fundoCad.Visible = false;
                btnCadastros.BackColor = Color.FromArgb(40, 31, 30);
            }
        }

        private void imgCadF_Click(object sender, EventArgs e)
        {
            fundoCad.Visible = false;
            ShowAll();
            if (subMenuCad.Visible == false)
            {
                subMenuCad.Visible = true;
                subMenuCad.BringToFront();
                subMenuRel.Visible = false;
            }
            else
            {
                subMenuCad.Visible = false;
            }
        }

        private void btnCrianca_MouseDown(object sender, MouseEventArgs e)
        {
            imgKidF.BackColor = Color.FromArgb(152, 140, 140);
        }

        private void btnCrianca_MouseUp(object sender, MouseEventArgs e)
        {
            imgKidF.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgKid_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgKidF, imgKid);
            btnCrianca.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgKidF_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgKid, imgKidF);
            btnCrianca.BackColor = Color.FromArgb(74, 64, 64);
        }

        private void imgKidF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroC());
            HideAll();
            panelBack.Visible = true;
            Title.Text = "Cadastramento de Crianças";
            Title.Visible = true;
            panelBack.BringToFront();

        }

        private void imgRel_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgRelF, imgRel);
                fundoRel.Visible = true;
                btnRelatorios.BackColor = Color.FromArgb(165, 191, 146);
            }
            else
            {
                func.OnOF(imgRelF, imgRel);
                btnRelatorios.BackColor = Color.FromArgb(165, 191, 146);
            }

        }

        private void imgRelF_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgRel, imgRelF);
            fundoRel.Visible = false;
            btnRelatorios.BackColor = Color.FromArgb(40, 31, 30);
        }

        private void imgRelF_Click(object sender, EventArgs e)
        {
            fundoRel.Visible = false;
            ShowAll();
            if (subMenuRel.Visible == false)
            {
                subMenuRel.Visible = true;
                subMenuRel.BringToFront();
                subMenuCad.Visible = false;

            }
            else
            {
                subMenuRel.Visible = false;
            }
        }

        private void imgCheckIn_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                func.OnOF(imgCheckInF, imgCheckIn);
                FundoCheckIn.Visible = true;
                btnCheckIn.BackColor = Color.FromArgb(161, 193, 191);
            }
            else
            {
                func.OnOF(imgCheckInF, imgCheckIn);
                btnCheckIn.BackColor = Color.FromArgb(161, 193, 191);
            }

        }

        private void imgCheckInF_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgCheckIn, imgCheckInF);
            FundoCheckIn.Visible = false;
            btnCheckIn.BackColor = Color.FromArgb(40, 31, 30);
        }

        private void imgCheckInF_Click(object sender, EventArgs e)
        {
            FundoCheckIn.Visible = false;
            ShowAll();
        }

        private void imgCheckOut_MouseEnter(object sender, EventArgs e)
        {
            FundoCheckOut.Visible = true;
            func.OnOF(imgCheckOutF, imgCheckOut);
            btnCheckOut.BackColor = Color.FromArgb(201, 154, 122);
        }

        private void imgCheckOutF_MouseLeave(object sender, EventArgs e)
        {
            FundoCheckOut.Visible = false;
            func.OnOF(imgCheckOut, imgCheckOutF);
            btnCheckOut.BackColor = Color.FromArgb(40, 31, 30);
        }

        private void imgCheckOutF_Click(object sender, EventArgs e)
        {
            FundoCheckOut.Visible = false;
            ShowAll();
        }

        private void imgResp_MouseEnter(object sender, EventArgs e)
        {
            func.OnOF(imgRespF, imgResp);
            btnResponsavel.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgRespF_MouseLeave(object sender, EventArgs e)
        {
            func.OnOF(imgResp, imgRespF);
            btnResponsavel.BackColor = Color.FromArgb(60, 53, 53);
        }

        private void btnResponsavel_MouseDown(object sender, MouseEventArgs e)
        {
            imgRespF.BackColor = Color.FromArgb(146, 135, 135);
        }

        private void btnResponsavel_MouseUp(object sender, MouseEventArgs e)
        {
            imgRespF.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgRespF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroResp());
            HideAll();
            panelBack.Visible = true;
            Title.Text = "Cadastramento de Responsáveis";
            Title.Visible = true;
            panelBack.BringToFront();
        }

        private void imgProfessorF_Click(object sender, EventArgs e)
        {
            HideAll();
        }
    }
}