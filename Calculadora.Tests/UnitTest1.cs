namespace Calculadora.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
            Calculadora calculator = new Calculadora();
            Assert.Throws<DivideByZeroException>(() => calculator.calcular(new Operacoes { valorA = 18, valorB = 0, operador = '/' }));
    }
}