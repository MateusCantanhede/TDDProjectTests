using TDDProjectTests;

namespace TDDProjectTestsUnitTests
{
    public class CalculadoraUnitTest
    {
        private Calculadora constroiClasse()
        {
            return new Calculadora(DateTime.UtcNow.ToString(),new List<string>());
        }
        [Theory]
        [InlineData(1, 2, 22)]
        [InlineData(4, 5, 12)]
        public void Test_Soma_Com_Falha(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.somar(val1, val2);
            Assert.NotStrictEqual(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Test_Soma_Com_Sucesso(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.somar(val1, val2);
            Assert.Equal(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, 4)]
        [InlineData(4, 5, 4)]
        public void Test_Subtracao_Com_Falha(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.subtrair(val1, val2);
            Assert.NotStrictEqual(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(4, 5, -1)]
        public void Test_Subtracao_Com_Sucesso(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.subtrair(val1, val2);
            Assert.Equal(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(4, 5, 0)]
        public void Test_Multiplicacao_Com_Falha(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.multiplicar(val1, val2);
            Assert.NotStrictEqual(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void Test_Multiplicacao_Com_Sucesso(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.multiplicar(val1, val2);
            Assert.Equal(result, resultado);
        }
        [Fact]
        public void Test_Divizao_Por_Zero_Com_Falha()
        {
            var calc = constroiClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void Test_Divizao_Com_Falha(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.dividir(val1, val2);
            Assert.NotStrictEqual(result, resultado);
        }
        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(4, 5, 0)]
        public void Test_Divizao_Com_Sucesso(int val1, int val2, int result)
        {
            var calc = constroiClasse();
            int resultado = calc.dividir(val1, val2);
            Assert.Equal(result, resultado);
        }
        [Fact]
        public void Test_Historico_Falha()
        {
            var calc = constroiClasse();
            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);
            var lista = calc.Pegarhistorico();
            Assert.NotEqual(2, lista.Count);
        }
        [Fact]
        public void Test_Historico_Sucesso()
        {
            var calc = constroiClasse();
            calc.somar(1, 2);
            calc.somar(2, 8);
            calc.somar(3, 7);
            calc.somar(4, 1);
            var lista = calc.Pegarhistorico();
            Assert.NotEmpty(lista);
            Assert.Equal(4, lista.Count);
        }
    }
}