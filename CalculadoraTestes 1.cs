using Xunit;
using ProjetoCalculadora;

namespace Teste_xUnit
{

    /* Testes */
    public class CalculadoraTestes
    {
        [Fact]
        public void TesteSomar()
        {
            double resultado = Calculadora.Somar(2, 3);

            Assert.Equal(5, resultado);
        }


        [Fact]
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(5, 3);

            Assert.Equal(2, resultado);
        }


        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(4, 3);

            Assert.Equal(12, resultado);
        }



        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(27, 3);

            Assert.Equal(9, resultado);
        }


        [Fact]
        public void TesteDividirPorZero()
        {
            double resultado = Calculadora.Dividir(10, 0);

            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}
