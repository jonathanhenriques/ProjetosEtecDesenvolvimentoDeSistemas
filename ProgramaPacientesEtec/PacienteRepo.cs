using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    internal class PacienteRepo
    {

        private List<Paciente> listaDePacientes = new List<Paciente>();
        private List<Paciente> listaDePacientePrioritario = new List<Paciente>();
        private string condicao = "";
        //private int posicaoAtendimento = 0;
        private int vez = 0; //0 - prioritário | 1 - normal


        public string Menu()
        {

            Console.WriteLine("\n  =============================");
            Console.WriteLine(" |        O que deseja?        |");
            Console.WriteLine(" |                             |");
            Console.WriteLine(" |   1 - Cadastrar Paciente    |");
            Console.WriteLine(" | 2 - Cadastrar P/ Prioritário|");
            Console.WriteLine(" |   3 - Lista de Pacientes    |");
            Console.WriteLine(" | 4 - Chamar Próximo Paciente |");
            Console.WriteLine(" | 5 - Alterar dados Paciente  |");
            Console.WriteLine(" |   0 - Sair                  |");
            Console.WriteLine("  =============================");
            Console.Write("Opcão --> ");
            String opcao = Console.ReadLine();

            try
            {
                VerificaEntrada(opcao, 0, 5);
            }catch(Exception)
            {
                Console.WriteLine("Apenas números!");
            }

            switch (opcao)
            {
                case "1":
                    Cadastro();
                    break;
                case "2":
                    CadastroPrioritario();
                    break;
                case "3":
                    ListarPacientes();
                    break;
                case "4":
                    ChamarPaciente();
                    break;
                case "5":
                    AlterarDadosPaciente();
                    break;
                case "0":
                    //Console.WriteLine("Até a Próxima!!!");
                    encerrarMenu(opcao);
                    break;

            }

            return condicao;

        }

        public Boolean VerificaEntrada(String opcao, int menorValor, int maiorValor)
        {
            if (int.Parse(opcao) < menorValor || int.Parse(opcao) > maiorValor)
            {
                while (int.Parse(opcao) < menorValor || int.Parse(opcao) > maiorValor)
                {
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    Console.Write("Opcão --> ");
                    opcao = Console.ReadLine();
                }
            }
            return false;
        }

        public void encerrarMenu(String opcao)
        {
            if (!opcao.Equals("0"))
            {
                Console.WriteLine("Deseja Sair? Insira 'q' ");
                opcao = Console.ReadLine();
                Console.WriteLine(opcao);

            }
            Console.WriteLine("Até a próxima!!!");
            condicao = "q";

        }


        public void ChamarPaciente()
        {
            if (listaDePacientes.Count == 0 && listaDePacientePrioritario.Count == 0)
            {
                Console.WriteLine("Lista vazia!!!");
                return;
            }
            else
            {
                if (vez == 0)
                {
                    if (listaDePacientePrioritario.Count > 0)
                    {
                        Paciente pacientePrioritario = listaDePacientePrioritario[0];
                        listaDePacientePrioritario.RemoveAt(0);
                        Console.WriteLine("Próximo Paciente Prioritário: " + pacientePrioritario.getNome());
                    }
                    else
                        Console.WriteLine("Lista Prioritária Vazia! Tente novamente");

                    vez = 1;
                }
                else
                {
                    if (listaDePacientes.Count > 0)
                    {
                        Paciente proximoPaciente = listaDePacientes[0];
                        listaDePacientes.RemoveAt(0);
                        Console.WriteLine("Próximo Paciente: " + proximoPaciente.getNome());
                    }
                    else
                        Console.WriteLine("Lista Prioritária Vazia! Tente novamente");

                    vez = 0;
                }

            }

        }


        public Paciente EncontraPaciente()
        {
            Console.WriteLine("\n  =========================");
            Console.WriteLine(" | Insira n° do Paciente:|");
            Console.WriteLine("  =========================");
            ListarPacientes();
            Console.WriteLine("\n0 - Cancelar");
            Console.Write("Opcão -->\n");
            int posicaoPaciente = int.Parse(Console.ReadLine());



            if (posicaoPaciente == 0)
            {
                Console.WriteLine("Operação Cancelada!");
                return null;

            }
            else
            {
                Console.WriteLine("é prioritário? [S/N]");
                String categoriaPaciente = " ";
                categoriaPaciente = Console.ReadLine();
                categoriaPaciente = categoriaPaciente.ToUpper();
                Paciente paciente;

                if (categoriaPaciente.Equals("S"))
                {
                    paciente = listaDePacientePrioritario.ElementAt(posicaoPaciente - 1);
                }
                else
                {
                    paciente = listaDePacientes.ElementAt(posicaoPaciente - 1);
                }

                return paciente;
            }


        }



        public void CadastroPrioritario()
        {
            string opcao = "";
            while (!opcao.Equals(0))
            {
                Console.WriteLine("\n  =========================");
                Console.WriteLine(" | insira nome do Paciente:|");
                Console.WriteLine("  =========================");
                Console.WriteLine("0 - Cancelar");
                Console.Write("Opcão --> ");
                string nome = Console.ReadLine();

                if (nome.Equals("0"))
                {
                    Console.WriteLine("Operação Cancelada!");
                    break;
                }



                Console.WriteLine("\n  =========================");
                Console.WriteLine(" | insira idade do Paciente |");
                Console.WriteLine("  =========================");
                Console.WriteLine("0 - Cancelar");
                Console.Write("Opcão --> ");
                int idade = 0;
                try
                {
                    idade = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Insira apenas números");
                }


                if (idade == 0)
                {
                    Console.WriteLine("Operação Cancelada!");
                    break;
                }

                Paciente pacientePrioritario = new Paciente(nome, idade);
                listaDePacientePrioritario.Add(pacientePrioritario);

            }
        }



        public void Cadastro()
        {
            String opcao = "";
            while (!opcao.Equals(0))
            {

                Console.WriteLine("\n  =========================");
                Console.WriteLine(" | insira nome do Paciente:|");
                Console.WriteLine("  =========================");
                Console.WriteLine("0 - Cancelar");
                Console.Write("Opcão --> ");

                string nome = Console.ReadLine();

                if (nome.Equals("0"))
                {
                    Console.WriteLine("Operação Cancelada!");
                    break;
                }



                Console.WriteLine("\n  =========================");
                Console.WriteLine(" | insira idade do Paciente |");
                Console.WriteLine("  =========================");
                Console.WriteLine("0 - Cancelar");
                Console.Write("Opcão --> ");
                int idade = 0;
                try
                {
                    idade = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine(" insira números!");
                }


                if (idade == 0)
                {
                    Console.WriteLine("Operação Cancelada!");
                    break;
                }


                Paciente paciente = new Paciente(nome, idade);
                listaDePacientes.Add(paciente);

            }


        }



        public void ListarPacientes()
        {
            if (listaDePacientes.Count == 0 && listaDePacientePrioritario.Count == 0)
            {
                Console.WriteLine("Lista vazia!!!");
                return;
            }
            int posicao = 0;
            foreach (Paciente p in listaDePacientes)
            {
                Console.WriteLine(posicao + 1 + ": " + p.getNome() + " | " + p.getIdade());
                posicao++;
            }
            Console.WriteLine("\n**Prioritário**");
            if(listaDePacientePrioritario.Count == 0)
                Console.WriteLine("Vazia!");
            else
            {
                int posicaoPrioritario = 0;
                foreach (Paciente p in listaDePacientePrioritario)
                {
                    Console.WriteLine(posicaoPrioritario + 1 + ": " + p.getNome() + " | " + p.getIdade());
                    posicaoPrioritario++;
                }
            }
        }


        public void AtenderPaciente(Paciente paciente)
        {
            Boolean pacienteValido = false;
            int posicao = 0;
            foreach (Paciente p in listaDePacientes)
            {
                if (p == paciente)
                {
                    pacienteValido = true;
                }
                posicao++;
            }
            if (pacienteValido)
            {
                foreach (Paciente p in listaDePacientes)
                {
                    Paciente pacienteASerAtendido = listaDePacientes.ElementAt(posicao);
                    listaDePacientes.Insert(posicao, null);
                    listaDePacientePrioritario.Add(pacienteASerAtendido);


                    Console.WriteLine("Paciente Prioridade: " + pacienteASerAtendido);
                }

            }

        }



        public void AlterarDadosPaciente()
        {
            if (listaDePacientes.Count == 0 && listaDePacientePrioritario.Count == 0)
            {
                Console.WriteLine("Lista vazia!!!");
                return;
            }
            //Console.WriteLine("\n");
            Paciente paciente = EncontraPaciente();
            if(paciente == null)
                return;
            Console.WriteLine("O que deseja alterar? 1 - Nome / 2 - Idade / 0 - Cancelar");
            Console.Write("Opcão --> ");
            string opcao = Console.ReadLine();

            if (condicao.Equals("0"))
            {
                Console.WriteLine("Operação cancelada!");
                return;
            }
                

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\n  =========================");
                    Console.WriteLine(" | Informe novo Nome:|");
                    Console.WriteLine("  =========================");

                    Console.Write("Opcão --> ");
                    string nomePaciente = Console.ReadLine();

                    if (nomePaciente.Equals(0))
                    {
                        Console.WriteLine("Operação Cancelada!");
                        break;
                    }

                    paciente.setNome(nomePaciente);
                    break;
                case "2":
                    Console.WriteLine("\n  =========================");
                    Console.WriteLine(" | Informe nova Idade:|");
                    Console.WriteLine("  =========================");

                    Console.Write("Opcão --> ");
                    int idadePaciente = int.Parse(Console.ReadLine());

                    if (idadePaciente == 0)
                    {
                        Console.WriteLine("Operação Cancelada!");
                        break;
                    }

                    paciente.setIdade(idadePaciente);
                    break;
            }
        }





    }
}
