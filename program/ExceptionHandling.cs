using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prosjek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // inicijalizacija varijabli
            int brojOcjena = 0, ocjena = 0;
            double prosjek = 0.0, zbrojOcjena = 0;

            // zaglavlje aplikacije
            Console.WriteLine("##########################");
            Console.WriteLine("# Izračunavanje prosjeka #");
            Console.WriteLine("##########################");
            Console.WriteLine("Za kraj unesi nulu");
            
            // unos broja ocjena
            /*Console.WriteLine("Unesi broj ocjena");
            brojOcjena = Convert.ToInt32(Console.ReadLine());*/

            // unos ocjena
            try
            {
                do
                {
                    Console.WriteLine("Unesi ocjene");
                    start:
                    ocjena = Convert.ToInt32(Console.ReadLine());

                    if (ocjena <= 5 && ocjena > 1)
                    {

                        zbrojOcjena += ocjena;
                        brojOcjena++ ;      //brojač 

                    }
                    // obavjest da pada razred ako ima 1
                    else if (ocjena == 1)
                    {
                        Console.WriteLine("Nisi prošao razred.");
                        break;

                    }
                    // povratak na unos ako je ocjena veća od 5
                    else
                    {
                        Console.WriteLine("Krivi upis, pokušaj ponovo");
                        goto start;
                    }
                    

                }while(ocjena != 0);

            }
            catch(Exception greska)
            {
                Console.WriteLine("Neispravan unos, pokušajte ponovo.");
                Console.WriteLine("Opis greške: " + greska.Message);

            }



            //ispis prosjeka ako nema 1
            if(ocjena != 1)
            {
                prosjek = zbrojOcjena / (brojOcjena-1);
                Console.WriteLine("Prosjek ocjena je " + prosjek + ".");

            }

            Console.ReadKey();

        }

    }

}