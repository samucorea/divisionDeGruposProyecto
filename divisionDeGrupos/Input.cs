using System;


public class Input
{
    public void getArgs(string[] args)
    {
        int numberOfGroups = int.TryParse(args[0], out numberOfGroups) ? numberOfGroups : 0;

        if (numberOfGroups <= 0)
        {
            throw new ArgumentException("El numero de grupos debe ser mayor a 0.");
        }
    }
}