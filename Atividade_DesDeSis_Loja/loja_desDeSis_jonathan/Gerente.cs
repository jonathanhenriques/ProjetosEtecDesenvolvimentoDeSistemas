using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public class Gerente : Funcionario
    {

        public Gerente(String nome, int senha) : base(nome, senha)
        {
            this.nome = nome;
            this.senha = senha;
        }


    }
}
