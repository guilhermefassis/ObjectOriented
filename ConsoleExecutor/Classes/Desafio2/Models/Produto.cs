namespace ClasseDesafio.Desafio2
{
    public abstract class Produto
    {
        // Attributes
        private string nome;
        private double preco;
        private int quantidade;

        // Getters e Setters

        public string Nome 
        {
            get {return nome;}
            set
            {
                nome = value;
            }
        }

        public double Preco 
        {
            get {return preco;}
            set
            {
                preco = value;
            }
        }

        public int Quantidade 
        {
            get {return quantidade;}
            set
            {
                quantidade = value;
            }
        }


        // Constructor
        public Produto()
        {
            
        }

        public Produto(string nome, double preco, int qtd)
        {
            this.nome = nome;
            this.preco = preco;
            quantidade = qtd;
        }

    }
}