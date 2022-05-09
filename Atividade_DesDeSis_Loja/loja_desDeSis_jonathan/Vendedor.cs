using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public class Vendedor : Funcionario
    {


        private double salario;

        public Vendedor(String nome, int senha) : base(nome, senha)
        {

            this.nome = nome;
        }

        public double getSalario()
        {
            return salario;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

    }

}
