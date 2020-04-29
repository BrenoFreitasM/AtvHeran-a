using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHerança
{
    class Pessoa
    {
        private string nome;
        private string endereco;
        private string telefone;

        public Pessoa(string NOME, string ENDERECO, string TELEFONE)
        {
            this.nome = NOME;
            this.endereco = ENDERECO;
            this.telefone = TELEFONE;
        } 

        /* GET SET */
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public string Telefone
        {
            get { return Telefone; }
            set { Telefone = value; }
        }
    }
}
