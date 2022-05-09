using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public class Fornecedor : Funcionario
    {

        private String cnpj;

        public Fornecedor(String nome, String cnpj, String login, int senha) : base(nome, senha)
        {
            this.cnpj = cnpj;
        }

        public String getCnpj()
        {
            return cnpj;
        }

        public void setCnpj(String cnpj)
        {
            this.cnpj = cnpj;
        }


    }

}
