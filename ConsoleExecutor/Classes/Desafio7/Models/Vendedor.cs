using System;

namespace ClasseDesafio.Desafio7
{
    public class Vendedor : Funcionario
    {
        public Vendedor(string nome, int idade, double salario) 
                : base(nome, idade, salario)
        {

        }

        public override string PrintName()
        {
            
            return "\n" + @"
 __      __            _          _            
 \ \    / /           | |        | |           
  \ \  / /__ _ __   __| | ___  __| | ___  _ __ 
   \ \/ / _ \ '_ \ / _` |/ _ \/ _` |/ _ \| '__|
    \  /  __/ | | | (_| |  __/ (_| | (_) | |   
     \/ \___|_| |_|\__,_|\___|\__,_|\___/|_|   
                                              
                ";
        }

        public override double Bonificacao()
        {
            return Salario + 3000.00;
        }
    }
}