using System;


public class Input
{
    public void getArgs(string[] args)
    {
        if (args[1] == null || args[2] == null)
        {
            throw new ArgumentNullException(null,"Debe especificar una direccion");
        }

        int numberOfGroups = int.TryParse(args[0], out numberOfGroups) ? numberOfGroups : 0;
        if (int.TryParse(args[0], out numberOfGroups))
        {

        }

        if (numberOfGroups <= 0)
        {
            throw new ArgumentException("El numero de grupos debe ser mayor a 0.");
        }
    }
}