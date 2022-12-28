using System;

namespace ClasseDesafio.Desafio2
{
    public class Livro : Produto, IImposto
    {
        // Attributes
        private string autor;
        private string tema;
        private int qtdPaginas;

        // Getters e Setters

        public string Autor 
        {
            get {return autor;}
            set
            {
                autor = value;
            }
        }

        public string Tema 
        {
            get {return tema;}
            set
            {
                tema = value;
            }
        }

        public int QtdPag 
        {
            get {return qtdPaginas;}
            set
            {
                qtdPaginas = value;
            }
        }

        // Constructor
        public Livro() : base()
        {
            
        }
        public Livro(string nome, double preco, int qtd, string autor, string tema, int qtdPaginas)
             : base(nome, preco, qtd)
        {
            this.autor = autor;
            this.tema = tema;
            this.qtdPaginas = qtdPaginas;
        }

        //Methods
        public double CalcularImposto()
        {
            if(tema.ToLower() == "educativo")
            {
                Console.WriteLine("Não é aplicado imposto para livros educativos!");
                return 0;
            }
            var imposto = Preco * 0.1;
            Console.WriteLine($"Valor do imposto é de: {imposto}");
            return (imposto);
        }

        // ToString
        public override string ToString()
        {
            return  "======================================================================\n" +
                    $"Titulo = {this.Nome}, " + 
                    $"Preco = {this.Preco}," + 
                    $" Quantidade = {this.Quantidade} em estoque" +
                    "\n======================================================================\n";
        }
    }
}