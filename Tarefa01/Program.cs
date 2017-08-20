using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa01
{
    class Program
    {

        private static GerirPessoa gerirPessoa = new GerirPessoa();
        private static int opcao;

        private static string LerTeclado()
        {
            return Console.ReadLine();
        }

        private static void EscreverTeclado(string texto)
        {
            Console.WriteLine(texto);
        }

        private static int StringParaInt(string texto)
        {
            return int.Parse(texto);
        }

        private static DateTime StringParaDateTime(string value)
        {
            return Convert.ToDateTime(value);
        }

        static void Main(string[] args)
        {
            Console.Clear();

            EscreverTeclado("BEM-VINDO\n\n");

            do
            {
                EscreverTeclado("1 - Cadastrar");
                EscreverTeclado("2 - Atualizar");
                EscreverTeclado("3 - Excluir");
                EscreverTeclado("4 - Listar");
                EscreverTeclado("5 - Pesquisar");
                EscreverTeclado("6 - Sair");

                EscreverTeclado("\n\nInforme a opção desejada:");
                opcao = StringParaInt(LerTeclado());
                EscreverTeclado("\n");

                switch (opcao)
                {
                    case 1:
                        {
                            EscreverTeclado("Informe seu nome:");
                            String nome = LerTeclado();

                            EscreverTeclado("Informe seu CPF (somente números):");
                            String cpf = LerTeclado();

                            EscreverTeclado("Informe sua data de nascimento (dd/mm/yyyy):");
                            DateTime dataNascimento = StringParaDateTime(LerTeclado());
                            gerirPessoa.AdicionarPessoa(new Pessoa(nome, cpf, dataNascimento));

                            EscreverTeclado("\nPessoa inserida com sucesso!\n\n");
                            break;
                        }
                    case 2:
                        {
                            EscreverTeclado("Informe seu nome:");
                            String nome = LerTeclado();

                            EscreverTeclado("Informe seu CPF (somente números):");
                            String cpf = LerTeclado();

                            EscreverTeclado("Informe sua data de nascimento (dd/mm/yyyy):");
                            DateTime dataNascimento = StringParaDateTime(LerTeclado());

                            if (gerirPessoa.AtualizarPessoa(new Pessoa(nome, cpf, dataNascimento)))
                            {
                                EscreverTeclado("\nPessoa atualizada com sucesso!\n\n");
                            }
                            else
                            {
                                EscreverTeclado("\nCPF não encontrado!\n\n");
                            }
                            break;
                        }
                    case 3:
                        {
                            EscreverTeclado("Informe o CPF (somente números):");
                            String cpf = LerTeclado();
                            gerirPessoa.RemoverPessoa(cpf);
                            break;
                        }
                    case 4:
                        {
                            gerirPessoa.ListarPessoas().ForEach(pessoa =>
                            {
                                EscreverTeclado("Nome: " + pessoa.nome);
                                EscreverTeclado("CPF: " + pessoa.cpf.ToString());
                                EscreverTeclado("Data de Nascimento: " + pessoa.dataNascimento.ToString());
                                EscreverTeclado("\n");
                            });
                            break;
                        }
                    case 5:
                        {
                            EscreverTeclado("Informe o CPF (somente números):");
                            String cpf = LerTeclado();
                            Pessoa pessoa = gerirPessoa.BuscarPessoa(cpf);
                            EscreverTeclado("Nome: " + pessoa.nome);
                            EscreverTeclado("CPF: " + pessoa.cpf.ToString());
                            EscreverTeclado("Data de Nascimento: " + pessoa.dataNascimento.ToString());
                            EscreverTeclado("\n");
                            break;
                        }
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            } while (opcao != 6);
        }
    }
}
