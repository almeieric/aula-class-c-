using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula
{
    class Pessoa
    {
        //atributos
        private string nome;
        private int idade;
        private double altura;
        private double peso;
        private string cpf;

        //metodo construtor
        public Pessoa()
        {
        
        
            this.nome = "";
            this.idade = 0;
            this.altura = 0.0;
            this.peso = 0.0;
            this.cpf = "";
        }
        public Pessoa(string cpf, string nome)
        {
            this.cpf = cpf;
            this.nome = nome;
        }
        public string NomeCPF()
        {
            return this.nome + " - " + this.cpf;
        }

    }//fim da pessoa

}//fim do aula
