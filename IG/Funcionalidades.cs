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
        public static void verificTxtC(TextBox[] args, MaskedTextBox[] arg, Button btn, TextBox txtNome,
            DateTimePicker Calendario, MaskedTextBox txtRg, MaskedTextBox txtCpf, MaskedTextBox txtCep,
            TextBox txtEnd, TextBox txtSala, Label lblIdade, ListBox ListBox)

        {

            if (txtNome.Text != null && txtRg.MaskCompleted == true
                && txtCpf.MaskCompleted == true && txtCep.MaskCompleted == true && txtEnd.Text != null
                && txtSala.Text != null && lblIdade.Text != "0" && ListBox.SelectedItems != null)
            {
                Criancas cr = new Criancas();

                cr.Ativo = true;
                cr.Nome = txtNome.Text;
                cr.Datanasc = Calendario.Text;
                cr.Rg = txtRg.Text;
                cr.Cpf = txtCpf.Text;
                cr.Cep = txtCep.Text;
                cr.End = txtEnd.Text;
                cr.Sala = txtSala.Text;

                DAO banco = new DAO();

                banco.InserirValoresC(cr.Nome, cr.Datanasc, cr.Rg, cr.Cpf, cr.Cep, cr.End, cr.Sala);

                Limpar(args, arg, lblIdade, Calendario);


            }
            else {
                for (short i = 0; i < args.Length; i++)
                {
                    for (short ind = 0; ind < arg.Length; ind++) { 
                        if (args[i].Text == "")
                        {
                            args[i].Focus();
                            MessageBox.Show("Preencha todos os dados.");
                            break;
                        }
                        else if (arg[ind].MaskCompleted != true) {

                            arg[ind].Focus();
                            MessageBox.Show("Documento(s) inválido(s).");
                            break;

                        }
                        else if (short.Parse(lblIdade.Text) <= 0) 
                        { 
                            MessageBox.Show("Data de nascimento inválida.");
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public static void Limpar(TextBox[] args, MaskedTextBox[] arg, Label lblIdade, DateTimePicker Calendario) {
            for (short i = 0; i < args.Length; i++)
            {
                args[i].Clear();
            }
            for (short i = 0; i < arg.Length; i++)
            {
                arg[i].Clear();
            }
            lblIdade.Text = "0";
            Calendario.Value = DateTime.Now;
        }
    }
}
