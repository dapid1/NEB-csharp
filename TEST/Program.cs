using System;
using animFact;

namespace NebulaChall
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal horse = AnimalFactory.getAnimal(AnimalType.HORSE);
            Animal sheep = AnimalFactory.getAnimal(AnimalType.SHEEP);
            Animal generic = AnimalFactory.getAnimal(AnimalType.GENERIC);
            Animal any = AnimalFactory.getAnimal();

            string eat = horse.Eat();
            string sound = horse.MakeNoise();
            Console.WriteLine("Horse:");
            Console.Write(eat);
            Console.Write(sound);
            Console.WriteLine("");

            eat = sheep.Eat();
            sound = sheep.MakeNoise();
            Console.WriteLine("Sheep:");
            Console.Write(eat);
            Console.Write(sound);
            Console.WriteLine("");

            Console.WriteLine("Generic:");
            eat = generic.Eat();
            sound = generic.MakeNoise();
            Console.Write(eat);
            Console.Write(sound);
            Console.WriteLine("");

            eat = any.Eat();
            sound = any.MakeNoise();
            Console.WriteLine("Any:");
            Console.Write(eat);
            Console.Write(sound);
            Console.WriteLine();

        }
    }
}
