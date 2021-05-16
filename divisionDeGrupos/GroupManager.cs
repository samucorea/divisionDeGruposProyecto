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

        return new Group[0];
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
        while (elements.Count > 0)
        {

        }

        return groups;
    }
}