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
            double resultado = Calculadora.Somar(5, 3);

            Assert.Equal(8, resultado);
        }


        [Fact]
        public void TesteSubtrair()
        {
            double resultado = Calculadora.Subtrair(15, 5);

            Assert.Equal(10, resultado);
        }


        [Fact]
        public void TesteMultiplicar()
        {
            double resultado = Calculadora.Multiplicar(5, 8);

            Assert.Equal(40, resultado);
        }



        [Fact]
        public void TesteDividir()
        {
            double resultado = Calculadora.Dividir(30, 3);

            Assert.Equal(10, resultado);
        }


        [Fact]
        public void TesteDividirPorZero()
        {
            double resultado = Calculadora.Dividir(10, 0);

            Assert.Equal(double.PositiveInfinity, resultado);
        }
    }
}
