using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Security.Cryptography;
using Microsoft.VisualBasic.ApplicationServices;
using Npgsql;

namespace IG
{
    public class DAO {
        private static string Host = "db.dtxpsdywsyvqbywbvoeg.supabase.co";
        private static string User = "postgres";
        private static string DBname = "postgres";
        private static string Password = "IwiJdkcV28OmCtYg";
        private static string Port = "5432";
        private string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        public void InserirValoresC(string nome, string nasc, string rg, string cpf, string cep, string end, bool especial)
        {
            
            using (var conn = new NpgsqlConnection(connString))
            {

                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO crianca (crianca_nome, crianca_datanasc, " +
                    "crianca_cep, crianca_endereco, crianca_ativo, crianca_especial) values (@nomec, @nascc, @cepc," +
                    "@endc, @ativo, @especial)", conn))
                {
                    cmd.Parameters.AddWithValue("nomec", nome);
                    cmd.Parameters.AddWithValue("nascc", Convert.ToDateTime(nasc));
                    cmd.Parameters.AddWithValue("cepc", cep);
                    cmd.Parameters.AddWithValue("endc", end);
                    cmd.Parameters.AddWithValue("ativo", true);
                    cmd.Parameters.AddWithValue("especial", especial);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso.");
                }

                conn.Close();
            }
        }

        public void InserirValoresR(string nome, string nasc, string rg, string cpf, string cep, string end, string parent, string cel) 
        {
            using (var conn = new NpgsqlConnection(connString))
            {

                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO responsavel (resp_nome, resp_datanasc, resp_rg, " +
                    "resp_cpf, resp_cep, resp_endereco, resp_cel) values (@nome, @nasc, @rg, @cpf, @cep," +
                    "@end, @cel)", conn))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("rg", rg);
                    cmd.Parameters.AddWithValue("cpf", cpf);
                    cmd.Parameters.AddWithValue("nasc", Convert.ToDateTime(nasc));
                    cmd.Parameters.AddWithValue("cep", cep);
                    cmd.Parameters.AddWithValue("end", end);
                    cmd.Parameters.AddWithValue("cel", cel);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso.");
                }

                conn.Close();
            }
        }
        
        public void ListView(ListView ListView, string param){
            Responsaveis resp = new Responsaveis();
            
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT resp_id, resp_nome, resp_rg, resp_cpf FROM responsavel where resp_nome like @param or resp_rg like @rg or resp_cpf like @cpf order by resp_id", conn))
                    {

                        cmd.Parameters.AddWithValue("@param","%" + param + "%");
                        cmd.Parameters.AddWithValue("@rg", param + "%");
                        cmd.Parameters.AddWithValue("@cpf", param + "%");

                        var reader = cmd.ExecuteReader();

                        ListView.Items.Clear();

                        while (reader.Read())
                        {
                            resp.Id = short.Parse(reader["resp_id"].ToString()!);
                            resp.Nome = reader["resp_nome"].ToString()!.ToUpper();
                            resp.Rg = reader["resp_rg"].ToString()!.ToUpper();
                            resp.Cpf = reader["resp_cpf"].ToString()!.ToUpper();

                            ListViewItem item = new ListViewItem(resp.Id.ToString());
                            var obj = new object[] {resp.Nome, resp.Cpf, resp.Rg};
                            item.SubItems.Add(resp.Nome);
                            item.SubItems.Add(resp.Cpf);
                            item.SubItems.Add(resp.Rg);
                            ListView.Items.Add(item);                            
                            ListView.Visible = true;
                            

                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        public void ListViewC(ListView ListView, string param)
        {
            Criancas cria = new Criancas();

            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {
                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT crianca_id, crianca_nome FROM crianca where crianca_nome like @param or crianca_rg like @rg or crianca_cpf like @cpf order by crianca_id", conn))
                    {

                        cmd.Parameters.AddWithValue("@param", "%" + param + "%");

                        var reader = cmd.ExecuteReader();

                        ListView.Items.Clear();

                        while (reader.Read())
                        {
                            cria.Id = short.Parse(reader["crianca_id"].ToString()!);
                            cria.Cpf = reader["crianca_cpf"].ToString()!.ToUpper();

                            ListViewItem item = new ListViewItem(cria.Id.ToString());
                            var obj = new object[] { cria.Nome };
                            item.SubItems.Add(cria.Nome);
                            ListView.Items.Add(item);
                            ListView.Visible = true;


                        }
                        reader.Close();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


        public void ExTabela()
        {
            ExibirTabela();
        }
        private List<Criancas> ExibirTabela()
        {

            List<Criancas> pessoas = new List<Criancas>();
            Criancas cr = new Criancas();

            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                using (var command = new NpgsqlCommand("SELECT * FROM crianca order by crianca_id", conn))
                {
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {

                        cr.Id = short.Parse(reader["crianca_id"].ToString()!);
                        cr.Nome = reader["crianca_nome"].ToString()!;
                        cr.Datanasc = reader["crianca_datanasc"].ToString()!;
                        cr.Rg = reader["crianca_rg"].ToString()!;
                        cr.Cpf = reader["crianca_cpf"].ToString()!;
                        cr.Cep = reader["crianca_cep"].ToString()!;
                        cr.End = reader["crianca_endereco"].ToString()!;
                        cr.Sala = reader["crianca_sala"].ToString()!;
                        cr.Resp = reader["crianca_respid"].ToString()!;
                        pessoas.Add(cr);
                        foreach (var p in pessoas)
                        {
                            MessageBox.Show($"{(p.Id)} - {p.Nome} | {p.Datanasc} | {p.Rg} | {p.Cpf} | {p.Cep} | {p.End} | {p.Sala} | {p.Resp}");
                        }
                    }
                    reader.Close();
                }
                conn.Close();
            }
            return pessoas;
        }

        public void Relacao(short rid, string pare)
        {
            Criancas crianca = new Criancas();
            try {
                using (var conn = new NpgsqlConnection(connString))
                {

                    conn.Open();

                    using (var cmd = new NpgsqlCommand("SELECT crianca_id FROM crianca", conn))
                    {
                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            crianca.Id = short.Parse(reader["crianca_id"].ToString()!);
                        }
                        reader.Close();
                    }
                    using (var cmd = new NpgsqlCommand("INSERT INTO relacoes(relacoes_rid, relacoes_cid, relacoes_parentesco) values (@rid, @cid, @pare)", conn))
                    {
                        cmd.Parameters.AddWithValue("rid", rid);
                        cmd.Parameters.AddWithValue("pare", pare.ToUpper());
                        cmd.Parameters.AddWithValue("cid", crianca.Id);
                        cmd.ExecuteNonQuery();
                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void RelacaoR(Label ganb)
        {

            try
            {
                Responsaveis resp = new Responsaveis();
                using (var conn = new NpgsqlConnection(connString))
                {

                    conn.Open();

                    using (var cmd = new NpgsqlCommand("select resp_id from responsavel", conn))
                    {

                        var reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            resp.Id = short.Parse(reader["resp_id"].ToString()!);
                        }
                        reader.Close();

                        Nome(resp.Id, ganb);

                    }


                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void Nome(int id, Label ganb)
        {
            Responsaveis resp = new Responsaveis();
            try
            {
                using (var conn = new NpgsqlConnection(connString))
                {

                    conn.Open();
                    using (var cmd = new NpgsqlCommand("select resp_nome from responsavel where resp_id = @id", conn))
                    {
                        cmd.Parameters.AddWithValue("id", id);
                        var reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            resp.Nome = (reader["resp_nome"].ToString()!);
                        }
                        ganb.Text = resp.Nome;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString()!);
            }
        }
        public void Especial(string Cuidados) 
        {

            using (var conn = new NpgsqlConnection(connString))
            {
                Criancas crianca = new Criancas();
                conn.Open();

                using (var cmd = new NpgsqlCommand("SELECT crianca_id FROM crianca", conn))
                {
                    var reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        crianca.Id = short.Parse(reader["crianca_id"].ToString()!);
                    }

                    reader.Close();
                }
                using (var cmd = new NpgsqlCommand("insert into especial (especial_detalhe, especial_cid) values (@detalhe, @cid)", conn))
                {
                    
                    cmd.Parameters.AddWithValue("cid", crianca.Id);
                    cmd.Parameters.AddWithValue("detalhe", Cuidados.ToUpper());
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

    
    }
}
