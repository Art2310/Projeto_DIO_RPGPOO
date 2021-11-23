using System;
using DotnetPOORPG.src.Entities;

namespace Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 120, 20);
            Wizard wizard = new Wizard("Jennica", 99, "White Wizard", 90 , 180);

            Console.WriteLine(wizard.Attack("fogo",12));
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(arus.Attack());
        }
    }
}
