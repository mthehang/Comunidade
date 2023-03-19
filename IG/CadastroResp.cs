using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IG
{
    public partial class CadastroResp : Form
    {
        Criancas cria = new Criancas();
        DAO dao = new DAO();
        Funcionalidades funcionalidades = new Funcionalidades();
        private Form activeForm = null!;
        public CadastroResp()
        {
            InitializeComponent();
            Calendario.Value = DateTime.Now;
            Calendario.MaxDate = DateTime.Now;
        }

        private void txtCrianca_TextChanged(object sender, EventArgs e)
        {
            if (txtCrianca.Text != "")
            {

                dao.ListViewC(ListView, txtCrianca.Text.ToUpper());
            }
            else
            {
                cria.Id = 0;
                ListView.Visible = false;
            }
        }

        private void CadastroResp_Load(object sender, EventArgs e)
        {
            string maior = (int.Parse(DateTime.Today.ToString("yyyyMMdd").Substring(0, 4)) - 18).ToString() + (DateTime.Today.ToString("yyyyMMdd")).Substring(4, 4);
            var cultureInfo = new CultureInfo("en-US");
            lblIdade.Text = 18.ToString();

            Calendario.Value = DateTime.ParseExact(maior, "yyyyMMdd", cultureInfo);
        }

        private void Calendario_ValueChanged(object sender, EventArgs e)
        {
            lblMaior.Visible = false;
            lblIdade.Text = Convert.ToString((DateTime.Now - Calendario.Value).Days / 30 / 12);
        }

        private void ListView_Click(object sender, EventArgs e)
        {
            cria.Id = short.Parse(ListView.SelectedItems[0].SubItems[0].Text);
            txtCrianca.Text = ListView.SelectedItems[0].SubItems[1].Text;
            txtParentesco.Focus();
            ListView.Visible = false;
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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

        private void linkEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.BuscarEnd("https://buscacepinter.correios.com.br/app/endereco/index.php");
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

        private void panelBtnBuscar_MouseClick(object sender, MouseEventArgs e)
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

        private void panelBtnBuscar_MouseEnter(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscarF, btnBuscar);
            panelBtnBuscar.BackColor = Color.FromArgb(211, 211, 211);
        }

        private void panelBtnBuscar_MouseLeave(object sender, EventArgs e)
        {
            Funcionalidades func = new Funcionalidades();
            func.OnOF(btnBuscar, btnBuscarF);
            panelBtnBuscar.BackColor = Color.FromArgb(192, 192, 192);
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


        private void txtCrianca_Enter(object sender, EventArgs e)
        {
            if (txtCrianca.Text != "")
            {
                ListView.Visible = true;
            }
        }

        private void Fundo_MouseClick(object sender, MouseEventArgs e)
        {
            ListView.Visible = false;
            Fundo.Focus();
        }
    }

}
