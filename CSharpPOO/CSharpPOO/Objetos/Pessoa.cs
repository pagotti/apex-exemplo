using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPOO.Objetos
{
    class Pessoa
    {

        public Pessoa()
        {

        }

        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        // Nome, Endereco, Idade, DataNascimento
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Idade { get; private set; }

        private DateTime dataNascimento;
        public DateTime DataNascimento 
        {
            get { return this.dataNascimento; }
            set 
            { 
                this.dataNascimento = value;
                // TODO: Calcular a idade  
            } 
        }

        public void Andar()
        {

        }
        public void Comer()
        {

        }
        public void Beber()
        {

        }
    }
}
