using System;

namespace WhileLoop
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
            // katsete arv on piiramatu

            // boolean --> true/false

            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Sisesta pin");
                int userPin = Convert.ToInt32(Console.ReadLine());

                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast");
                    loopActive = false;
                }
                else
                {
                    Console.WriteLine("Vale pin! Proovi uuesti-");
                }

            }

            Console.WriteLine("Kena päeva!");


        }
    }
}
