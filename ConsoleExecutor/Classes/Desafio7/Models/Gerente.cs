namespace ClasseDesafio.Desafio7
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, int idade, double salario) 
                : base(nome, idade, salario)
        {

        }

                public override string PrintName()
        {
            
            return "\n" + @"
   _____                     _       
  / ____|                   | |      
 | |  __  ___ _ __ ___ _ __ | |_ ___ 
 | | |_ |/ _ \ '__/ _ \ '_ \| __/ _ \
 | |__| |  __/ | |  __/ | | | ||  __/
  \_____|\___|_|  \___|_| |_|\__\___|
                                     
                                           
                ";
        }

        public override double Bonificacao()
        {
            return Salario + 10000.00;
        }
    }
}