using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa01
{
    class GerirPessoa
    {

        private List<Pessoa> pessoas;

        public GerirPessoa()
        {
            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
            }
        }

        private Boolean ExistePessoaPorCpf(String cpf)
        {
            return pessoas.Exists(p => p.cpf == cpf);
        }

        private Boolean ExistePessoa(Pessoa pessoa)
        {
            return ExistePessoaPorCpf(pessoa.cpf);
        }

        public List<Pessoa> ListarPessoas()
        {
            return pessoas;
        }

        public Boolean AdicionarPessoa(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
            return true;
        }

        public Boolean AtualizarPessoa(Pessoa pessoa)
        {
            if (ExistePessoa(pessoa))
            {
                Pessoa data = pessoas.Find(p => p.cpf == pessoa.cpf);
                data.nome = pessoa.nome;
                data.dataNascimento = pessoa.dataNascimento;
                return true;
            } else
            {
                return false;
            }
        }

        public Boolean RemoverPessoa(String cpf)
        {
            if (ExistePessoaPorCpf(cpf))
            {
                pessoas.RemoveAll(p => p.cpf == cpf);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Pessoa BuscarPessoa(String cpf)
        {
            return pessoas.Find(pessoa => pessoa.cpf == cpf);
        }

    }
}
