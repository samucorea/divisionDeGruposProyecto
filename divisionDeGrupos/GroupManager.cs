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
}