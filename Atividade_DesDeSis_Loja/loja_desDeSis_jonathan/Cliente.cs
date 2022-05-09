using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public class Cliente : Pessoa
    {
        private String cpf;

        public Cliente(String nome) : base(nome)
        {
            this.cpf = "12345678910";
        }

        public static String cadastro(String condicao)
        {
            Console.WriteLine("Insira seu nome: ");
            String nomeCliente = Console.ReadLine();
            Boolean clienteExistente = false;
            foreach (Cliente c in Program.listaClientes)
            {
                if (c.getNome().Equals(nomeCliente))
                    clienteExistente = true;
            }

            if (clienteExistente)

                Console.WriteLine("Olá novamente, " + nomeCliente + "!");
            else
            {
                Program.listaClientes.Add(new Cliente(nomeCliente));
                Console.WriteLine("Olá, " + nomeCliente + "!");
            }

            Console.WriteLine("Aqui está nossa lista de Produtos:");
            int mostraPosicao = 1;
            foreach (Produto p in Program.listaProdutos)
            {
                Console.WriteLine("cod:" + mostraPosicao + "° - " + p);
                mostraPosicao++;
            }
            return condicao;
        }

        public String getCpf()
        {
            return cpf;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }




    }
}
