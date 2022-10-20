using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            Calendarior.Value = DateTime.Now;

        }


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {
                Calendario.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] args = { txtNome, txtEnd, txtSala, txtNomer, txtEndr, txtParentesco};
            MaskedTextBox[] arg = { txtRg, txtCpf, txtCep, txtRgr, txtCpfr, txtCepr, txtCelr};

            Funcionalidades.verificTxt(args, arg, btnSave, txtNome, txtNomer, Calendario, Calendarior, txtRg, txtRgr, txtCpf, txtCpfr, txtCep, txtCepr, txtEnd,
                txtEndr, txtSala, txtParentesco, lblIdade, lblIdader, txtCelr);



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

        private void txtCpfr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCepr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Calendarior_ValueChanged(object sender, EventArgs e)
        {
            {
                lblIdader.Text = Convert.ToString((DateTime.Now - Calendarior.Value).Days / 30 / 12);
            }
        }

        private void Calendarior_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtRgr.Focus();
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

        private void txtRgr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpfr.Focus();
            }
        }

        private void txtNomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Calendarior.Focus();
            }
        }

        private void txtCpfr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCepr.Focus();
            }
        }

        private void txtCepr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEndr.Focus();
            }
        }

        private void txtEndr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtParentesco.Focus();
            }
        }

        private void txtParentesco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCelr.Focus();
            }
        }

        private void txtCelr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSave.Focus();
            }
        }

        private void txtSala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomer.Focus();
            }
        }

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Focus();
            }
        }

        private void btnSearchF_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.Visible = true;
            btnSearchF.Visible = false;
        }

        private void btnSearch_MouseEnter(object sender, EventArgs e)
        {
            btnSearch.Visible = false;
            btnSearchF.Visible = true;
        }

        private void btnSearchF_Click(object sender, EventArgs e)
        {
            dao.ListBox(ListBox, txtResponsavel.Text);
        }

        private void txtResponsavel_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void txtResponsavel_TextChanged(object sender, EventArgs e)
        {

            if (txtResponsavel.Text == "")
            {
                ListBox.Visible = false;
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cr.Resp = ListBox.GetItemText(ListBox.SelectedItem);
            
            
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
    }
}
