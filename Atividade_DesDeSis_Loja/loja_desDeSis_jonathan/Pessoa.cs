using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loja_desDeSis_jonathan
{
    public abstract class Pessoa
    {

        protected String nome;
        private String telefone;
        private String contato;
        private Endereco endereco;

        public Pessoa(String nome, String telefone, String contato, Endereco endereco)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.contato = contato;
            this.endereco = endereco;
        }

        public Pessoa(String nome)
        {
            this.nome = nome;
        }

        public String getNome()
        {
            return nome;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public String getContato()
        {
            return contato;
        }

        public void setContato(String contato)
        {
            this.contato = contato;
        }

        public Endereco getEndereco()
        {
            return endereco;
        }

        public void setEndereco(Endereco endereco)
        {
            this.endereco = endereco;
        }

    }
}
