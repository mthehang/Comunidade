using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using System.Runtime.InteropServices;
using static Org.BouncyCastle.Bcpg.Attr.ImageAttrib;


namespace IG
{
    public partial class Janela1 : Form
    {
        public Janela1()
        {
            InitializeComponent();
            HideAll();
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
            imgCadF.BackColor = Color.FromArgb(253, 100, 116);
            
        }

        private void btnCadastros_MouseDown(object sender, MouseEventArgs e)
        {
            imgCadF.BackColor = Color.FromArgb(145, 119, 117);
            
        }

        private void btnRelatorios_MouseEnter(object sender, EventArgs e)
        {
            imgRel.Visible = false;
            imgRelF.Visible = true;
        }

        private void btnRelatorios_MouseLeave(object sender, EventArgs e)
        {
            imgRel.Visible = true;
            imgRelF.Visible = false;
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
            imgCheckIn.Visible = false;
            imgCheckInF.Visible = true;
        }

        private void btnCheckIn_MouseLeave(object sender, EventArgs e)
        {
            imgCheckIn.Visible = true;
            imgCheckInF.Visible = false;
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
            imgHome.Visible = false;
            imgHomeF.Visible = true;
        }

        private void btnHome_MouseLeave(object sender, EventArgs e)
        {
            
            imgHome.Visible = true;
            imgHomeF.Visible = false;
        }

        private void btnHome_MouseUp(object sender, MouseEventArgs e)
        {
            imgHomeF.BackColor = Color.FromArgb(93, 106, 137);
        }

        private void btnCheckOut_MouseEnter(object sender, EventArgs e)
        {
            imgCheckOut.Visible = false;
            imgCheckOutF.Visible = true;
        }

        private void btnCheckOut_MouseLeave(object sender, EventArgs e)
        {
            imgCheckOut.Visible = true;
            imgCheckOutF.Visible = false;
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
            btnMenu.Visible = false;
            btnMenuF.Visible = true;
        }

        private void btnMenuF_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnMenuF_MouseLeave(object sender, EventArgs e)
        {
            btnMenu.Visible = true;
            btnMenuF.Visible = false;
        }

        private void btnCrianca_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroC());
            HideAll();
            panelBack.Visible = true;
            panelBack.BringToFront();
        }

        private void HideAll() {
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

        private void ShowAll() {
            
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
            HideAll();
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
            
        }

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            btnBackF.Visible = true;
        }

        private void btnBackF_MouseLeave(object sender, EventArgs e)
        {
            btnBack.Visible = true;
            btnBackF.Visible = false;
        }

        private void btnBackF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TelaInicio());
            btnBack.Visible = false;
        }

        private void btnCrianca_MouseEnter(object sender, EventArgs e)
        {
            imgKid.Visible = false;
            imgKidF.Visible = true;
        }

        private void btnCrianca_MouseLeave(object sender, EventArgs e)
        {
            imgKid.Visible = true; 
            imgKidF.Visible = false;
        }

        private void btnResponsavel_MouseEnter(object sender, EventArgs e)
        {
            imgResp.Visible = false;
            imgRespF.Visible = true;
        }

        private void btnResponsavel_MouseLeave(object sender, EventArgs e)
        {
            imgResp.Visible = true;
            imgRespF.Visible = false;
        }

        private void btnProfessor_MouseEnter(object sender, EventArgs e)
        {
            imgProfessor.Visible = false;
            imgProfessorF.Visible = true;
        }

        private void btnProfessor_MouseLeave(object sender, EventArgs e)
        {
            imgProfessor.Visible = true;
            imgProfessorF.Visible = false;
        }

        private void imgHome_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                imgHomeF.Visible = true;
                imgHome.Visible = false;
                fundoHome.Visible = true;
            }
            else
            {
                imgHomeF.Visible = true;
                imgHome.Visible = false;
                btnHome.BackColor = Color.FromArgb(93, 106, 137);
            }
        }

        private void imgHomeF_MouseLeave(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                imgHomeF.Visible = false;
                imgHome.Visible = true;
                fundoHome.Visible = false;
            }
            else
            {
                imgHomeF.Visible = false;
                imgHome.Visible = true;
                btnHome.BackColor = Color.FromArgb(40, 31, 30);
            }
        }

        private void imgHomeF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new TelaInicio());
        }

        private void imgCad_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                imgCadF.Visible = true;
                imgCad.Visible = false;
                fundoCad.Visible = true;
                btnCadastros.BackColor = Color.FromArgb(253, 100, 116);
            }
            else
            {
                imgCadF.Visible = true;
                imgCad.Visible = false;
                btnCadastros.BackColor = Color.FromArgb(253, 100, 116);
            }
        }

        private void imgCadF_MouseLeave(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                imgCadF.Visible = false;
                imgCad.Visible = true;
                fundoCad.Visible = false;
                btnCadastros.BackColor = Color.FromArgb(40, 31, 30);
            }
            else
            {
                imgCadF.Visible = false;
                imgCad.Visible = true;
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
            imgKid.Visible = false;
            imgKidF.Visible = true;
            btnCrianca.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgKidF_MouseLeave(object sender, EventArgs e)
        {
            imgKid.Visible = true;
            imgKidF.Visible = false;
            btnCrianca.BackColor = Color.FromArgb(74, 64, 64);
        }

        private void imgKidF_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CadastroC());
            HideAll();
            panelBack.Visible = true;
            panelBack.BringToFront();
        }

        private void imgRel_MouseEnter(object sender, EventArgs e)
        {
            if (MenuBar.Width == 55)
            {
                imgRelF.Visible = true;
                imgRel.Visible = false;
                fundoRel.Visible = true;
                btnRelatorios.BackColor = Color.FromArgb(165, 191, 146);
            }
            else
            {
                imgRelF.Visible = true;
                imgRel.Visible = false;
                btnRelatorios.BackColor = Color.FromArgb(165, 191, 146);
            }
            
        }

        private void imgRelF_MouseLeave(object sender, EventArgs e)
        {
                imgRelF.Visible = false;
                imgRel.Visible = true;
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
                imgCheckIn.Visible = false;
                imgCheckInF.Visible = true;
                FundoCheckIn.Visible = true;
                btnCheckIn.BackColor = Color.FromArgb(161, 193, 191);
            }
            else {
                imgCheckIn.Visible = false;
                imgCheckInF.Visible = true;
                btnCheckIn.BackColor = Color.FromArgb(161, 193, 191);
            }
            
        }

        private void imgCheckInF_MouseLeave(object sender, EventArgs e)
        {
            imgCheckIn.Visible = true;
            imgCheckInF.Visible = false;
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
            imgCheckOut.Visible = false;
            imgCheckOutF.Visible = true;
            btnCheckOut.BackColor = Color.FromArgb(201, 154, 122);
        }

        private void imgCheckOutF_MouseLeave(object sender, EventArgs e)
        {
            FundoCheckOut.Visible = false;
            imgCheckOut.Visible = true;
            imgCheckOutF.Visible = false;
            btnCheckOut.BackColor = Color.FromArgb(40, 31, 30);
        }

        private void imgCheckOutF_Click(object sender, EventArgs e)
        {
            FundoCheckOut.Visible = false;
            ShowAll();
        }

        private void imgResp_MouseEnter(object sender, EventArgs e)
        {
            imgResp.Visible = false;
            imgRespF.Visible = true;
            btnResponsavel.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgRespF_MouseLeave(object sender, EventArgs e)
        {
            imgResp.Visible = true;
            imgRespF.Visible = false;
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
            HideAll();
        }

        private void imgProfessor_MouseEnter(object sender, EventArgs e)
        {
            imgProfessor.Visible = false;
            imgProfessorF.Visible = true;
            btnProfessor.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgProfessorF_MouseLeave(object sender, EventArgs e)
        {
            imgProfessor.Visible = true;
            imgProfessorF.Visible = false;
            btnProfessor.BackColor = Color.FromArgb(74, 64, 64);
        }

        private void imgProfessorF_Click(object sender, EventArgs e)
        {
            HideAll();
        }

        private void btnProfessor_MouseDown(object sender, MouseEventArgs e)
        {
            imgProfessorF.BackColor = Color.FromArgb(152, 140, 140);
        }

        private void btnProfessor_MouseUp(object sender, MouseEventArgs e)
        {
            imgProfessorF.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void btnSala_MouseEnter(object sender, EventArgs e)
        {
            imgSala.Visible = false;
            imgSalaF.Visible = true;
        }

        private void btnSala_MouseLeave(object sender, EventArgs e)
        {
            imgSala.Visible = true;
            imgSalaF.Visible = false;
        }

        private void imgSala_MouseEnter(object sender, EventArgs e)
        {
            imgSala.Visible = false;
            imgSalaF.Visible = true;
            btnSala.BackColor = Color.FromArgb(253, 100, 116);
        }

        private void imgSalaF_MouseLeave(object sender, EventArgs e)
        {
            imgSala.Visible = true;
            imgSalaF.Visible = false;
            btnSala.BackColor = Color.FromArgb(60, 53, 53);
        }

        private void btnSala_MouseDown(object sender, MouseEventArgs e)
        {
            imgSalaF.BackColor = Color.FromArgb(152, 140, 140);
        }

        private void btnSala_MouseUp(object sender, MouseEventArgs e)
        {
            imgSalaF.BackColor = Color.FromArgb(253, 100, 116);
        }
    }
}