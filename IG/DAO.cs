using System;
using Npgsql;

namespace IG
{
    public class DAO
    {

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

        public void InserirValoresG(string nome, string nasc, string rg, string cpf, string cep, string end, string sala,
            string nomer, string nascr, string rgr, string cpfr, string cepr, string endr, string parr, string celr)
        {

            using (var conn = new NpgsqlConnection(connString))
            {

                conn.Open();

                using (var cmd = new NpgsqlCommand("INSERT INTO crianca (crianca_nome, crianca_datanasc, crianca_rg, " +
                    "crianca_cpf, crianca_cep, crianca_endereco, crianca_sala) values (@nomec, @rgc, @cpfc, @nascc, @cepc," +
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

                    using (var command = new NpgsqlCommand("INSERT INTO responsavel (resp_nome, resp_datanasc, resp_rg, resp_cpf" +
                        "resp_cep, resp_endereco, resp_parentesco, resp_cel) values (@nomer, @nascr, @rgr, @cpfr, @cepr, @endrm, @parr, @celr", conn))
                    {
                        command.Parameters.AddWithValue("nomer", nomer);
                        command.Parameters.AddWithValue("nascr", nascr);
                        command.Parameters.AddWithValue("rgr", rgr);
                        command.Parameters.AddWithValue("cpfr", cpfr);
                        command.Parameters.AddWithValue("cepr", cepr);
                        command.Parameters.AddWithValue("endr", endr);
                        command.Parameters.AddWithValue("parr", parr);
                        command.Parameters.AddWithValue("celr", celr);
                        command.ExecuteNonQuery();

                        MessageBox.Show("Cadastro realizado com sucesso.");
                        conn.Close();
                    }
                }
            }
        }

        //public void InserirTeste(string nome) 
        //{
        //    using (var conn = new NpgsqlConnection(connString))
        //    {
        //        MessageBox.Show("Conexão extabelecida.");
        //        conn.Open();

        //        //using (var command = new NpgsqlCommand("INSERT INTO pessoa (nomep) values (@nomep)", conn))
        //        //{
        //        //    command.Parameters.AddWithValue("nomep", nome);
        //        //    command.ExecuteNonQuery();
        //        //}

        //        using (var command = new NpgsqlCommand("UPDATE pessoa set nomep = @nomep where id = 1", conn))
        //        {
        //            command.Parameters.AddWithValue("nomep", nome);
        //            command.ExecuteNonQuery();
        //        }

        //    }


        public String ShowIdCrianca() {
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();
                string mensagem = null;

                using (var command = new NpgsqlCommand("SELECT MAX (crianca_id) as crianca_id FROM crianca", conn))
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        mensagem = (reader.GetInt32(0)).ToString();
                    }
                    reader.Close();
                    return mensagem;
                    conn.Close();
                }
            }
        }
    }
}
