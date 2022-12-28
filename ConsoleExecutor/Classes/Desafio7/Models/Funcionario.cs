using System.Globalization;
using System;

namespace ClasseDesafio.Desafio7
{
    public class Funcionario
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, int idade, double salario)
        {
            Nome = nome;
            Idade = idade;
            Salario = salario;
        }

        virtual public double Bonificacao() // virtual para usar metodos como sobrecarga nas classes filhas
        {
            return Salario;
        }

        virtual public string PrintName()
        {
            
            return "\nFuncionario";
        }


        public override string ToString()
        {
            return
                    this.PrintName() + "\n" +
                    "==============================================\n" +
                    "Nome: " + Nome + ", " +
                    "Idade: " + Idade + "\n" +
                    "Salario: " + Salario + " , " +
                    "Bonificação: " + this.Bonificacao().ToString("F2", CultureInfo.InvariantCulture) + 
                    "\n==============================================";
        }

    }
}