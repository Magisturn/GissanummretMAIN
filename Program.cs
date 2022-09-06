namespace Gissanummret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gissaNr = 0;
            int antalGissningar = 6;
            int lätt = 11;
            int mellan = 22;
            int svår = 33;

            //slumptals generator
            Random slumpTalsGen = new Random();

            // Skriv välkomstmeddelande


            string menyVal = "";

            while (menyVal != "3")
            {
                // Skriv ut huvudmenyn
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1. Spela Gissa nummret ");
                Console.WriteLine("2. Spelets regler");
                Console.WriteLine("3. Avsluta programmet");
                menyVal = Console.ReadLine();

                switch (menyVal)
                {

                    case "1":
                        string svårHetsGrad = "";
                        while (svårHetsGrad != "3")
                        {
                            Console.WriteLine("Välj svårhetsgrad");
                            Console.WriteLine("1. Lätt");
                            Console.WriteLine("2. Mellan");
                            Console.WriteLine("3. Svårt");
                            svårHetsGrad = Console.ReadLine();
                            switch (svårHetsGrad)
                            {
                                case "1":
                                    Console.WriteLine("Skriv ett nummer mellan 1-10");


                                    int slumpLätt = slumpTalsGen.Next(1, lätt);


                                    for (int i = 1; i < antalGissningar; i++)
                                    {

                                        gissaNr = Convert.ToInt32(Console.ReadLine());

                                        if (gissaNr == slumpLätt)
                                        {
                                            Console.WriteLine("Du gissade rätt!");
                                            Console.WriteLine("Antal försök: " + i);
                                            break;
                                        }

                                        else if (gissaNr > slumpLätt)
                                        {
                                            Console.WriteLine("Nummret är lägre");
                                        }
                                        else if (gissaNr < slumpLätt)
                                        {
                                            Console.WriteLine("Nummret är högre");
                                        }

                                    }
                                    if (gissaNr == antalGissningar)
                                    {
                                        Console.WriteLine("Dina försök är slut");
                                        Console.ReadKey();

                                    }
                                    Console.WriteLine("Det rätta nummret var: " + slumpLätt);
                                    Console.WriteLine("Tryck på valfri tangent för att gå till menyn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "2":
                                    Console.WriteLine("Skriv ett nummer mellan 1-22");


                                    int slumpMellan = slumpTalsGen.Next(1, mellan);



                                    for (int i = 1; i < antalGissningar; i++)
                                    {


                                        gissaNr = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Antal försök kvar: " + (antalGissningar - i));
                                        if (gissaNr == slumpMellan)
                                        {
                                            Console.WriteLine("Du gissade rätt!");
                                            break;
                                        }

                                        else if (gissaNr > slumpMellan)
                                        {
                                            Console.WriteLine("Nummret är lägre");
                                        }
                                        else if (gissaNr < slumpMellan)
                                        {
                                            Console.WriteLine("Nummret är högre");
                                        }


                                    }
                                    if (gissaNr == antalGissningar)
                                    {
                                        Console.WriteLine("Dina försök är slut");
                                        Console.ReadKey();

                                    }
                                    Console.WriteLine("Det rätta nummret var: " + slumpMellan);
                                    Console.WriteLine("Tryck på valfri tangent för att gå till menyn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;

                                case "3":
                                    Console.WriteLine("Skriv ett nummer mellan 1-33");


                                    int slumpSvår = slumpTalsGen.Next(1, mellan);



                                    for (int i = 1; i < antalGissningar; i++)
                                    {


                                        gissaNr = Convert.ToInt32(Console.ReadLine());
                                        Console.WriteLine("Antal försök kvar: " + (antalGissningar - i));
                                        if (gissaNr == slumpSvår)
                                        {
                                            Console.WriteLine("Du gissade rätt!");
                                            break;
                                        }

                                        else if (gissaNr > slumpSvår)
                                        {
                                            Console.WriteLine("Nummret är lägre");
                                        }
                                        else if (gissaNr < slumpSvår)
                                        {
                                            Console.WriteLine("Nummret är högre");
                                        }


                                    }
                                    if (gissaNr == antalGissningar)
                                    {
                                        Console.WriteLine("Dina försök är slut");
                                        Console.ReadKey();

                                    }
                                    Console.WriteLine("Det rätta nummret var: " + slumpSvår);
                                    Console.WriteLine("Tryck på valfri tangent för att gå till menyn");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        }
                        break;


                }
            }

            /* 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
             * 
            */


        
         }
    }
}