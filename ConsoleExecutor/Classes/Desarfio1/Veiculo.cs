/**
    Creted by Guilherme de Assis
    18/05/2022 - São Luís-MA
**/

using System;

namespace ClasseDesafio.Desafio1
{
    public class Veiculo
    {
        // Auto Properties
        public string Marca { get; private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public string Cor { get; private set; }
        public float Km { get; private set; }
        public bool IsLigado { get; private set; } = false;
        public int LitrosCombustivel { get; private set; }
        public int Velocidade { get; private set; } = 0;
        public double Preco { get; private set; }


        // Constructor
        public Veiculo(string Marca, string Modelo, string Placa, string Cor, float Km,
                int LitrosCombustivel, double Preco)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Placa = Placa;
            this.Cor = Cor;
            this.Km = Km;
            this.LitrosCombustivel = LitrosCombustivel;
            this.Preco = Preco;
        }

        // Methods

        public void Acelerar()
        {
            if (IsLigado == true)
            {
                Velocidade += 20;
                Console.WriteLine($"Velocidade: {Velocidade}km/h");
            }
            else
            {
                throw new Exception("Veiculo Desligado");
            }

        }

        public void Abastecer(int combustivel)
        {
            if (LitrosCombustivel <= 60 && (LitrosCombustivel + combustivel) <= 60)
            {
                LitrosCombustivel += combustivel;
                Console.WriteLine($"Quantidade de combustivel: {LitrosCombustivel}");
            }
            else if ((LitrosCombustivel + combustivel) >= 60 && LitrosCombustivel < 60)
            {
                var resto = LitrosCombustivel + combustivel - 60;
                var possivel = combustivel - resto;
                LitrosCombustivel += possivel;
                throw new Exception($"Foi possivel abastecer somente {possivel} litros, Quantidade de combustivel: {LitrosCombustivel}");
            }
            else
            {
                throw new Exception("Tanque Cheio! Nao e possivel abastecer! ");
            }
        }

        public void Ligar()
        {
            if (IsLigado == false)
            {
                IsLigado = true;
                Console.WriteLine("O carro esta ligado!");
            }
            else
            {
                throw new Exception("O veiculo já está ligado");
            }
        }

        public void Pintar(string cor)
        {
            Cor = cor;
        }

        public void Frear()
        {
            if (Velocidade > 0)
            {
                Velocidade -= 20;
                Console.WriteLine($"Sua velocidade é {Velocidade}km/h");
            }
            else if (Velocidade == 0)
                throw new Exception("O veiculo esta parado!");
        }
        public void Desligar()
        {
            if (Velocidade > 0)
            {
                throw new Exception("Voce precisa parar o carro para deliga-lo!!");
            }
            else if (IsLigado == false)
            {
                throw new Exception("O carro ja esta desligado!");
            }
            else
            {
                IsLigado = false;
                Console.WriteLine("O carro foi desligado!");
            }
        }

        // ToString
        public override string ToString()
        {
            return $" Marca = {this.Marca}\n Modelo: {this.Modelo}\n Placa: {this.Placa}\n Cor: {this.Cor}\n Combustivel" +
                    $": {this.LitrosCombustivel}\n KM: {this.Km}\n Velocidade: {this.Velocidade}km/h\n Preco:" +
                    $"{this.Preco}\n Ligado: {this.IsLigado}";
        }
    }
}