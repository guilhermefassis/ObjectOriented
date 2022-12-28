using System;

namespace ClasseDesafio.Desafio2
{
    public class VideoGame : Produto, IImposto
    {
        // Attributes
        private string marca;
        public string modelo;
        public bool isUsado;

        // Getters e Setters

        public string Marca 
        {
            get {return marca;}
            set
            {
                marca = value;
            }
        }

        public string Modelo 
        {
            get {return modelo;}
            set
            {
                modelo = value;
            }
        }

        public bool Used 
        {
            get {return isUsado;}
            set
            {
                isUsado = value;
            }
        }

        // Constructors

        public VideoGame()
        {
            
        }

        public VideoGame(string nome, double preco, int qtd, string marca, string modelo, bool isUsado)
             : base(nome, preco, qtd)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.isUsado = isUsado;
        }

        // Methods
         public double CalcularImposto()
         {
             if (isUsado == true)
             {
                 double imposto = Preco * 0.25;
                 Console.WriteLine($"Valor do imposto é de: {imposto}");
                 return imposto;
             }
             else
             {
                double imposto = Preco * 0.45;
                Console.WriteLine($"Valor do imposto é de: {imposto}");
                return imposto;
             }
         } 

        public override string ToString()
        {
            return  "======================================================================\n"+ 
                    $"Nome = {this.Nome}, Preço = {this.Preco}, Quantidade = {this.Quantidade} em estoque" +
                    "\n======================================================================\n";
        }
    }
}