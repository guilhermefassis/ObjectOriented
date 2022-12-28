using System;
using System.Collections.Generic;

namespace ClasseDesafio.Desafio3
{
    public class Mago : Personagem
    {
        public List<string> Magias { get; private set; } = new List<string>();

        public Mago (string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) 
                : base(nome, vida, mana, xp, inteligencia, forca, level)
        {

        }

        public void AprenderMagia(string magia)
        {
            if (magia != null && magia.Length != 0)
            {
                Magias.Add(magia);
            }
            else{
                Console.WriteLine("Magia invalida!");
            }
            
        }
        public int attack()
        {
            Random aleatorio = new Random();
            int criticalAttack =  aleatorio.Next(0, 300);
            return (this.Inteligencia * this.Level) + criticalAttack;
        }


        public override void lvlUp()
        {
            Level ++;
            // Aumento bonus medio de 30% => pois caso o numero seja decimal ele so considerará a parte inteira
            Inteligencia += (int)(0.3 * Inteligencia);
            Mana += (int)(0.3 * Mana);
            // Aumento de 15% nos atrinutos sem bonus de classe de personagem
            Vida += (int)(0.15 * Vida);
            Forca += (int)(0.15 * Forca);
            Console.WriteLine(@"
            ,--,                                      ,--,                                       ,---,  
            ,---.'|                                   ,---.'|                         ,-.----.   ,`--.' |  
            |   | :       ,---,.                ,---,.|   | :                         \    /  \  |   :  :  
            :   : |     ,'  .' |       ,---.  ,'  .' |:   : |                    ,--, |   :    \ '   '  ;  
            |   ' :   ,---.'   |      /__./|,---.'   ||   ' :                  ,'_ /| |   |  .\ :|   |  |  
            ;   ; '   |   |   .' ,---.;  ; ||   |   .';   ; '             .--. |  | : .   :  |: |'   :  ;  
            '   | |__ :   :  |-,/___/ \  | |:   :  |-,'   | |__         ,'_ /| :  . | |   |   \ :|   |  '  
            |   | :.'|:   |  ;/|\   ;  \ ' |:   |  ;/||   | :.'|        |  ' | |  . . |   : .   /'   :  |  
            '   :    ;|   :   .' \   \  \: ||   :   .''   :    ;        |  | ' |  | | ;   | |`-' ;   |  ;  
            |   |  ./ |   |  |-,  ;   \  ' .|   |  |-,|   |  ./         :  | | :  ' ; |   | ;    `---'. |  
            ;   : ;   '   :  ;/|   \   \   ''   :  ;/|;   : ;           |  ; ' |  | ' :   ' |     `--..`;  
            |   ,/    |   |    \    \   `  ;|   |    \|   ,/            :  | : ;  ; | :   : :    .--,_     
            '---'     |   :   .'     :   \ ||   :   .''---'             '  :  `--'   \|   | :    |    |`.  
                    |   | ,'        '---  |   | ,'                    :  ,      .-./`---'.|    `-- -`, ; 
                    `----'                `----'                       `--`----'      `---`      '---`
            ");

        }

        public override string ToString()
        {
            return  $"Nome: {this.Nome}, Level: {this.Level}\n" + 
                    "==========================================\n" +
                    $"Inteligencia : {this.Inteligencia}, Mana: {this.Mana}\n" +
                    $"Vida: {this.Vida}, Força: {this.Forca}" +
                    "\nBonus de 30% em Inteligencia e Mana ao passar de nivel! \n";
        }
    }
}