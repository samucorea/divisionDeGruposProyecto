using System;
using System.IO;
using System.Collections.Generic;


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

                string pathStudents = args[1];
                string pathSubjects = args[2];
                string[] students;
                string[] subjects;

                try{
                  students = File.ReadAllLines(pathStudents);
                  subjects = File.ReadAllLines(pathSubjects);

                }
                catch(Exception){
                    throw new FileNotFoundException("No se encontro el archivo (estudiante) o (temas)");
                }

                List<string> studentsList = new List<string>(students);
                List<string> subjectsList = new List<string>(subjects);

                GroupManager manager = new GroupManager();

                Group[] arrangeGroups = manager.GetRandomizedGroups(studentsList,subjectsList, numberOfGroups);



        }
        else
        {
            throw new ArgumentException("Formato correcto: (numero de grupos) (direccion de archivo estudiantes) (direccion de archivo temas)");
        }


        
    }
}