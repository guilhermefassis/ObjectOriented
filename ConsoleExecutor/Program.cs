/*
    Console interativo com as classes do programa!
*/

using System;
using System.Threading;
using System.Collections.Generic;
using ClasseDesafio.Desafio1;
using ClasseDesafio.Desafio2;
using ClasseDesafio.Desafio3;
using ClasseDesafio.Desafio4;
using ClasseDesafio.Desafio7;

namespace ConsoleExecutor
{
    class Program
    {
        static void Main(string[] args)
        {

            // Definidindo desenhos e constantes do projeto
            // Desenhos
            const string I_BEMVINDO = @"

              *                  (        )  (         )   
   (        (  `                 )\ )  ( /(  )\ )   ( /(   
 ( )\  (    )\))(        (   (  (()/(  )\())(()/(   )\())  
 )((_) )\  ((_)()\  ___  )\  )\  /(_))((_)\  /(_)) ((_)\   
((_)_ ((_) (_()((_)|___|((_)((_)(_))   _((_)(_))_    ((_)  
 | _ )| __||  \/  |     \ \ / / |_ _| | \| | |   \  / _ \  
 | _ \| _| | |\/| |      \ V /   | |  | .` | | |) || (_) | 
 |___/|___||_|  |_|       \_/   |___| |_|\_| |___/  \___/  
                                                           

                                    ";
            const string I_GFT = @"
.------..------..------.
|G.--. ||F.--. ||T.--. |
| :/\: || :(): || :/\: |
| :\/: || ()() || (__) |
| '--'G|| '--'F|| '--'T|
`------'`------'`------'
";

            // Constantes
            const string M_BEMVINDO = "SEJA BEM VINDO A APRESENTAÇÃO DO TRABALHO DE ORIENTAÇÃO Á OBJETOS!!!";
            const string MENU = @"
Digite uma opção: 
1 - Acelerar
2 - Abastecer
3 - Ligar
4 - Pintar
5 - Frear
6 - Desligar  
7 - Mostrar o carro
X - Sair
                        ";
            // Cabeçario
            ImprimirCabeçario();

            Console.ReadKey();

            // Classes usadas no menu , altere parametros aqui

            // DESAFIO 1
            Veiculo carro = new Veiculo("BMW", "i8", "BRA2E19", "Preto", 1067.84f, 7, 117568.88);

            // DESAFIO 2
            Livro livro1 = new Livro("Code Clean", 99.99, 20, "Uncle BoB", "educativo", 210);
            Livro livro2 = new Livro("Desing Patterns", 109.9, 40, "Eric Freeman", "educativo", 260);
            Livro livro3 = new Livro("Harry Potter", 230, 2, "J K Rowling", "fantasia", 600);
            VideoGame game1 = new VideoGame("PS4", 1000, 1, "Sony", "Slim", true);
            VideoGame game2 = new VideoGame("PS4", 1800, 2, "Sony", "Slim", false);
            List<Livro> livros = new List<Livro>();
            List<VideoGame> VideoGames = new List<VideoGame>();
            Loja loja = new Loja("Americanas", "565486241", livros, VideoGames);

            // DESAFIO 3
            Mago mage = new Mago("Syndra", 2600, 180, 150.8f, 120, 40, 10);
            Guerreiro Kratos = new Guerreiro("Kratos", 3600, 84, 150.8f, 40, 160, 9);

            // DESAFIO 4 - 5 - 6
            List<Pessoa> pessoas = new List<Pessoa>()
            {
                new Pessoa(15, "João"),
                new Pessoa(21, "Leandro"),
                new Pessoa(17, "Paulo"),
                new Pessoa(18, "Jessica")
            };

            // DESAFIO 7
            Funcionario supervisor = new Supervisor("Guilherme", 23, 4500);
            Funcionario gerente = new Gerente("Guilherme", 23, 8500);
            Funcionario vendedor = new Vendedor("Guilherme", 23, 2500);

            while (true)
            {
                Console.Clear();
                ImprimirMenu();
                Console.WriteLine();
                Console.Write("OPÇÃO:    ");
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine(carro);
                    Console.WriteLine(MENU);

                    string answer2 = Console.ReadLine();
                    MenuDesafio1(answer2, carro);
                }
                else if (answer == "2")
                {

                    livros.Add(livro1);
                    livros.Add(livro2);
                    livros.Add(livro3);
                    Console.WriteLine(I_GFT);

                    foreach (var livro in livros)
                    {
                        ImprimirLivros(livro);
                    }

                    VideoGames.Add(game1);
                    VideoGames.Add(game2);

                    foreach (var game in VideoGames)
                    {
                        ImprimirGames(game);
                    }

                    loja.listaLivros();
                    loja.ListaVideoGames();
                    Console.WriteLine($"O patrimonio total da loja {loja.nome} tem R${loja.CalculaPatrimonio()} em patrimonio!");
                    PressioneEnter();
                }
                else if (answer == "3")
                {
                    Console.Clear();

                    Console.WriteLine(mage);
                    Console.WriteLine($"Ataque de {mage.Nome} deu {mage.attack()} de dano!!");
                    mage.lvlUp();

                    PressioneEnter();
                    Console.Clear();

                    Console.WriteLine("Novos status: \n" + mage);
                    PressioneEnter();
                    Console.Clear();


                    Console.WriteLine(Kratos);
                    Console.WriteLine($"Ataque de {Kratos.Nome} deu {Kratos.attack()} de dano!!");
                    Kratos.lvlUp();

                    PressioneEnter();
                    Console.Clear();

                    Console.WriteLine("Novos status: \n" + Kratos);
                    PressioneEnter();
                    Console.Clear();

                    Console.WriteLine("Personagens cadastrados no jogo: " + Personagem.PersonagensCriados());
                    PressioneEnter();
                    Console.Clear();

                }
                else if (answer == "4")
                {
                    Console.WriteLine("DESAFIO 4 RETORNAR PESSOAS MAIS VELHA DA LISTA: ");
                    Console.WriteLine(pessoas.RetornaPessoaMaisVelha());
                    Console.WriteLine();

                    Console.WriteLine("DESAFIO 5 EXCLUIR TODAS PESSOAS ABAIXO DE 18 ANOS DA LISTA: ");
                    pessoas.ExcluiMenores();
                    Console.WriteLine();

                    foreach (var pessoa in pessoas)
                    {
                        Console.WriteLine(pessoa.Nome + " Idade: " + pessoa.Idade);
                    }

                    Console.WriteLine();

                    Console.WriteLine("DESAFIO 6 CONSULTAR O NOME ('Jessica') E DIZER SUA IDADE: ");
                    pessoas.ConsultaNome("Jessica");

                    PressioneEnter();
                }
                else if (answer == "5")
                {
                    var valor = supervisor.Bonificacao();
                    Console.WriteLine(supervisor);
                    PressioneEnter();

                    var valor2 = gerente.Bonificacao();
                    Console.WriteLine(gerente);
                    PressioneEnter();

                    var valor3 = vendedor.Bonificacao();
                    Console.WriteLine(vendedor);
                    PressioneEnter();

                }
                else if (answer.ToLower() == "x")
                {
                    Console.WriteLine("Adeus!");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.WriteLine("Opção invalida!");
                    PressioneEnter();
                    Console.Clear();
                }

            }



            // Funções
            static void ImprimirCabeçario()
            {
                Console.Clear();
                Console.Title = "DESAFIOS GFT";

                Console.WriteLine(I_BEMVINDO);


                for (int i = 0; i < M_BEMVINDO.Length; i++)
                {
                    Console.Write(M_BEMVINDO[i]);
                    Thread.Sleep(50);
                }
                Console.WriteLine();
                Console.WriteLine("PRESSIONE ENTER ");
            }

            static void ImprimirMenu()
            {
                Console.WriteLine(I_GFT);
                Console.WriteLine("\n#################### SELECIONE UMA OPÇÃO ABAIXO ####################");
                Console.WriteLine("1 - DESAFIO 1");
                Console.WriteLine("2 - DESAFIO 2");
                Console.WriteLine("3 - DESAFIO 3");
                Console.WriteLine("4 - DESAFIO 4 - 6");
                Console.WriteLine("5 - DESAFIO 7");
                Console.WriteLine("X - Sair");

            }

            static void MenuDesafio1(string answer2, Veiculo carro)
            {
                while (answer2.ToLower() != "x")
                {
                    switch (answer2)
                    {
                        case "1":
                            try
                            {
                                carro.Acelerar();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            PressioneEnter();
                            break;
                        case "2":
                            try
                            {
                                Console.Write("Digite a quantidade de combustivel: ");
                                int combustivel = int.Parse(Console.ReadLine());
                                carro.Abastecer(combustivel);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            PressioneEnter();
                            break;
                        case "3":
                            try
                            {
                                carro.Ligar();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }

                            PressioneEnter();
                            break;
                        case "4":
                            Console.Write("Digite a cor: ");
                            string cor = Console.ReadLine();
                            carro.Pintar(cor);
                            PressioneEnter();
                            break;
                        case "5":
                            try
                            {
                                carro.Frear();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            PressioneEnter();
                            break;
                        case "6":
                            try
                            {
                                carro.Desligar();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            PressioneEnter();
                            break;
                        case "7":
                            Console.WriteLine(carro);
                            PressioneEnter();
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine(MENU);
                    answer2 = Console.ReadLine();

                }
            }

            static void PressioneEnter()
            {
                Console.WriteLine("PRESSIONE ENTER ");
                Console.ReadKey();
            }

            static void ImprimirLivros(Livro livro)
            {
                Console.WriteLine(livro);
                double imposto = livro.CalcularImposto();
                PressioneEnter();
                Console.Clear();
                Console.WriteLine(I_GFT);
            }

            static void ImprimirGames(VideoGame game)
            {
                Console.WriteLine(game);
                double imposto = game.CalcularImposto();
                PressioneEnter();
                Console.Clear();
                Console.WriteLine(I_GFT);
            }

        }
    }
}
