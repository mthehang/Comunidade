using System;
using System.Data;
using System.Data.Common;
using Npgsql;

namespace IG
{
    public class DAO {
        private static string Host = "ec2-18-209-78-11.compute-1.amazonaws.com";
        private static string User = "fyqggtqexifwde";
        private static string DBname = "d2pjbma96jccqm";
        private static string Password = "bb4499d4c5cb58d4e1387d42d86ab6f0924e6dd0930d405131124165daa16a5b";
        private static string Port = "5432";
        private string connString =
                String.Format(
                    "Server={0}; User Id={1}; Database={2}; Port={3}; Password={4};SSLMode=Prefer",
                    Host,
                    User,
                    DBname,
                    Port,
                    Password);

        public void InserirValoresC(string nome, string nasc, string rg, string cpf, string cep, string end, string sala)
        {
            
            using (var conn = new NpgsqlConnection(connString))
            {

                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO crianca (crianca_nome, crianca_datanasc, crianca_rg, " +
                    "crianca_cpf, crianca_cep, crianca_endereco, crianca_sala) values (@nomec, @nascc, @rgc, @cpfc, @cepc," +
                    "@endc, @salac)", conn))
                {
                    cmd.Parameters.AddWithValue("nomec", nome);
                    cmd.Parameters.AddWithValue("rgc", rg);
                    cmd.Parameters.AddWithValue("cpfc", cpf);
                    cmd.Parameters.AddWithValue("nascc", nasc);
                    cmd.Parameters.AddWithValue("cepc", cep);
                    cmd.Parameters.AddWithValue("endc", end);
                    cmd.Parameters.AddWithValue("salac", sala);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cadastro realizado com sucesso.");
                }

                conn.Close();
            }
        }

        public void ListBox(ListBox lb, string param){
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

                        lb.Items.Clear();

                        while (reader.Read())
                        {
                            resp.Id = short.Parse(reader["resp_id"].ToString()!);
                            
                            resp.Nome = reader["resp_nome"].ToString()!.ToUpper();
                            resp.Rg = reader["resp_rg"].ToString()!.ToUpper();
                            resp.Cpf = reader["resp_cpf"].ToString()!.ToUpper();

                            //lb.Items.Add(resp.Id + " / " + resp.Nome + " / CPF: " + resp.Cpf + " / RG: " + resp.Rg);
                            lb.Items.AddRange(new object[] { resp.Id });
                            lb.Visible = true;
                            

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

        public void Relacao(string param)
        {
            var cid = 0;
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand("SELECT (coalesce((MAX (crianca_id)), 0)+ 1) as crianca_id FROM crianca")) {
                    var reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        cid = short.Parse(reader["resp_nome"].ToString()!);
                    }
                    reader.Close();
                }
                if (cid != 0)
                {
                    using (var cmd = new NpgsqlCommand("insert into relacoes (relacoes_cid) values (@cid) where relacoes_rid = @param", conn))
                    {
                        cmd.Parameters.AddWithValue("param", param);
                        cmd.Parameters.AddWithValue("cid", cid);
                        cmd.ExecuteNonQuery();
                    }
                }
                conn.Close();
            }
        }
    }
}
