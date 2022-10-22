using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IG
{

    public partial class CadastroC : Form
    {
        Criancas cr = new Criancas();
        DAO dao = new DAO();
        public CadastroC()
        {
            InitializeComponent();

            Calendario.Value = DateTime.Now;

        }


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                Calendario.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] args = { txtNome, txtEnd, txtSala, txtResponsavel };
            MaskedTextBox[] arg = { txtRg, txtCpf, txtCep };

            Funcionalidades.verificTxtC(args, arg, btnSalvar, txtNome, Calendario, txtRg, txtCpf, txtCep, txtEnd,
                txtSala, lblIdade, ListBox);



        }

        private void Calendario_ValueChanged(object sender, EventArgs e)
        {
            lblIdade.Text = Convert.ToString((DateTime.Now - Calendario.Value).Days / 30 / 12);
        }

        private void Calendario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtRg.Focus();
            }

        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
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


        private void txtRg_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtRgr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpf_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCpfr_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCep_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCepr_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtRg_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Focus();
            }
        }

        private void txtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCep.Focus();
            }
        }

        private void txtCep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEnd.Focus();
            }
        }

        private void txtEnd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSala.Focus();
            }
        }

        private void txtCelr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void txtSala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Focus();
            }
        }

        private void btnSearchF_Click(object sender, EventArgs e)
        {
            if (txtResponsavel.Text != "")
            {
                dao.ListBox(ListBox, txtResponsavel.Text.ToUpper());
            }

        }
        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr.Resp = ListBox.GetItemText(ListBox.SelectedItem);
            cr.Resp = cr.Resp.Split(' ').FirstOrDefault()!;
            //dao.Relacao(cr.Resp);
            MessageBox.Show(cr.Resp);
            ListBox.Visible = false;
            
            
        }

        private void btnCriar_MouseEnter(object sender, EventArgs e)
        {
            btnCriar.Visible = false;
            btnCriarF.Visible = true;
        }

        private void btnCriarF_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.Visible = true;
            btnCriarF.Visible = false;
        }

        private void btnCriarF_Click(object sender, EventArgs e)
        {
            CadastroCResp ccr = new CadastroCResp();
            ccr.Show();
        }

        private void lblCriar_Click(object sender, EventArgs e)
        {
            CadastroCResp ccr = new CadastroCResp();
            ccr.Show();
        }

        private void lblCriar_MouseEnter(object sender, EventArgs e)
        {
            btnCriar.Visible = false;
            btnCriarF.Visible = true;
        }

        private void lblCriar_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.Visible = true;
            btnCriarF.Visible = false;
        }

        private void panelbtnCriar_MouseEnter(object sender, EventArgs e)
        {
            btnCriar.Visible = false;
            btnCriarF.Visible = true;
        }

        private void panelbtnCriar_Click(object sender, EventArgs e)
        {
            CadastroCResp ccr = new CadastroCResp();
            ccr.Show();
        }

        private void panelbtnCriar_MouseLeave(object sender, EventArgs e)
        {
            btnCriar.Visible = true;
            btnCriarF.Visible = false;
        }

        private void txtResponsavel_TextChanged_1(object sender, EventArgs e)
        {
            if (txtResponsavel.Text != "")
            {

                dao.ListBox(ListBox, txtResponsavel.Text.ToUpper());
            }
            else
            {
                ListBox.Visible = false;
            }
        }
    }
}
