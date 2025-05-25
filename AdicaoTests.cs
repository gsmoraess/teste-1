using Xunit;

namespace Adicao.Tests
{
    public class AdicaoTests
    {
        [Fact]
        public void Somar_DeveRetornarSomaDeDoisNumeros()
        {
            
            int valor1 = 5;
            int valor2 = 5;
            int resultado = Adicao.Somar(valor1, valor2);

            Assert.Equal(10, resultado);
        }
    }
}
