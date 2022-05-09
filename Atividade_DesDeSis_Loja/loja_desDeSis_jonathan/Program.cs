using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    internal class Program
    {
        public static List<Produto> listaPedidos = new List<Produto>();
        public static List<Produto> listaProdutos = new List<Produto>();
        public static List<Cliente> listaClientes = new List<Cliente>();
        public static void Main(String[] args)
        {



            listaProdutos.Add(new Produto("Arroz", 20.0, 999));
            listaProdutos.Add(new Produto("Macarrão", 3.0, 999));
            listaProdutos.Add(new Produto("Lasanha", 15.0, 999));

            String condicao = "";
            do
            {
                Console.WriteLine("\n  =========================");
                Console.WriteLine(" | Seja bem-vindo! Digite: |");
                Console.WriteLine(" |                         |");
                Console.WriteLine(" |     1 - Cliente         |");
                Console.WriteLine(" |     2 - Outro           |");
                Console.WriteLine(" |     0 - Encerrar        |");
                Console.WriteLine("  =========================");
                Console.Write("Opcão --> ");
                condicao = Console.ReadLine();
                switch (condicao)
                {
                    case "1":
                        condicao = Cliente.cadastro(condicao);

                        condicao = Produto.menu(condicao);
                        condicao = Produto.comprarItem(condicao); ;
                        break;
                    case "2":
                        condicao = Funcionario.menu(condicao);
                        break;
                    case "0":
                        Console.WriteLine("Até logo. Saindo...");
                        condicao = "N";
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente!");
                        condicao = "S";
                        break;

                }
            } while (condicao[0] != 'N');

        }

    }
}
