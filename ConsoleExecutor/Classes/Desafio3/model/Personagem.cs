namespace ClasseDesafio.Desafio3
{
    public class Personagem
    {
        private static int TotalDePersonagens = 0;

        public string Nome { get; protected set; }
        public int Vida { get; protected set; }
        public int Mana { get; protected set; }
        public float Xp { get; protected set; }
        public int Inteligencia { get; protected set; }
        public int Forca { get; protected set; }
        public int Level { get; protected set; }


        public Personagem(string nome, int vida, int mana, float xp, int inteligencia, int forca, int level)
        {
            Nome = nome;
            Vida = vida;
            Mana = mana;
            Xp = xp;
            Inteligencia = inteligencia;
            Forca = forca;
            Level = level;
            Personagem.TotalDePersonagens ++;
        }

        public static int PersonagensCriados()
        {
            return Personagem.TotalDePersonagens;
        } 


        virtual public void lvlUp()
        {
            Level += 1;
        }

    }
}