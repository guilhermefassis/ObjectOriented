using Xunit;
using System;
using ClasseDesafio.Desafio1;

namespace POO.Test
{
    public class Desafio1Test : IDisposable
    {

        private Veiculo _veiculo;
        public Desafio1Test()
        {
            _veiculo = new Veiculo("BMW", "i8", "BRA2E19", "Preto", 1067.84f, 1, 117568.88);
        }

        #region "AAA"

        [Fact(DisplayName = "Teste de 3 passos para veiculo ligar")]
        [Trait("category", "veiculoligar")]
        public void TestaVeiculoLigar()
        {

            // Arrange 
            var expected = true;
            // Act
            _veiculo.Ligar();
            // Assert
            Assert.Equal(expected, _veiculo.IsLigado);

        }

        [Fact(DisplayName = "Teste de 3 passos para veiculo ligar Exception")]
        [Trait("category", "veiculoligar")]
        public void TestaVeiculoLigarSeJaTiverLigadoException()
        {
            // Arrange 
            _veiculo.Ligar();
            string mensagem = "O veiculo já está ligado";
            // Act and Assert
            var ex = Assert.Throws<Exception>(() => _veiculo.Ligar());
            Assert.Equal(mensagem, ex.Message);
        }

        [Fact(DisplayName = "Teste de 3 passos para veiculo Acelerar")]
        [Trait("category", "veiculoAcelerar")]
        public void TestaVeiculoAcelerar()
        {
            // Arrange
            _veiculo.Ligar();
            int esperado = 20;
            // Act
            _veiculo.Acelerar();
            // Assert
            Assert.Equal(esperado, _veiculo.Velocidade);
        }


        [Fact(DisplayName = "Teste de 3 passos para veiculo Acelerar Exception")]
        [Trait("category", "veiculoAcelerar")]
        public void TestaVeiculoAcelerarException()
        {
            // Arrange 
            string mensagem = "Veiculo Desligado";
            // Act
            var ex = Assert.Throws<Exception>(() => _veiculo.Acelerar());
            // Assert
            Assert.Equal(mensagem, ex.Message);
        }



        [Fact(DisplayName = "Testa pintar veiculo")]
        [Trait("category", "veiculoPintar")]
        public void TestaPintarVeiculo()
        {
            // Arrange
            string cor = "Pink";
            // Act
            _veiculo.Pintar(cor);
            // Assert
            Assert.Equal(cor, _veiculo.Cor);
        }

        [Fact(DisplayName = "Teste de 3 passos para veiculo desligar")]
        [Trait("category", "veiculoDesligar")]
        public void TestaVeiculolDesigar()
        {

            // Arrange 
            var expected = false;
            // Act
            _veiculo.Ligar();
            _veiculo.Desligar();
            // Assert
            Assert.Equal(expected, _veiculo.IsLigado);

        }

        [Fact(DisplayName = "Teste de 3 passos para veiculo desligar Exception")]
        [Trait("category", "veiculoDesligar")]
        public void TestaVeiculolDesigarException()
        {

            // Arrange 
            var message = "O carro ja esta desligado!";
            var message1 = "Voce precisa parar o carro para deliga-lo!!";
            // Act
            var ex = Assert.Throws<Exception>(() => _veiculo.Desligar());
            // Assert
            if (_veiculo.Velocidade == 0)
                Assert.Equal(message, ex.Message);
            else
                Assert.Equal(message1, ex.Message);
        }

        #endregion

        #region "SEVT"

        [Fact(DisplayName = "Teste de 4 passos para veiculo Freiar")]
        [Trait("category", "veiculoFreiar")]
        public void TestaVeiculoFreiar()
        {
            // Arrange 
            int esperado = 20;
            // Act
            _veiculo.Ligar();
            _veiculo.Acelerar();
            _veiculo.Acelerar();
            _veiculo.Frear();
            // Assert
            Assert.Equal(esperado, _veiculo.Velocidade);
            // Teardown
            this.Dispose();
        }

        [Fact(DisplayName = "Teste de 4 passos para veiculo Freiar Exception")]
        [Trait("category", "veiculoFreiar")]
        public void TestaVeiculoFreiarrException()
        {
            // Arrange 
            string mensagem = "O veiculo esta parado!";
            // Act
            var ex = Assert.Throws<Exception>(() => _veiculo.Frear());
            // Assert
            Assert.Equal(mensagem, ex.Message);
            // Teardown
            this.Dispose();
        }

        [Theory(DisplayName = "Testa logica do abastecimento em 4 passos")]
        [Trait("Category", "Abastecer")]
        [InlineData(59, 60)]
        [InlineData(20, 21)]
        [InlineData(35, 36)]
        public void TestaLogicaAbastecer(int litros, int esperado)
        {
            // Arrange
            // Act 
            _veiculo.Abastecer(litros);
            // Assert
            Assert.Equal(esperado, _veiculo.LitrosCombustivel);
            // Teardown
            this.Dispose();
        }

        [Theory(DisplayName = "Logica abastecer Exception")]
        [Trait("Category", "AbastecerException")]
        [InlineData(66, 60)]
        [InlineData(68, 60)]
        [InlineData(69, 60)]
        public void TestaLogicaAbastecerException(int litros, int esperado)
        {
            // Arrange
            var resto = litros - (_veiculo.LitrosCombustivel + litros - 60);
            string message = $"Foi possivel abastecer somente {resto} litros, Quantidade de combustivel: {esperado}";
            // Act 
            var ex = Assert.Throws<Exception>(() => _veiculo.Abastecer(litros));
            // Assert
            Assert.Contains(message, ex.Message);
            Assert.Equal(esperado, _veiculo.LitrosCombustivel);
            // Teardown
            this.Dispose();
        }


        #endregion

        public void Dispose()
        {
            _veiculo = null;
        }
    }
}