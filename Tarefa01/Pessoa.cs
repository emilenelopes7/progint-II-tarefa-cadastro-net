using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa01
{
    class Pessoa
    {

        public String nome { get; set; }
        public String cpf { get; set; }
        public DateTime dataNascimento { get; set; }

        public Pessoa(String nome, String cpf, DateTime dataNascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.dataNascimento = dataNascimento;
        }

    }
}
