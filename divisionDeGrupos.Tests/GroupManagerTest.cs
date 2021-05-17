using NUnit.Framework;
using divisionDeGrupos;
using System.Linq;
using System.Collections.Generic;

public class GroupManagerTest
{

    public List<string> students { get; set; }
    public List<string> subjects { get; set; }

    [SetUp]
    public void setup()
    {
        students = new List<string>() { "Samuel", "Lorenzo", "Mario", "Jonathan", "Leiscar", "Emily" };
        subjects = new List<string>() { "Historia", "c#", "Julia", "Botanica", "Java", " python" };

    }
    [Test]

    public void GroupManager_number_Of_Groups_Higher_Than_Number_Of_Students_And_Or_Subjects()
    {
        GroupManager manager = new GroupManager();

        Assert.That(() => manager.GetRandomizedGroups(students, subjects, 100), Throws.ArgumentException.And.Message.EqualTo("El numero de grupos no puede ser mayor que la cantidad de estudiantes y/o temas."));
    }
    //prueba
    [Test]

    public void GroupManager_Groups_With_No_Remanent()
    {
        GroupManager manager = new GroupManager();
        int numberOfGroups = 3;

        Group[] groups = manager.GetRandomizedGroups(students, subjects, numberOfGroups);

        Assert.That(groups.Select(group => group.Students.Length), Is.All.EqualTo(2));
        Assert.That(groups.Select(group => group.Subjects.Length), Is.All.EqualTo(2));
    }

    [Test]

    public void GroupManager_Groups_With_Remanent()
    {
        GroupManager manager = new GroupManager();
        List<string> students = new List<string>() { "Samuel", "Lorenzo", "Mario", "Jonathan", "Leiscar", "Emily", "Julian" };

        int numberOfGroups = 4, groupsWithTwoStudents = 0, groupsWithOneStudent = 0, groupsWithOneSubject = 0, groupsWithTwoSubjects = 0;
        // 7 / 4 3 grupo de 2 y 1 grupo de 1
        // 6 / 4 2 grupos de 1 y 2 grupos de 2


        Group[] groups = manager.GetRandomizedGroups(students, subjects, numberOfGroups);


        foreach (var group in groups)
        {
            if (group.Students.Length == 1)
            {
                groupsWithOneStudent++;
            }
            else if (group.Students.Length == 2)
            {
                groupsWithTwoStudents++;
            }

            if (group.Subjects.Length == 1)
            {
                groupsWithOneSubject++;
            }
            else if (group.Subjects.Length == 2)
            {
                groupsWithTwoSubjects++;
            }
        }
        //ssds
        Assert.AreEqual(3, groupsWithTwoStudents);
        Assert.AreEqual(1, groupsWithOneStudent);
        Assert.AreEqual(2, groupsWithTwoSubjects);
        Assert.AreEqual(2, groupsWithOneSubject);


    }
}