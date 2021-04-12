using NUnit.Framework;
using Entidad;

namespace Pruebas
{
    public class Tests
    {
        Persona persona;
        Restaurante restaurante;
        [SetUp]
        public void Setup()
        {
            persona = new Persona();
            restaurante = new Restaurante();
        }
       /* [TestCase("Anyela Giselle", "Anyela Giselle")]
         [TestCase("Sharoll Araujo", "Anyela Giselle")]
       [Test]*/
        public void Test1(string Nombres, string Nombreesperado)
        {
            persona.Nombres = Nombres;
            var Resultado = restaurante.registrarDueño(persona);
            Assert.AreEqual(Nombreesperado, Resultado.Nombres);
        }

       /*  [TestCase("1005465789", "1005465789")]
         [TestCase("1003456765", "1005465789")]
        [Test]
        public void Test2(string Nit, string Nitesperado)
        {
            restaurante.NIT = Nit;
            var Respuesta = restaurante.ValidarNit(Nit);
         Assert.AreEqual(Nitesperado, Respuesta);
        }*/
    }
}