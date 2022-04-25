using System;
using System.Collections.Generic;
using System.Linq;

namespace SignASongKata.Core
{
    public class Animals 
    {
        private readonly List<Animal> animals;

        public Animals(List<string> animals)
        {
            if (!animals.Any())
                throw new Exception("There is no animals!");

            if (!animals.Contains("horse"))
                throw new Exception("There is no horse!");

            this.animals = AnimalFactory.ParseList(animals).ToList();
            this.animals.ForEach(a => a.ListOfAnimals = this.animals);
        }

        public IList<Animal> GetAnimals() => animals;
    }
}
