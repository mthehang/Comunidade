using Newtonsoft.Json.Linq;
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
            Calendario.MaxDate = DateTime.Now;

        }


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                Calendario.Focus();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TextBox[] args = { txtParentesco, txtName, txtEnd, txtSala, txtResponsavel, txtNumero, txtNumero, txtBairro, txtComplemento };

            Funcionalidades.verificTxtC(args, txtName, Calendario, txtCep, txtEnd,
                txtSala, lblIdade, ListView, resp.Id, txtEnd2, txtNumero, txtComplemento, txtBairro, btnEspecial, txtCuidados, txtParentesco);

        }

        private void Calendario_ValueChanged(object sender, EventArgs e)
        {
            lblIdade.Text = Convert.ToString((DateTime.Now - Calendario.Value).Days / 30 / 12);
        }

        private void Calendario_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtCep.Focus();
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
                if (txtCep.MaskCompleted == false)
                {
                    txtEnd.Text = "";
                    txtEnd2.Visible = false;
                    MessageBox.Show("CEP inválido.");
                }
                else
                {
                    Funcionalidades func = new Funcionalidades();
                    _ = func.BuscarCep(txtCep, txtEnd, txtEnd2, txtBairro);
                    txtNumero.Focus();
                }
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

            activeForm = new CadastroCResp(this);
            activeForm.Show();

        }

        private void lblCriar_Click(object sender, EventArgs e)
        {

            if (activeForm != null)
                activeForm.Close();

            activeForm = new CadastroCResp(this);
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

            activeForm = new CadastroCResp(this);
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
                resp.Id = 0;
                ListView.Visible = false;
            }
        }

        private void ListView_MouseClick(object sender, MouseEventArgs e)
        {
            resp.Id = short.Parse(ListView.SelectedItems[0].SubItems[0].Text);
            txtResponsavel.Text = ListView.SelectedItems[0].SubItems[1].Text;
            txtParentesco.Focus();
            ListView.Visible = false;
        }

        private void Fundo_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.Visible = false;
            Fundo.Focus();
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
            if (txtCep.MaskCompleted == false)
            {
                txtEnd.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                _ = func.BuscarCep(txtCep, txtEnd, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void btnBuscar_MouseEnter(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscarF, btnBuscar);
            panelBtnBuscar.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void btnBuscarF_MouseLeave(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscar, btnBuscarF);
            panelBtnBuscar.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscarF, btnBuscar);
            panelBtnBuscar.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscar, btnBuscarF);
            panelBtnBuscar.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void labelend_Click(object sender, EventArgs e)
        {
            if (txtCep.MaskCompleted == false)
            {
                txtEnd.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                _ = func.BuscarCep(txtCep, txtEnd, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void labelend_MouseEnter(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscarF, btnBuscar);
            panelBtnBuscar.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void labelend_MouseLeave(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscar, btnBuscarF);
            panelBtnBuscar.BackColor = Color.FromArgb(192, 192, 192);
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtCep.MaskCompleted == false)
            {
                txtEnd.Text = "";
                txtEnd2.Visible = false;
                MessageBox.Show("CEP inválido.");
            }
            else
            {
                Funcionalidades func = new Funcionalidades();
                _ = func.BuscarCep(txtCep, txtEnd, txtEnd2, txtBairro);
                txtNumero.Focus();
            }
        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {
            if (txtCep.MaskCompleted != true)
            {
                txtEnd.Text = txtBairro.Text = txtEnd2.Text = null;
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
                txtSala.Focus();
            }
        }

        private void btnEspecial_CheckedChanged(object sender, EventArgs e)
        {
            if (btnEspecial.Checked == true)
            {
                lblCuidados.Visible = txtCuidados.Visible = true;
            }
            else
            {
                lblCuidados.Visible = txtCuidados.Visible = false;
            }
        }

        private void linkEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.BuscarEnd("https://buscacepinter.correios.com.br/app/endereco/index.php");
        }

        private void txtResponsavel_Enter(object sender, EventArgs e)
        {
            if (txtResponsavel.Text != "")
            {
                ListView.Visible = true;
            }
        }
    }
}
