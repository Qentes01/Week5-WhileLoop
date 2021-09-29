using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada kasutajatunnust;
            //programm küsib kasutajal sisestada parool;
            //programm kontrollib, kas mõlemad, nii kasutajatunus
            //kui ka parool on õiged;
            //kui mõlemad,kasutajatunnus ja parool on õiged
            //programm kuvab konsoolis "tere tulemast"
            //kui kasutajatunnus või parool on vale, siis
            //proigramm kuvab "sisselogimine ebaõnnestus,proovi uuesti"
            //kt:admin, pr admin1234
            //kasutjal on 3 katset
            int i = 0
                while (1 < 3)
            Console.WriteLine("Sisestage kasutajatunnus");
            string userName = Console.ReadLine();
            Console.WriteLine("Sisestage parool");
            string userpassword = Console.ReadLine();
            if (userName == "admin" && userpassword == "admin1234")
            {
                Console.WriteLine("Tere tulemast");
                break;
            }
            else

                i = i + 1;
            Console.WriteLine($"Vale Pin. {3 - i}katset on jäänud");
            Console.WriteLine("Kena päeva");
    }   }
           
}
