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
        Responsaveis resp = new Responsaveis();
        DAO dao = new DAO();
        Funcionalidades funcionalidades = new Funcionalidades();
        private Form activeForm = null!;
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
                txtSala, lblIdade, ListView, resp.Id);

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

        private void txtRg_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtCep_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void txtSala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtResponsavel.Focus();
            }
        }

        private void txtRg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Focus();
            }
        
        }

        private void btnCriar_MouseEnter(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriarF, btnCriar);
        }

        private void btnCriarF_MouseLeave(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriar, btnCriarF);
        }

        private void btnCriarF_Click(object sender, EventArgs e)
        {
            
            if (activeForm != null)
                activeForm.Close();

            activeForm = new CadastroCResp();
            activeForm.Show();

        }

        private void lblCriar_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();

            activeForm = new CadastroCResp();
            activeForm.Show();

        }

        private void lblCriar_MouseEnter(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriarF, btnCriar);
        }

        private void lblCriar_MouseLeave(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriar, btnCriarF);
        }

        private void panelbtnCriar_MouseEnter(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriarF, btnCriar);
        }

        private void panelbtnCriar_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = new CadastroCResp();
            activeForm.Show();
        }

        private void panelbtnCriar_MouseLeave(object sender, EventArgs e)
        {
            funcionalidades.OnOF(btnCriar, btnCriarF);
        }

        private void txtResponsavel_TextChanged_1(object sender, EventArgs e)
        {
            if (txtResponsavel.Text != "")
            {

                dao.ListView(ListView, txtResponsavel.Text.ToUpper());
            }
            else
            {
                ListView.Visible = false;
            }
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            resp.Id = short.Parse(ListView.SelectedItems[0].SubItems[0].Text);
            txtResponsavel.Text = ListView.SelectedItems[0].SubItems[1].Text;
            ListView.Visible = false;
        }

        private void Fundo_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.Visible = false;
            Fundo.Focus();
        }
    }
}
