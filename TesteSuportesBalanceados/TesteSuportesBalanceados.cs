using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuportesBalanceados;

namespace Testes
{
    [TestClass]
    public class TesteSuportesBalanceados
    {
        [TestMethod]
        public void ColchetesValidos()
        {
            string texto = "(){}[]({[]})";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes correspondentes");
        }

        [TestMethod]
        public void ColchetesInvalidosComQuantidadeImpar()
        {
            string texto = "(){}[]({[})";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes não correspondentes");
        }

        [TestMethod]
        public void ColchetesInvalidosComQuantidadePar()
        {
            string texto = "()}[]({[})";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes não correspondentes");
        }

        [TestMethod]
        public void ColchetesValidosComTexto()
        {
            string texto = "T(e){s}t[]({[]})e";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes correspondentes");
        }

        [TestMethod]
        public void ColchetesInvalidosComQuantidadeImparComTexto()
        {
            string texto = "T()e{}s[](t{[})e";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes não correspondentes");
        }

        [TestMethod]
        public void ColchetesInvalidosComQuantidadeParComTexto()
        {
            string texto = "(t)}[es]({t[e})";
            Assert.IsTrue(Colchete.ValidaColchetes(texto) == "Colchetes não correspondentes");
        }
    }
}
