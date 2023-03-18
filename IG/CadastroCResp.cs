using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IG
{
    public partial class CadastroCResp : Form
    {
        CadastroC cc = new CadastroC();
        public CadastroCResp(CadastroC cc)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.TopMost = true;
            this.cc = cc;
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseF_MouseEnter(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnClose, btnCloseF);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnCloseF, btnClose);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCepr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtCepr.MaskCompleted == false)
                {
                    txtEndr.Text = "";
                    txtEnd2.Visible = false;
                    MessageBox.Show("CEP inválido.");
                }
                else
                {
                    Funcionalidades func = new Funcionalidades();
                    func.BuscarCep(txtCepr, txtEndr, txtEnd2, txtBairro);
                    txtNumero.Focus();
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TextBox[] args = { txtNomer, txtEndr, txtNumero, txtBairro };
            MaskedTextBox[] arg = { txtRgr, txtCpfr, txtCepr, txtCelr };

            Funcionalidades.verificTxtR(args, arg, txtNomer, Calendarior, txtRgr, txtCpfr, txtCepr, txtEndr,
                lblIdader, txtEnd2, txtNumero, txtComplemento, txtBairro, txtCelr, this, ganb, lblOb);

            if (!ganb.Text.Equals("."))
            {
                Responsaveis resp = new Responsaveis();
                cc.txtResponsavel.Text = ganb.Text;
                cc.txtResponsavel.Refresh();
            }

        }

        private void txtCepr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRgr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpfr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCelr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarF_Click(object sender, EventArgs e)
        {
            if (txtCepr.MaskCompleted == false)
            {
                txtEndr.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                func.BuscarCep(txtCepr, txtEndr, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void labelend_Click(object sender, EventArgs e)
        {
            if (txtCepr.MaskCompleted == false)
            {
                txtEndr.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                func.BuscarCep(txtCepr, txtEndr, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void panelBtnBuscar_Click(object sender, EventArgs e)
        {
            if (txtCepr.MaskCompleted == false)
            {
                txtEndr.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                func.BuscarCep(txtCepr, txtEndr, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void txtNomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbSupervisao.Focus();
            }
        }

        private void txtCelr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calendarior.Focus();
            }
        }

        private void Calendarior_ValueChanged(object sender, EventArgs e)
        {
            lblIdader.Text = Convert.ToString((DateTime.Now - Calendarior.Value).Days / 30 / 12);
        }

        private void txtRgr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpfr.Focus();
            }
        }

        private void txtCpfr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCepr.Focus();
            }
        }

        private void txtNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtComplemento.Focus();
            }
        }

        private void txtComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtBairro.Focus();
            }
        }

        private void txtBairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void Calendarior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRgr.Focus();
            }
        }

        private void CadastroCResp_Load(object sender, EventArgs e)
        {
            string maior = (int.Parse(DateTime.Today.ToString("yyyyMMdd").Substring(0, 4)) - 18).ToString() + (DateTime.Today.ToString("yyyyMMdd")).Substring(4, 4);
            var cultureInfo = new CultureInfo("en-US");
            lblIdader.Text = 18.ToString();

            Calendarior.Value = DateTime.ParseExact(maior, "yyyyMMdd", cultureInfo);
        }

        private void cbSupervisao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCelr.Focus();
            }
        }
    }
}
