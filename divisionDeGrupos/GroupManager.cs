using System;
using System.Collections.Generic;
public class GroupManager

{
    public Group[] GetRandomizedGroups(List<string> students, List<string> subjects, int numberOfGroups)
    {
        if (numberOfGroups > students.Count || numberOfGroups > subjects.Count)//ss
        {
            throw new ArgumentException("El numero de grupos no puede ser mayor que la cantidad de estudiantes y/o temas.");
        }
        List<string>[] arrangedStudents = RandomizeGroups(students, numberOfGroups);
        List<string>[] arrangedSubjects = RandomizeGroups(subjects, numberOfGroups);

        Group[] groups = new Group[numberOfGroups];

        for (int i = 0; i < groups.Length; i++)
        {
            groups[i] = new Group();
            groups[i].Number = i + 1;
            groups[i].Students = arrangedStudents[i].ToArray();
            groups[i].Subjects = arrangedSubjects[i].ToArray();
        }

        return groups;
    }
    //hds

    private List<string>[] RandomizeGroups(List<string> elements, int numberOfGroups)
    {
        int maxNumberOfGroupsMember = elements.Count / numberOfGroups;

        List<string>[] groups = new List<string>[numberOfGroups];
        for (int i = 0; i < groups.Length; i++)
        {
            groups[i] = new List<string>();
        }

        List<int> exceptions = new List<int>();


        while (elements.Count > 0)
        {
            int elementIndex = GetRandom_withException(0, elements.Count, null);
            string element = elements[elementIndex];
            elements.RemoveAt(elementIndex);

            int randomGroup = GetRandom_withException(0, numberOfGroups, exceptions);
            groups[randomGroup].Add(element);

            if (groups[randomGroup].Count == maxNumberOfGroupsMember)
            {
                exceptions.Add(randomGroup);

                if (exceptions.Count == numberOfGroups)
                {
                    exceptions.Clear();
                    maxNumberOfGroupsMember++;
                }
            }

            //generar un numero random (limite de el lenght de la lista estudiantes) y guardar ese elemento en un string
            // remover estudiante de la lista original

            //crear lista de grupos que estaran llenos (hacer la excepcion de ese elemento)
            //generar numero random para agregarlo al grupo (que no este en la lista de excepciones, limite = numero de grupos)

            //se añade ese elemento a la lista de grupos (add)

            //condicion si count del grupo sea igual a (maxNumberOfGroupsMember) --> ponlo en la lista de excepciones

            //condicion si se llenan todos los grupos --> numero de elementos de lista excepcion == a la lista de grupos

            //en caso de que hallan remanente se limpia la lista de excepciones y numero de miembros nax del grupo se le agrega uno (++)



        }

        return groups;
    }

    private int GetRandom_withException(int inicio, int final, List<int> exceptions)
    {
        int randomIndex = 0;
        Random random = new Random();

        if (exceptions is null || exceptions.Count == 0)
        {
            return random.Next(inicio, final);
        }
        else
        {
            do
            {
                randomIndex = random.Next(inicio, final);

            }
            while (exceptions.Contains(randomIndex));
        }

        return randomIndex;
    }
}