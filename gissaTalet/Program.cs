using System;
using System.Threading;

namespace Uppgift_4._8
{
    class Program
    {
        static void Main(string[] args)
        {

            string anvandarensVal = "0";
            while (anvandarensVal != "5")
            {


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Välkommen till gissa talet");
                Thread.Sleep(400);
                Console.WriteLine("Välj ett alternativ!!!");
                Thread.Sleep(400);
                Console.WriteLine("1. Spela gissa talet 1-10");
                Thread.Sleep(400);
                Console.WriteLine("2. Spela gissa talet 1-100");
                Thread.Sleep(400);
                Console.WriteLine("3. Spela gissa talet 1-1000");
                Thread.Sleep(400);
                Console.WriteLine("4. Spelets regler");
                Thread.Sleep(400);
                Console.WriteLine("5. Avsluta programet");
                anvandarensVal = Console.ReadLine();

                Random random = new Random();

                switch (anvandarensVal)
                {
                    //spela gissa talet 1-10
                    case "1":
                        int datornsGissning = random.Next(1, 11);
                        Console.WriteLine("Siffran skapas");
                        Thread.Sleep(600);
                        Console.WriteLine("gissa på en siffra mellan 1-10");
                        int anvandarensGissning = int.Parse(Console.ReadLine());


                        while (anvandarensGissning != datornsGissning)
                        {


                            if (anvandarensGissning > datornsGissning)
                            {
                                Console.WriteLine("Lägre");
                            }
                            else
                            {
                                Console.WriteLine("högre");
                            }
                            anvandarensGissning = int.Parse(Console.ReadLine());
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("du gissade rätt!!!");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;



                    //spela gissa talet 1-100
                    case "2":
                        int datornsGissning2 = random.Next(1, 101);
                        Console.WriteLine("Siffran skapas");
                        Thread.Sleep(600);

                        Console.WriteLine("gissa på en siffra mellan 1-100");
                        int anvandarensGissning2 = int.Parse(Console.ReadLine());


                        while (anvandarensGissning2 != datornsGissning2)
                        {


                            if (anvandarensGissning2 > datornsGissning2)
                            {
                                Console.WriteLine("Lägre");
                            }
                            else
                            {
                                Console.WriteLine("högre");
                            }
                            anvandarensGissning2 = int.Parse(Console.ReadLine());
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("du gissade rätt!!!");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;


                    //spela gissa talet 1-1000
                    case "3":
                        int datornsGissning3 = random.Next(1, 1001);
                        Console.WriteLine("Siffran skapas");
                        Thread.Sleep(600);

                        Console.WriteLine("gissa på en siffra mellan 1-1000");
                        int anvandarensGissning3 = int.Parse(Console.ReadLine());


                        while (anvandarensGissning3 != datornsGissning3)
                        {


                            if (anvandarensGissning3 > datornsGissning3)
                            {
                                Console.WriteLine("Lägre");
                            }
                            else
                            {
                                Console.WriteLine("högre");
                            }
                            anvandarensGissning3 = int.Parse(Console.ReadLine());
                        }

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("du gissade rätt!!!");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;


                    //spelets regler
                    case "4":
                        Console.WriteLine("I varje omgång av gissa talet kommer datorn slumpa fram ett heltal mellan 1-10, 1-100 eller 1-1000. Du ska gissa vilket talet är ända tills du gissar rätt. Efter varje gissning kommer du få veta om gissningar var rätt, för hög eller för låg.");
                        break;

                    //avsluta programet
                    case "5":


                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Du avslutade spelet");
                        Console.ForegroundColor = ConsoleColor.White;

                        break;
                }


            }

        }

    }
}