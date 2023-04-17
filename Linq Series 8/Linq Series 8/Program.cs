using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq_Series_8
{
    public class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<string>()
            {
                "Duck","Lion","Dolphin","Tiger"
            };
            var animalsWithD = animals.Where(
                animal =>
                {
                    Console.WriteLine("Check animal: " + animal);
                    return animal.StartsWith('D'); 
                }
                );
            foreach(var animal in animalsWithD)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
