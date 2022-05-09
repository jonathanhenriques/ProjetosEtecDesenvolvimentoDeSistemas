using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public class Produto
    {


        private String nome;
        private double preco;
        private int quantidade;

        public Produto(String nome, double preco, int quantidade)
        {
            this.nome = nome;
            this.preco = preco;
            this.quantidade = quantidade;
        }

        public static String menu(String condicao)
        {
            Console.WriteLine("\n  =========================");
            Console.WriteLine(" |       Digite:           |");
            Console.WriteLine(" |                         |");
            Console.WriteLine(" |     1 - Comprar Item    |");
            Console.WriteLine(" |     2 - Menu Principal  |");
            Console.WriteLine(" |     0 - Encerrar        |");
            Console.WriteLine("  =========================");

            Console.Write("Opcão --> ");
            condicao = Console.ReadLine();
            while (int.Parse(condicao) < 0 || int.Parse(condicao) > 2)
            {
                Console.WriteLine("Opção inválida! Tente novamente");
                if (int.Parse(condicao) < 0 || int.Parse(condicao) > 2)
                {
                    Console.Write("Opcão --> ");
                    condicao = Console.ReadLine();
                }
            }

            return condicao;
        }

        public static String comprarItem(String condicao)
        {
            switch (condicao)
            {
                case "1":
                    Console.WriteLine("\n  ===========================");
                    Console.WriteLine(" | Informe código do Produto:|");
                    Console.WriteLine("  ===========================");
                    Console.Write("Opcão --> ");
                    int codProduto = int.Parse(Console.ReadLine());
                    codProduto = codProduto - 1;

                    Console.WriteLine("\n  =========================");
                    Console.WriteLine(" |  quantidade do Produto:   |");
                    Console.WriteLine("  =========================");
                    Console.Write("Opcão --> ");
                    int qtdProdutoComprada = int.Parse(Console.ReadLine());

                    String pNome = Program.listaProdutos.ElementAt(codProduto).getNome();
                    double pPreco = Program.listaProdutos.ElementAt(codProduto).getPreco();
                    int pQtd = Program.listaProdutos.ElementAt(codProduto).getQuantidade();

                    Program.listaPedidos.Add(new Produto(pNome, pPreco, pQtd));
                    Program.listaProdutos.ElementAt(codProduto).setQuantidade(Program.listaProdutos.ElementAt(codProduto).getQuantidade() - qtdProdutoComprada);
                    Program.listaPedidos.Last().setQuantidade(qtdProdutoComprada);

                    Console.WriteLine("Pedido Registrado!");
                    Console.WriteLine(Program.listaPedidos.Last() + " - TOTAL:R$" + (Program.listaPedidos.Last().getPreco() * qtdProdutoComprada));
                    break;
                case "2":
                    condicao = "S";//
                    break;
                case "0":
                    condicao = "N";
                    break;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente");
                    break;
            }

            return condicao;
        }

        public static String menuRegistraExclui(String condicao)
        {
            while (condicao[0] != 'N')
            {
                Console.WriteLine("\n  =============================");
                Console.WriteLine(" |        O que deseja?        |");
                Console.WriteLine(" |                             |");
                Console.WriteLine(" |     1 - Registrar Produto   |");
                Console.WriteLine(" |     2 - Excluir Produto     |");
                Console.WriteLine(" |     3 - Menu Principal      |");
                Console.WriteLine("  =============================");
                Console.Write("Opcão --> ");
                condicao = Console.ReadLine();

                if (int.Parse(condicao) < 1 || int.Parse(condicao) > 3)
                {
                    while (int.Parse(condicao) < 1 || int.Parse(condicao) > 3)
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.Write("Opcão --> ");
                        condicao = Console.ReadLine();
                    }
                }

                switch (condicao)
                {
                    case "1":
                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe nome do Produto:|");
                        Console.WriteLine("  =========================");
                        Console.WriteLine("0 - Cancelar");
                        Console.Write("Opcão --> ");
                        String nomeProduto = Console.ReadLine();
                        if (int.Parse(nomeProduto) == 0)
                        {
                            Console.WriteLine("Operação Cancelada!");
                            break;
                        }

                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe valor do Produto:|");
                        Console.WriteLine("  =========================");
                        Console.Write("Opcão --> ");
                        double valorProduto = double.Parse(Console.ReadLine());

                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe qtd do Produto:  |");
                        Console.WriteLine("  =========================");
                        Console.Write("Opcão --> ");
                        int qtdProduto = int.Parse(Console.ReadLine());

                        Program.listaProdutos.Add(new Produto(nomeProduto, valorProduto, qtdProduto));
                        Console.WriteLine("Produto Cadastrado com Sucesso!");
                        Console.WriteLine(Program.listaProdutos.Last());

                        condicao = "S";

                        break;
                    case "2":
                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe cod do produto:|");
                        Console.WriteLine("  =========================");

                        int count = 0;
                        foreach (Produto p in Program.listaProdutos)
                        {
                            Console.Write((count++) + "° ");
                            Console.WriteLine(p);
                        }
                        Console.WriteLine("0 - Cancelar");
                        Console.Write("Opcão --> ");
                        int codProduto = int.Parse(Console.ReadLine());
                        if (codProduto == 0)
                        {
                            Console.WriteLine("Operação Cancelada!");
                            break;
                        }

                        Console.WriteLine("Produto Removido!");
                        Console.WriteLine("XX" + Program.listaProdutos.ElementAt(codProduto) + "XX");
                        Program.listaProdutos.RemoveAt(codProduto);

                        condicao = "S";

                        break;
                    case "3":
                        Console.WriteLine("Volte em outro momento. Até");
                        condicao = "N";
                        break;
                    case "0":
                        condicao = "N";
                        break;
                }
            }
            return condicao;
        }

        public static String menuRegistra(String condicao)
        {
            while (condicao[0] != 'N')
            {
                Console.WriteLine("\n  =============================");
                Console.WriteLine(" |        O que deseja?        |");
                Console.WriteLine(" |                             |");
                Console.WriteLine(" |     1 - Registrar Produto   |");
                Console.WriteLine(" |     2 - Menu Principal      |");
                Console.WriteLine("  =============================");
                Console.Write("Opcão --> ");
                condicao = Console.ReadLine();

                if (int.Parse(condicao) < 1 || int.Parse(condicao) > 2)
                {
                    while (int.Parse(condicao) < 1 || int.Parse(condicao) > 2)
                    {
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        Console.Write("Opcão --> ");
                        condicao = Console.ReadLine();
                    }
                }

                switch (condicao)
                {
                    case "1":
                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe nome do Produto:|");
                        Console.WriteLine("  =========================");
                        Console.WriteLine("0 - Cancelar");
                        Console.Write("Opcão --> ");
                        String nomeProduto = Console.ReadLine();

                        if (int.Parse(nomeProduto) == 0)
                        {
                            Console.WriteLine("Operação Cancelada!");
                            break;
                        }

                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe valor do Produto:|");
                        Console.WriteLine("  =========================");
                        Console.Write("Opcão --> ");
                        double valorProduto = double.Parse(Console.ReadLine());

                        Console.WriteLine("\n  =========================");
                        Console.WriteLine(" | Informe qtd do Produto:  |");
                        Console.WriteLine("  =========================");
                        Console.Write("Opcão --> ");
                        int qtdProduto = int.Parse(Console.ReadLine());

                        Program.listaProdutos.Add(new Produto(nomeProduto, valorProduto, qtdProduto));
                        Console.WriteLine("Produto Cadastrado com Sucesso!");
                        Console.WriteLine(Program.listaProdutos.Last());

                        condicao = "S";
                        break;
                    case "2":
                        Console.WriteLine("Volte em outro momento. Até");
                        condicao = "N";
                        break;

                }

            }
            return condicao;
        }


        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public double getPreco()
        {
            return preco;
        }

        public void setPreco(double preco)
        {
            this.preco = preco;
        }

        public int getQuantidade()
        {
            return quantidade;
        }

        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }


        override public String ToString()
        {
            return "nome: " + nome + ", preco: R$" + preco + ", quantidade: " + quantidade + "x";
        }





    }
}
