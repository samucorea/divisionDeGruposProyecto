using System;


public class Input
{
    public void getArgs(string[] args)
    {
        if(args.Length == 3)
        {
            if (args[1] == null || args[2] == null)
            {
            throw new ArgumentNullException(null,"Debe especificar una direccion");
            }

            // int numberOfGroups = int.TryParse(args[0], out numberOfGroups) ? numberOfGroups : 0;
            int numberOfGroups;

            if (!int.TryParse(args[0], out numberOfGroups))
            {
                throw new ArgumentException("Debe de ser un numero");
            }

            if (numberOfGroups <= 0)
            {
                throw new ArgumentException("El numero de grupos debe ser mayor a 0.");
            }

            

        }
        else
        {
            throw new ArgumentException("Formato correcto: (numero de grupos) (direccion de archivo estudiantes) (direccion de archivo temas)");
        }


        
    }
}