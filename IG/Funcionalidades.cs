using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG
{
    internal class Funcionalidades
    {
        public static void verificTxt(TextBox[] args, MaskedTextBox[] arg, Button btn, TextBox txtNome, TextBox txtNomer,
            DateTimePicker Calendario, DateTimePicker Calendarior, MaskedTextBox txtRg, MaskedTextBox txtRgr,
            MaskedTextBox txtCpf, MaskedTextBox txtCpfr, MaskedTextBox txtCep, MaskedTextBox txtCepr, TextBox txtEnd, TextBox txtEndr,
            TextBox txtSala, TextBox txtParentesco, Label lblIdade, Label lblIdader, MaskedTextBox txtCelr)

        {

            if (txtNome.Text != null && txtNomer.Text != null && txtRg.MaskCompleted == true
                && txtRgr.MaskCompleted == true && txtCpf.MaskCompleted == true && txtCpfr.MaskCompleted == true
                && txtCep.MaskCompleted == true && txtCepr.MaskCompleted == true && txtEnd.Text != null
                && txtEndr.Text != null && txtSala.Text != null && txtParentesco.Text != null
                && lblIdade.Text != "0" && lblIdader.Text != "0" && txtCelr.MaskCompleted == true)
            {
                Criancas cr = new Criancas();
                Responsaveis resp = new Responsaveis();


                cr.Nome = txtNome.Text;
                cr.Datanasc = Calendario.Text;
                cr.Rg = txtRg.Text;
                cr.Cpf = txtCpf.Text;
                cr.Cep = txtCep.Text;
                cr.End = txtEnd.Text;
                cr.Sala = txtSala.Text;

                resp.Nome = txtNomer.Text;
                resp.Datanasc = Calendarior.Text;
                resp.Rg = txtRgr.Text;
                resp.Cpf = txtCpfr.Text;
                resp.Cep = txtCepr.Text;
                resp.End = txtEndr.Text;
                resp.Parentesco = txtParentesco.Text;
                resp.Cel = txtCelr.Text;

                DAO banco = new DAO();
                banco.InserirValoresG(cr.Nome, cr.Datanasc, cr.Rg, cr.Cpf, cr.Cep, cr.End, cr.Sala, resp.Nome, resp.Datanasc,
                resp.Rg, resp.Cpf, resp.Cep, resp.End, resp.Parentesco, resp.Cel);

                for (short i = 0; i < args.Length; i++)
                {
                    args[i].Clear();
                }
                for (short i = 0; i < arg.Length; i++)
                {
                    arg[i].Clear();
                }
                lblIdade.Text = lblIdader.Text = "0";
                Calendario.Value = DateTime.Now;
                Calendarior.Value = DateTime.Now;



            }
            else {
                for (short i = 0; i < args.Length; i++)
                {
                    if (args[i].Text == "")
                    {
                        args[i].Focus();
                        MessageBox.Show("Preencha todos os dados.");
                        break;
                    }
                }

                for (short i = 0; i < arg.Length; i++)
                {
                    if (arg[i].MaskCompleted != true)
                    {
                        args[i].Focus();
                        MessageBox.Show("Documento(s) inválido(s).");
                        break;
                    }
                }

                if (short.Parse(lblIdade.Text) <= 0 || short.Parse(lblIdader.Text) <= 0)
                {
                    MessageBox.Show("Data de nascimento inválida.");
                }
            }
        }
    }
}
