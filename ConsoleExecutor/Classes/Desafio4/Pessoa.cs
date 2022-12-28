/* 
    Guilherme Ferreira de Assis
    São Luis - MA 19/05/2022

    Parte do projeto referente ao exercício 4 do desafio de Programação Orientada a Objetos

*/

namespace ClasseDesafio.Desafio4
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            Idade = idade;
            Nome = nome;
        }
    }
}