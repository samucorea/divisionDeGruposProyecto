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
        int randomIndex;

        return randomIndex;
    }
}