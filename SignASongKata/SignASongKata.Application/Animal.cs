using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public abstract class Animal
    {
        public Animal()
        {
            ListOfAnimals = new List<Animal>();
        }

        public abstract int Size { get; }
        public abstract string Name { get; }
        public IList<Animal> ListOfAnimals { get; set; }
        public string Phrase => BuildPhrase();
        public virtual string BuildPhrase()
        {
            if (IsGreaterAnimal())
            {
                return GetPhraseWhenIsTheGreatest();
            }

            if (IsSmallerAnimal())
            {
                return GetPhraseWhenIsTheSmallest();
            }            

            return GetPhrase();
        }

        private bool IsGreaterAnimal() => ListOfAnimals.Count == 0 ? true : ListOfAnimals.Last().Size == Size;
        private bool IsSmallerAnimal() => ListOfAnimals.Count == 0 ? true : ListOfAnimals[0].Size == Size;
        
        protected abstract string GetPhraseWhenIsTheSmallest();
        protected abstract string GetPhrase();
        protected abstract string GetPhraseWhenIsTheGreatest();  
        protected virtual Animal SmallestAnimal => ListOfAnimals[0];
        protected virtual string BuildSequenceOfAnimals()
        {
            var sb = new StringBuilder();
            var animalsSmallerThanThis = ListOfAnimals.Select(a => a)
                                                      .Where(a => a.Size <= this.Size)
                                                      .ToList();
            for (int i = animalsSmallerThanThis.Count - 1; i > 0; i--)
            {
                sb.Append($"She swallowed the {animalsSmallerThanThis[i].Name} to catch the {animalsSmallerThanThis[i - 1].Name}");
                sb.Append(i == 1 ? ";": ",");
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
