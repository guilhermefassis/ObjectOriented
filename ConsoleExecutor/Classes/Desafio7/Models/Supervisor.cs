namespace ClasseDesafio.Desafio7
{
    public class Supervisor : Funcionario
    {
        public Supervisor(string nome, int idade, double salario) 
                : base(nome, idade, salario)
        {

        }

                public override string PrintName()
        {
            
            return "\n" + @"
  _____                             _                
 / ____|                           (_)               
| (___  _   _ _ __   ___ _ ____   ___ ___  ___  _ __ 
 \___ \| | | | '_ \ / _ \ '__\ \ / / / __|/ _ \| '__|
 ____) | |_| | |_) |  __/ |   \ V /| \__ \ (_) | |   
|_____/ \__,_| .__/ \___|_|    \_/ |_|___/\___/|_|   
             | |                                     
             |_|                                   
                ";
        }

        public override double Bonificacao()
        {
            return Salario + 5000.00;
        }
    }
}