using System;
namespace Gennemsnitsberegner;

class Program
{
    static void TalInput ()
    {
        do 
        {
            Console.WriteLine("Indtast tal: ");
            string TalIndtast = Console.ReadLine();
        } while (true);
              
    }
    static void Main(string[] args)
    {
        TalInput();
    }

}