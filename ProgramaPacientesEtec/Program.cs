using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
             Crie um programa em C#, para controlar a fila de atendimento de um hospital.
             Seu programa deve ter um Menu para cadastrar os pacientes, listar os pacientes,
             atender um paciente, alterar dados do paciente. O programa só deve ser encerrado
             caso o operador do programa escolha a opção "q". O programa deve controlar fila de prioridade,
             isto é, pessoas que precisam ser atendidas e tenham prioridade devem ser movidas para o inicio da fila.
             Usar uma Fila de 10 pacientes. Subir o projeto para o github em repositorio publico.
             Informar link do projeto. Boa Sorte :) 
            */

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string condicao = "";
            PacienteRepo repo = new PacienteRepo();

            Console.WriteLine("**Olá, seja bem-vindo!**\n");
            while (!(condicao.Equals("q")))
            {
                condicao = repo.Menu();

            }
        }
    }
}
