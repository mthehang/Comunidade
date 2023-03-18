using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IG
{
    internal class Responsaveis : Pessoa
    {
        
        private string parentesco;

        
        public string Parentesco { get { return parentesco; } set { parentesco = value; } }



    }
    internal class Criancas : Pessoa
    {

        private string sala;
        private string resp;
        private bool especial;
        public bool Especial { get { return especial; } set { especial = value; } }
        public string Sala{ get { return sala; } set { sala = value; } }
        public string Resp { get { return resp; } set { resp = value; } }

    }
}
