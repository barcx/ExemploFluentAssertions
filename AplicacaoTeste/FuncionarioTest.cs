using Aplicacao;
using Xunit;
using FluentAssertions;

namespace AplicacaoTeste
{
    public class FuncionarioTest
    {
        [Fact]
        public void Apresentar_FuncionarioValido_ExibeMensagemDeApresentacaoDoFuncionario()
        {
            // Arrange
            var sut = new Funcionario("Pel�", "Jogador", 100);
            var esperado = "Oi! Meu nome � Pel� e trabalho como Jogador.";

            // Act
            var resultado = sut.Apresentar();

            // Assert XUnit
            //Assert.Equal(esperado, resultado);

            // Assert Fluent Assertions
            esperado.Should().Be(resultado);
        }

        [Fact]
        public void ConcederAumentoSalarial_AumentoPositivo_AumentaSalario()
        {
            // Arrange
            var salario = 100;
            var aumento = 10;
            var sut = new Funcionario("Pel�", "Jogador", salario);
            var esperado = 110m;

            // Act
            sut.ConcederAumentoSalarial(aumento);
            var resultado = sut.Salario;

            // Assert XUnit
            // Assert.Equal(esperado, resultado);

            // Assert Fluent Assertions
            esperado.Should().Be(resultado);
        }

        [Fact]
        public void ConcederAumentoSalarial_AumentoNegativo_NaoMudaSalario()
        {
            // Arrange
            var salario = 100m;
            var aumento = -10;
            var sut = new Funcionario("Pel�", "Jogador", salario);

            // Act
            sut.ConcederAumentoSalarial(aumento);
            var resultado = sut.Salario;

            // Assert XUnit
            //Assert.Equal(salario, resultado);

            // Assert Fluent Assertions
            salario.Should().Be(resultado);
        }
    }
}
