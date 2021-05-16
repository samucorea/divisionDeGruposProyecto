using NUnit.Framework;
using divisionDeGrupos;

using System.Collections.Generic;

public class GroupManagerTest
{

    public List<string> students { get; set; }
    public List<string> subjects { get; set; }

    [SetUp]
    public void setup()
    {
        students = new List<string>() { "Samuel", "Lorenzo", "Mario", "Jonathan", "Leiscar", "Emily" };
        subjects = new List<string>() { "Historia", "c#", "Julia", "Botanica", "Java" };//ss

    }
    [Test]

    public void number_Of_Groups_Higher_Than_Number_Of_Students_And_Or_Subjects()
    {
        GroupManager manager = new GroupManager();

        Assert.That(() => manager.GetRandomizedGroups(students, subjects, 100), Throws.ArgumentException.And.Message.EqualTo("El numero de grupos no puede ser mayor que la cantidad de estudiantes y/o temas."));
    }
}