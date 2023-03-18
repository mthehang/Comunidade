using Org.BouncyCastle.Crypto;
using Refit;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace IG
{
    internal class Funcionalidades
    {
        public static void verificTxtC(TextBox[] args, TextBox txtNome,
            DateTimePicker Calendario, MaskedTextBox txtCep,
            TextBox txtEnd, TextBox txtSala, Label lblIdade, ListView ListView, short rid, Label txtEnd2, TextBox txtNumero, TextBox txtComplemento,
            TextBox txtBairro, CheckBox btnEspecial, TextBox txtCuidados, TextBox txtParentesco)

        {

            if (txtNome.Text != "" &&  txtCep.MaskCompleted == true && txtEnd.Text != ""
                && txtSala.Text != "" && lblIdade.Text != "0" && ListView.SelectedItems != null && rid != 0 && txtNumero.Text != "" && txtParentesco.Text != "" || txtNome.Text != null
                &&  txtCep.MaskCompleted == true && txtEnd.Text != null
                && txtSala.Text != "" && lblIdade.Text != "0" && ListView.SelectedItems != null && rid != 0 && txtNumero.Text != "" && txtParentesco.Text != "")
            {
                DAO banco = new DAO();
                Criancas cr = new Criancas();
                Responsaveis resp = new Responsaveis();

                    if (txtComplemento.Text != "")
                    {
                        cr.Especial = btnEspecial.Checked;
                        cr.Ativo = true;
                        cr.Nome = txtNome.Text.ToUpper();
                        cr.Datanasc = Calendario.Text;
                        cr.Cep = txtCep.Text;
                        if (txtComplemento.Text != "")
                        {
                            cr.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtComplemento.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        else
                        {
                            cr.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        resp.Parentesco = txtParentesco.Text;
                        cr.Sala = txtSala.Text.ToUpper();
                        resp.Id = rid;
                        banco.InserirValoresC(cr.Nome, cr.Datanasc, cr.Rg, cr.Cpf, cr.Cep, cr.End, cr.Especial);

                        if (cr.Especial == true)
                        {
                            
                            banco.Especial(txtCuidados.Text.ToUpper());
                        }

                        banco.Relacao(resp.Id, resp.Parentesco);

                        btnEspecial.Checked = false;
                        txtCuidados.Text = null;
                        txtCuidados.Visible = false;
                        Limpar(args, txtCep, lblIdade, Calendario, txtEnd2);
                    }
                    else
                    {
                        cr.Especial = btnEspecial.Checked;
                        cr.Ativo = true;
                        cr.Nome = txtNome.Text.ToUpper();
                        cr.Datanasc = Calendario.Text;
                        cr.Cep = txtCep.Text;
                        if (txtComplemento.Text != "")
                        {
                            cr.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtComplemento.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        else
                        {
                            cr.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        resp.Parentesco = txtParentesco.Text;
                        cr.Sala = txtSala.Text;
                        resp.Id = rid;
                        banco.InserirValoresC(cr.Nome, cr.Datanasc, cr.Rg, cr.Cpf, cr.Cep, cr.End, cr.Especial);
                        banco.Relacao(resp.Id, resp.Parentesco);

                        if (cr.Especial == true)
                        {
                            
                            banco.Especial(txtCuidados.Text);
                        }

                        btnEspecial.Checked = false;
                        txtCuidados.Text = null;
                        txtCuidados.Visible = false;
                        Limpar(args, txtCep, lblIdade, Calendario, txtEnd2);
                    }
                }
            else
            { 
                //melhorar na lógica

                for (short i = 0; i < args.Length; i++)
                {
                    if (args[i].Text == "")
                    {
                        args[i].Focus();
                        MessageBox.Show("Preencha todos os dados.");
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
                }
        }

        public static void verificTxtR(TextBox[] argsr, MaskedTextBox[] argr, TextBox txtNome,
            DateTimePicker Calendario, MaskedTextBox txtRg, MaskedTextBox txtCpf, MaskedTextBox txtCep,
            TextBox txtEnd, Label lblIdader, Label txtEnd2, TextBox txtNumero, TextBox txtComplemento,
            TextBox txtBairro, MaskedTextBox txtCel, Form ccr, Label ganb, Label lblOb)
        {

            if (txtRg.MaskCompleted == true && txtNome.Text != null && txtCpf.MaskCompleted == true && txtCep.MaskCompleted == true && txtEnd.Text != null
                && int.Parse(lblIdader.Text) >= 18 && txtNumero.Text != null && txtCel.MaskCompleted == true)
            {
                DAO banco = new DAO();
                Criancas cr = new Criancas();
                Responsaveis resp = new Responsaveis();

                bool x = IsCpf(txtCpf.Text);
                if (x == true)
                {
                    if (txtComplemento.Text != "")
                    {
                        resp.Ativo = true;
                        resp.Nome = txtNome.Text!.ToUpper();
                        resp.Datanasc = Calendario.Text;
                        resp.Rg = txtRg.Text;
                        resp.Cpf = txtCpf.Text;
                        resp.Cep = txtCep.Text;
                        if (txtComplemento.Text != "")
                        {
                            resp.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtComplemento.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        else
                        {
                            resp.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        resp.Cel = txtCel.Text;
                        banco.InserirValoresR(resp.Nome, resp.Datanasc, resp.Rg, resp.Cpf, resp.Cep, resp.End, resp.Parentesco, resp.Cel);
                        banco.RelacaoR(ganb);


                        ccr.Close();
                    }
                    else {
                        resp.Ativo = true;
                        resp.Nome = txtNome.Text!.ToUpper();
                        resp.Datanasc = Calendario.Text;
                        resp.Rg = txtRg.Text;
                        resp.Cpf = txtCpf.Text;
                        resp.Cep = txtCep.Text;
                        if (txtComplemento.Text != "")
                        {
                            resp.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtComplemento.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        else
                        {
                            resp.End = (txtEnd.Text + ", " + txtNumero.Text + " - " + txtBairro.Text + txtEnd2.Text).ToUpper();
                        }
                        resp.Cel = txtCel.Text;
                        banco.InserirValoresR(resp.Nome, resp.Datanasc, resp.Rg, resp.Cpf, resp.Cep, resp.End, resp.Parentesco, resp.Cel);
                        banco.RelacaoR(ganb);

                        ccr.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("CPF inválido");
                }

            }
            else
            {
                for (short i = 0; i < argsr.Length; i++)
                {
                    if (argsr[i].Text == "")
                    {
                        argsr[i].Focus();
                        MessageBox.Show("Preencha todos os dados.");
                        break;
                    }
                    else 
                        { 
                            for (short ind = 0; ind < argr.Length; ind++)
                            {

                                if (argr[ind].MaskCompleted != true)
                                {

                                    argr[ind].Focus();
                                    MessageBox.Show("Documento(s) inválido(s).");
                                    lblOb.Visible = true;
                                    break;

                                }
                                else if (int.Parse(lblIdader.Text) < 18)
                                {
                                    MessageBox.Show("Data de nascimento inválida.");
                                    break;
                                }
                                break;
                            
                            }
                        }
                    break;
                }
            }

        }

        public static void Limpar(TextBox[] args, MaskedTextBox cep, Label lblIdade, DateTimePicker Calendario, Label txtEnd2) {
            for (short i = 0; i < args.Length; i++)
            {
                args[i].Clear();
            }
            cep.Text = "";
            lblIdade.Text = "0";
            Calendario.Value = DateTime.Today;
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

        public async Task BuscarCep(MaskedTextBox Cep, TextBox txtEnd, Label txtEnd2, TextBox txtBairro) {
            
            Cep.Text.Replace(".", "").Replace("-", "");
            try 
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepBuscar.GetAddressAsync(Cep.Text);
                txtEnd.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtEnd2.Text = $"- {endereco.Localidade} - {endereco.Uf}";
                txtEnd2.Visible = true;
            
            }
            catch (Exception e)
            {
                MessageBox.Show("Falha ao buscar endereço.");
            }
        }

        public void BuscarEnd(string link) {

            Process.Start("explorer", link); 
            
        }
    }
}
