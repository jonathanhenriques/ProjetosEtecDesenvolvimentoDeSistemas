using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vetores
{
    class Paciente
    {
        private string nome;
        private int idade;
        private Boolean chamado = false;

        public Paciente(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public Boolean getChamado()
        {
            return chamado;
        }

        public void setChamado(Boolean valor)
        {
            chamado = valor;
        }

    }
}
