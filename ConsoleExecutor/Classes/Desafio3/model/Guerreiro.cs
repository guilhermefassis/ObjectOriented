using System.Collections.Generic;
using System;

namespace ClasseDesafio.Desafio3
{
    public class Guerreiro : Personagem
    {

        public List<string> Habilidades { get; private set; } = new List<string>();
        public Guerreiro(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level) : base(nome, vida, mana, xp, inteligencia, forca, level)
        {

        }
        
        public void AprenderHabilidade(string habilidade)
        {
            if (habilidade != null && habilidade.Length != 0)
            {
                Habilidades.Add(habilidade);
            }
            else{
                Console.WriteLine("Habilidade invalida !");
            }
            
        }
        public int attack()
        {
            Random rand = new Random();
            int criticalAttack = rand.Next(0, 300);
            return (this.Forca * this.Level) + criticalAttack;
        }

        public override void lvlUp()
        {
            Level ++;
            // Aumento bonus medio de 30% => pois caso o numero seja decimal ele so considerará a parte inteira
            Vida += (int)(0.30 * Vida);
            Forca += (int)(0.30 * Forca);
            // Aumento de 15% nos atrinutos sem bonus de classe de personagem
            Inteligencia += (int)(0.15 * Inteligencia);
            Mana += (int)(0.15 * Mana);
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
                    $"Vida: {this.Vida}, Força: {this.Forca}\n" +
                    "\nBonus de 30% em Força e Vida ao passar de nivel! \n";
        }
    }
}