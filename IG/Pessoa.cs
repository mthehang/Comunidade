using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG
{
    internal class Pessoa
    {

        private string id;
        private string nome;
        private string rg;
        private string cpf;
        private string datanasc;
        private string cep;
        private string end;
        private string cel;


        public string Id { get { return id; } set { id = value; } }
        public string Nome { get { return nome; } set { nome = value; } }
        public string Rg { get { return rg; } set { rg = value; } }
        public string Cpf { get { return cpf; } set { cpf = value; } }
        public string Datanasc { get { return datanasc; } set { datanasc = value; } }
        public string Cep { get { return cep; } set { cep = value; } }
        public string End { get { return end; } set { end = value; } }
        public string Cel { get { return cel; } set { cel = value; } }

    }
}
