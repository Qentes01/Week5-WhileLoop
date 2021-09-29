using System;

namespace PinValidationThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada pin koodi
            //programm võrdleb sisestatud pin koodi arvuga 1234
            //kui sisestatud pin kood on 1234
            //programm kuvab konsoolis "tere tulemast!"
            //kui sisestatud pin kood on vale, programm kuvab konsoolis
            //"Vale pin.Proovi uuesi"
            // Kasutajal kolm katset

            int i = 0;

            while (i < 3) 
            {
                Console.WriteLine("Sisesta pin");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    i = 3; //või break;
                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"vale pin. {3 - 1} kastset on jäänud.");
                }
                Console.WriteLine("Kena päeva!");
            }

               
            
        }
    }
}
