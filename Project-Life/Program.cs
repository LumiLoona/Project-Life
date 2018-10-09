using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLife
{
    class LifeExecutable
    {
        static void Main(string[] args)
        {
            string player = " ";

            Console.WriteLine(".s5SSSs.  .s5SSSs.  .s5SSSs.        s.  .s5SSSs.  .s5SSSs.  .s5SSSSs. ");
            Console.WriteLine("      SS.       SS.       SS.       SS.       SS.       SS.    SSS    ");
            Console.WriteLine("sS    S%S sS    S%S sS    S%S       S%S sS    `:; sS    `:;    S%S    ");
            Console.WriteLine("SS    S%S SS    S%S SS    S%S       S%S SS        SS           S%S    ");
            Console.WriteLine("SS .sS::' SS .sS;:' SS    S%S       S%S SSSs.     SS           S%S    ");
            Console.WriteLine("SS        SS    ;,  SS    S%S       S%S SS        SS           S%S    ");
            Console.WriteLine("SS        SS    `:; SS    `:;       `:; SS        SS           `:;    ");
            Console.WriteLine("SS        SS    ;,. SS    ;,. .,;   ;,. SS    ;,. SS    ;,.    ;,.    ");
            Console.WriteLine("`:        `:    ;:' `:;;;;;:' `:;;;;;:' `:;;;;;:' `:;;;;;:'    ;:'    ");
            Console.WriteLine("                                                                      ");
            Console.WriteLine("                .s        s.  .s5SSSs. .s5SSSs.                       ");
            Console.WriteLine("                          SS.                SS.                      ");
            Console.WriteLine("                sS        S%S sS       sS    `:;                      ");
            Console.WriteLine("                SS        S%S SS       SS                             ");
            Console.WriteLine("                SS        S%S SSSs.    SSSs.                          ");
            Console.WriteLine("                SS        S%S SS       SS                             ");
            Console.WriteLine("                SS        `:; SS       SS                             ");
            Console.WriteLine("                SS    ;,. ;,. SS       SS    ;,.                      ");
            Console.WriteLine("                `:;;;;;:' ;:' :;       `:;;;;;:'                      ");


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Press Any Button To Start. . .");
            Console.ReadKey(true);
            Console.WriteLine("");



            Console.WriteLine("You wake up in a strange forest in a haze, your vision is blurry and memory is foggy.");
            Console.WriteLine("You dont know who you are.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("");
            Console.WriteLine("You emerge from a rather pretty bed of flowers, this place seems nice in an odd way.");
            Console.WriteLine("All you know is your name, which is...");
            player = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Yes, your name is " + player + ".");
            Console.WriteLine("You start to explore and find yourself at a crossroads.");
            Console.WriteLine("On the right there is an old path covered in vines and on the left is a small ledge overlooking a sparkling stream of clear blue water.");





            System.Threading.Thread.Sleep(15000);
        }
    }
}
