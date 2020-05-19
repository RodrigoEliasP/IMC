using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    class Atleta
    {
        private string nome;

        private double altura;

        private double peso;

        private int idade;

        public string Nome { 
            get{
                return this.nome;
            } 
            set{
                if (value == string.Empty)
                {
                    throw new Exception("O campo nome deve ser preenchido");
                }
                else
                {
                    this.nome = value;
                }
            } 
        }

        public double Altura
        {
            get
            {
                return this.altura;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Peso não pode ser negativo");
                }
                else
                {
                    this.altura = value;
                }
            }
        }


        public double Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Peso não pode ser negativo");
                }
                else
                {
                    this.peso = value;
                }
            }
        }


        public int Idade
        {
            get
            {
                return this.idade;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Idade não pode ser negativo");
                }
                else
                {
                    this.idade = value;
                }
            }
        }
        public double CalculaIMC()
        {
            return this.peso / Math.Pow(this.altura, 2);
        }
    }
}
