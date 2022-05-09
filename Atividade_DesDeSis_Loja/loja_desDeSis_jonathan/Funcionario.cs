using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public abstract class Funcionario : Pessoa
    {

        private String login;
        protected int senha;

        public Funcionario(String nome, int senha) : base(nome)
        {
            this.login = nome;
            this.senha = senha;
            this.nome = nome;
        }

        public Boolean autentica(Funcionario f)
        {
            if (f.getSenha() == 123)
                return true;
            return false;
        }

        public static String menu(String condicao)
        {
            Console.WriteLine("\n  =========================");
            Console.WriteLine(" |    Olá, Amigo! Digite:  |");
            Console.WriteLine(" |                         |");
            Console.WriteLine(" |   1 - Vendedor/Gerente  |");
            Console.WriteLine(" |     3 - Fornecedor      |");
            Console.WriteLine(" |     0 - Menu Principal  |");
            Console.WriteLine("\n  =========================");
            Console.Write("Opcão --> ");
            condicao = Console.ReadLine();
            if (int.Parse(condicao) < 0 || int.Parse(condicao) > 3)
            {
                while (int.Parse(condicao) < 0 || int.Parse(condicao) > 3)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Console.Write("Opcão --> ");
                    condicao = Console.ReadLine();
                }
            }

            switch (condicao)
            {

                case "1":

                    Console.Write("Informe seu nome: ");
                    String nomeFuncionario = Console.ReadLine();
                    Console.WriteLine("A senha é 123 para Vendedor");
                    Console.WriteLine("A senha é 456 para Gerente");
                    Console.Write("Informe sua senha: ");
                    int senhaFuncionario = int.Parse(Console.ReadLine());
                    if (senhaFuncionario == 123)
                    {
                        Funcionario funcionario = new Vendedor(nomeFuncionario, senhaFuncionario);
                        Console.WriteLine("\nOlá " + funcionario.getNome() + ">");
                        Produto.menuRegistra(condicao);
                    }
                    else if (senhaFuncionario == 456)
                    {
                        Funcionario funcionario = new Gerente(nomeFuncionario, senhaFuncionario);
                        Console.WriteLine("\nOlá " + funcionario.getNome() + ">");
                        Produto.menuRegistraExclui(condicao);
                    }

                    break;
                case "3":
                    Console.WriteLine("Lista de Pedidos a serem entregues:");
                    foreach (Produto p in Program.listaPedidos)
                    {
                        Console.WriteLine(p);
                    }
                    Console.WriteLine("Fim da lista.");
                    condicao = "S";
                    break;
                case "0":
                    condicao = "S";
                    break;
            }

            return condicao;
        }
        public String getLogin()
        {
            return login;
        }

        public void setLogin(String login)
        {
            this.login = login;
        }

        public int getSenha()
        {
            return senha;
        }

        public void setSenha(int senha)
        {
            this.senha = senha;
        }

    }
}
