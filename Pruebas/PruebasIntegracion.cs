using NUnit.Framework;
using Entidad;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace Pruebas
{
    public class PruebasIntegracion
    {
        public IWebDriver driver;
        public ChromeOptions options;
        [SetUp]

        
        public void Setup()
        {
            options= new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            driver= new ChromeDriver(@"C:\Users\DELL\Downloads\MicroAlParque3erCorte-master\Pruebas\chromedriverswin_32",options);
            driver.Navigate().GoToUrl("https://localhost:5001/");

        }
        [TestCase("1234321238", "sharoll araujo", "kra 25 #34-55", 23, "fritos", 
                    "Date Gusto", "3006578990", "dategusto@gmail.com", 3, 8)]
        [Test]
        public void PruebaRegistrarRestaurante(string nit, string nombrepropietario, string direccion, int cantidadpersonal, string especialidad,
                                                string nombre, string telefono, string email, int sedes, int afuncionamiento ){
            driver.Navigate().GoToUrl("https://localhost:5001/login");
            IWebElement txtuser=driver.FindElement(By.Id("user"));
            IWebElement txtpasswword=driver.FindElement(By.Id("password"));
            IWebElement btnlogin=driver.FindElement(By.Id("btn-login"));
            IWebElement txtsearch=driver.FindElement(By.Id("search"));
            

            txtuser.SendKeys("admin");
            txtpasswword.SendKeys("admin");
            btnlogin.Click();
            txtsearch.SendKeys("Hola");
            driver.Navigate().GoToUrl("https://localhost:5001/restaurantes");

            IWebElement txtnit=driver.FindElement(By.Id("nit"));
            IWebElement txtnombrepropietario=driver.FindElement(By.Id("nombrepropietario"));
            IWebElement txtdireccion=driver.FindElement(By.Id("direccion"));
            IWebElement txtcantidadpersonal=driver.FindElement(By.Id("cantidadpersonal"));
            IWebElement txtespecialidad=driver.FindElement(By.Id("especialidad"));
            IWebElement txtnombre=driver.FindElement(By.Id("nombre"));
            IWebElement txttelefono=driver.FindElement(By.Id("telefono"));
            IWebElement txtemail=driver.FindElement(By.Id("email"));
            IWebElement txtsedes=driver.FindElement(By.Id("sedes"));
            IWebElement txtafuncionamiento=driver.FindElement(By.Id("afuncionamiento"));
            IWebElement btnregistrar=driver.FindElement(By.Id("btn-registrar"));

            txtnit.SendKeys(nit);
            txtnombrepropietario.SendKeys(nombrepropietario);
            txtdireccion.SendKeys(direccion);
            txtcantidadpersonal.SendKeys(cantidadpersonal.ToString());
            txtespecialidad.SendKeys(especialidad);
            txtnombre.SendKeys(nombre);
            txttelefono.SendKeys(telefono);
            txtemail.SendKeys(email);
            txtsedes.SendKeys(sedes.ToString());
            txtafuncionamiento.SendKeys(afuncionamiento.ToString());
            btnregistrar.Click();
        }
    }
}