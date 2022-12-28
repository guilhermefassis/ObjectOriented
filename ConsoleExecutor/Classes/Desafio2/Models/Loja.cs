using System;
using System.Collections.Generic;
using System.Linq;

namespace ClasseDesafio.Desafio2
{
    public class Loja
    {
        public string nome { get; protected set; }
        public string CNPJ { get; protected set; }
        public List<Livro> Livros { get; protected set; }
        public List<VideoGame> VideoGames { get; protected set; }

        
        public Loja()
        {
            
        }

        public Loja(string nome, string CNPJ, List<Livro> livros, List<VideoGame> videoGames)
        {
            this.nome = nome;
            this.CNPJ = CNPJ;
            this.Livros = livros;
            this.VideoGames = videoGames;
        }

        public void listaLivros()
        {
            if(Livros.Count == 0 || Livros == null)
            {
                Console.WriteLine("A loja não tem livros no estoque! ");
            }
            else
            {
                Console.WriteLine($"A loja {this.nome} possui estes livros para venda: ");
                foreach(var livro in Livros)
                {
                    Console.WriteLine(livro);
                }
                Console.WriteLine();
            }
        }
        public void ListaVideoGames()
        {
            if(VideoGames.Count == 0 || VideoGames == null)
            {
                Console.WriteLine("A loja não possui VideoGames!! ");
            }
            else
            {
                Console.WriteLine($"A loja {this.nome} possui estes Video-Games para venda: ");
                foreach(var game in VideoGames)
                {
                    Console.WriteLine(game);
                }
                Console.WriteLine();
            }
        }
        public double CalculaPatrimonio()
        {
            double totalLivros = 0;
            double totalVideoGames = 0;

            // Tive que usar dois foreach por que nao tinha como garantir listas do mesmo tamanho
            foreach (var livro in Livros)
            {
                totalLivros += (livro.Preco * livro.Quantidade);
            }
            
            foreach (var game in VideoGames)
            {
                totalVideoGames += (game.Quantidade * game.Preco);
            }
            return (totalLivros + totalVideoGames);
        }
    }
}