using Xunit;
using Moq;
using AppFrete;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //arrange
            //instanciando o mock com a interface
            Mock<ICorreioService> mock = new Mock<ICorreioService>();

            //configurando o mock
            mock.Setup(m => m.CalculaFrete()).Returns(7.52);

            //chamando o construtor pra preencher o objeto frete com os dados do mock
            Frete frete = new Frete(mock.Object)
            {
                cep = 21857010,
                peso = 5
            };

            //act
            //chamando o metodo que vai calcular o frete
            double result = frete.calcularFrete();

            //assert
            //verificando se tá dando certo
            Assert.Equal(7.52,result);
        }
    }
}