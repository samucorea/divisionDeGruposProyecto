using NUnit.Framework;
using divisionDeGrupos;
namespace divisionDeGrupos.Tests
{
    public class InputTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Input_getArgs_numberOfGroups_is_Zero_Or_Less_Than_Zero()
        {
            Input input = new Input();

            string[] args = { "-1", "estudiantes.txt", "temas.txt" };

            Assert.That(() => input.getArgs(args), Throws.ArgumentException.And.Message.EqualTo("El numero de grupos debe ser mayor a 0."));
        }
    }
}