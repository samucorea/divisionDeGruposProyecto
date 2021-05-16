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
        public void Input_getArgs_FileDirectionStudents_IsNull()
        {
            Input input = new Input();
            string[] args = { "1", null, "temas.txt" };
            Assert.That(() => input.getArgs(args), Throws.ArgumentNullException.And.Message.EqualTo("Debe especificar una direccion"));
        }

        [Test]
        public void Input_getArgs_FileDirectionSubjects_IsNull()
        {
            Input input = new Input();
            string[] args = { "1", "estudiantes.txt", null};
            Assert.That(() => input.getArgs(args), Throws.ArgumentNullException.And.Message.EqualTo("Debe especificar una direccion"));
        }

        [Test]
        public void Input_getArgs_numberOfGroups_IsNotANumber()
        {
            Input input = new Input();
            string[] args = { "Hola", "estudiantes.txt", "temas.txt" };
            Assert.That(() => input.getArgs(args), Throws.ArgumentException.And.Message.EqualTo("Debe de ser un numero"));
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