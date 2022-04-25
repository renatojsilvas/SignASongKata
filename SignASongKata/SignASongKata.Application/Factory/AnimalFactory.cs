using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Core
{
    public static class AnimalFactory
    {
        public static Animal CreateAnimal(string animal)
        {
            switch (animal)
            {
                case "horse":
                    return new Horse();
                case "cow":
                    return new Cow();
                case "dog":
                    return new Dog();
                case "cat":
                    return new Cat();
                case "bird":
                    return new Bird();
                case "spider":
                    return new Spider();
                case "fly":
                    return new Fly();
                default:
                    return null;
            }
        }

        public static IList<Animal> ParseList(IList<string> animals) => animals.Select(a => CreateAnimal(a))
                                                                        .OrderBy(a => a.Size)
                                                                        .ToList();
    }
}
