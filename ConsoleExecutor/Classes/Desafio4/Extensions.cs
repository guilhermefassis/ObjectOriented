/*
    Guilherme Ferreira de Assis
    19/05/2022 - São Luís - MA

    Foi criado metodos de extensão para resolver os exercicios 4, 5 e 6 dentro de um Reposiorio só
    Os metodos foram escritos para sanar o problema apresentado nos exercicios! 
*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ClasseDesafio.Desafio4
{
    public static class Extensions
    {

        // Exercicio 4
        public static string RetornaPessoaMaisVelha(this List<Pessoa> pessoas)
        {
            var PessoasOrdenadas = pessoas.OrderByDescending(p => p.Idade).ToList();
            var pessoaMaisVelha = PessoasOrdenadas[0];
            return $"Nome: {pessoaMaisVelha.Nome}, Idade: {pessoaMaisVelha.Idade}";
        }

        // Exercicio 5
        public static void ExcluiMenores(this List<Pessoa> pessoas)
        {
            var quantidadeDePessoas = pessoas.Count;
            pessoas.RemoveAll(p => p.Idade < 18);
            Console.WriteLine($"Quantidade total de passoas na lista: {quantidadeDePessoas} | Quantidade atual sem menores de idade {pessoas.Count}");
        }
        // Exercicio 6
        public static void ConsultaNome(this List<Pessoa> pessoas, string pessoaNaLista)
        {
            var pessoaBuscada = pessoas.Find(p => p.Nome.ToLower() == pessoaNaLista.ToLower());
            Console.WriteLine($"A pessoa de nome {pessoaNaLista} foi encontrada e sua idade é {pessoaBuscada.Idade} !!");
        }
    }
}