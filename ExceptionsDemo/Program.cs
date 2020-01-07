using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Starship Serenity = new Starship("Serenity", "Firefly", "404-E-132-4FE274A", 9);
            Serenity.AddCrew("Captain", "Malcolm Reynolds");
            Serenity.AddCrew("FirstMate", "Zoe Washburne");
            Serenity.AddCrew("Pilot", "Hoban Washburne");
            Serenity.AddCrew("Engineer", "Kaywinnet Lee Frye");
            Serenity.AddCrew("PublicRelations", "Jayne Cobb");
            Serenity.AddCrew("Ambassador", "Inara Serra");
            Serenity.AddCrew("Shepherd", "Derrial Book");
            Serenity.AddCrew("Medic", "Simon Tam");
            Serenity.AddCrew("Crew", "River Tam");
           

            try
            {

                Serenity.AddCrew("Row", "River Tam");
            }

            catch (Startship1 g)
            {
                Console.WriteLine(g.Message);
                Console.WriteLine("Decrease the passenger");
            }

            Console.ReadLine();
        
          


        

            Serenity.Print();
            Serenity.PrintRoster();
            Console.ReadLine();
        }
    }
}
