using Org.BouncyCastle.Crypto;
using Refit;
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
            TextBox txtEnd, TextBox txtSala, Label lblIdade, ListView ListView, short rid, Label lblObrigatorio, Label txtEnd2)

        {

            if (txtNome.Text != null && txtRg.MaskCompleted == true && txtCep.MaskCompleted == true && txtEnd.Text != null
                && txtSala.Text != null && lblIdade.Text != "0" && ListView.SelectedItems != null && rid != 0 || txtNome.Text != null
                && txtCpf.MaskCompleted == true && txtCep.MaskCompleted == true && txtEnd.Text != null
                && txtSala.Text != null && lblIdade.Text != "0" && ListView.SelectedItems != null && rid != 0)
            {
                DAO banco = new DAO();
                Criancas cr = new Criancas();
                Responsaveis resp = new Responsaveis();

                if (txtRg.MaskCompleted == false)
                {
                    bool x = IsCpf(txtCpf.Text);
                    if (x == true)
                    {
                        cr.Ativo = true;
                        cr.Nome = txtNome.Text;
                        cr.Datanasc = Calendario.Text;
                        cr.Rg = txtRg.Text;
                        cr.Cpf = txtCpf.Text;
                        cr.Cep = txtCep.Text;
                        cr.End = txtEnd.Text;
                        cr.Sala = txtSala.Text;
                        resp.Id = rid;
                        //banco.InserirValoresC(cr.Nome, cr.Datanasc, cr.Rg, cr.Cpf, cr.Cep, cr.End, cr.Sala);
                        //banco.Relacao(resp.Id);

                        Limpar(args, arg, lblIdade, Calendario, lblObrigatorio, txtEnd2);
                    }
                    else
                    {
                        MessageBox.Show("CPF inválido");
                    }
                        
                }

            }
            else
            {
                for (short i = 0; i < args.Length; i++)
                {
                    for (short ind = 0; ind < arg.Length; ind++) {
                        if (args[i].Text == "")
                        {
                            args[i].Focus();
                            MessageBox.Show("Preencha todos os dados.");
                            break;
                        }
                        else if (arg[ind].MaskCompleted != true)
                        {

                            arg[ind].Focus();
                            MessageBox.Show("Documento(s) inválido(s).");
                            lblObrigatorio.Visible = true;
                            break;

                        }
                        else if (lblIdade.Text == "0")
                        {
                            MessageBox.Show("Data de nascimento inválida.");
                            break;
                        }
                        else if (rid == 0 )
                        {
                            MessageBox.Show("Responsável não cadastrado.");
                            break;
                        }
                    }
                    break;
                }
            }
        }

        public static void Limpar(TextBox[] args, MaskedTextBox[] arg, Label lblIdade, DateTimePicker Calendario, Label lblObrigatorio, Label txtEnd2) {
            for (short i = 0; i < args.Length; i++)
            {
                args[i].Clear();
            }
            for (short i = 0; i < arg.Length; i++)
            {
                arg[i].Clear();
            }
            lblIdade.Text = "0";
            Calendario.Value = DateTime.Today;
            lblObrigatorio.Visible = false;
            txtEnd2.Visible = false;
        }

        public void OnOF(PictureBox A, PictureBox B) {
            
            A.Visible = true;
            B.Visible = false;
            
        }

        public static bool IsCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            switch (cpf)
            {
                case "11111111111":
                    return false;
                case "00000000000":
                    return false;
                case "2222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }


        public async Task BuscarCep(MaskedTextBox Cep, TextBox txtEnd, Label txtEnd2) {
            
            Cep.Text.Replace(".", "").Replace("-", "");
            try 
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepBuscar.GetAddressAsync(Cep.Text);
                txtEnd.Text = endereco.Logradouro+", ";
                txtEnd.SelectionStart = txtEnd.Text.Length;
                txtEnd2.Text = $"- {endereco.Localidade} - {endereco.Uf}";
                txtEnd2.Visible = true;
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao buscar endereço.");
            }
        }
    }
}
