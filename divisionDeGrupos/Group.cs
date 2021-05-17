using System;
public class Group
{

    public int Number { get; set; }
    public string[] Students { get; set; }
    public string[] Subjects { get; set; }


    public void Print()
    {
        Console.WriteLine("----------------------------------------");
        
        Console.WriteLine($"Grupo: {Number} Temas: {string.Join(',',Subjects)}");

        for (int i = 0; i < Students.Length; i++)
        {
            Console.WriteLine(Students[i]);
        }


        //Grupo 1   Temas:{}
        //fulano
        //mengano
    }


}
