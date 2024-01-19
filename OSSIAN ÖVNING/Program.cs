using System;
using System.ComponentModel.Design;

namespace SSP
{
    class Program
    {
        static void Main(string[] args)
        {
            int AIPoint = 0;
            int UPoint = 0;

            do 
            {

                Console.WriteLine("Välj en av de: Sten, Sax, Påse");
                PickAThing pt = new PickAThing();
                Play pl = new Play();
                int U = pt.UpickAThing();
                int AI = pt.AIPickAthing();
                int win = pl.playing(U, AI);

                if (win == 1)
                {
                    AIPoint++;
                    Console.WriteLine("Poäng: AI");
                    Console.WriteLine("Ditt poäng: " + UPoint);
                    Console.WriteLine("AI poäng; " + AIPoint);
                }
                else if (win == 2)
                {
                    UPoint++;
                    Console.WriteLine("Poäng: du");
                    Console.WriteLine("Ditt poäng: " + UPoint);
                    Console.WriteLine("AI poäng; " + AIPoint);

                }
                else
                {
                    Console.WriteLine("Poäng: ingen");
                    Console.WriteLine("Ditt poäng: " + UPoint);
                    Console.WriteLine("AI poäng; " + AIPoint);
                }

            } while (UPoint < 3 && AIPoint < 3);

            if (UPoint == 3)
            {
                Console.WriteLine("Du van");
                Console.WriteLine("Ditt poäng: " + UPoint);
                Console.WriteLine("AI poäng; " + AIPoint);

            }
            else
            {
                Console.WriteLine("AI van");
                Console.WriteLine("Ditt poäng: " + UPoint);
                Console.WriteLine("AI poäng; " + AIPoint);
            }
            if (UPoint < AIPoint)
            {
                Console.WriteLine("AI van matchen");
            }
            if (UPoint > AIPoint)
            {
                Console.WriteLine("Du van matchen");
                
            }
            Console.WriteLine("vill du fortsätta spela J/N");
            string svar = Console.ReadLine();
            if (svar == "J")
            {
                Console.WriteLine("klicka på enter");
            }
            while(svar == "N")
            {
                Console.WriteLine("Hejdå");
                Console.ReadKey();
                break;
            }
        }
    }
    public class PickAThing
    {
        public int AIPickAthing()
        {
            Random rnd = new Random();
            int val = rnd.Next(1, 4);

            return val;
        }
        public int UpickAThing()
        {
            int val = 0;
            string x = Console.ReadLine();
            if (x.ToLower() == "sten" || x == "1")
            {
                val = 1;
            }
            else if (x.ToLower() == "sax" || x == "2")
            {
                val = 2;
            }
            else if (x.ToLower() == "påse" || x == "3")
            {
                val = 3;
            }


            return val;
        }
    }
    public class Play
    {
        public int playing(int U, int AI)
        {
            if (AI == 1)
            {
                Console.WriteLine("AI:Sten");
            }
            else if (AI == 2)
            {
                Console.WriteLine("AI:Sax");
            }
            else if (AI == 3)
            {
                Console.WriteLine("AI:Påse");
            }

            if (AI == U)
            {
                return 0;
            }
            else if ((AI == 1 && U == 2) || (AI == 2 && U == 3) || (AI == 3 && U == 1) || (U == 0))
            {
                return 1;
            }

            else { return 2; }

            return 0;
        }
    }
}