using SignASongKata.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Core
{
    public class SongGenerator
    {
        private List<string> animals;

        public SongGenerator(List<string> animals)
        {
            this.animals = animals;
        }

        public string GenerateSong()
        {
            if (!animals.Any())
                throw new Exception("There is no animals!");

            if (!animals.Contains("horse"))
                throw new Exception("There is no horse!");

            var animals1 = AnimalFactory.ParseList(animals).ToList();

            animals1.ForEach(a => a.ListOfAnimals = animals1);               

            StringBuilder sb = new StringBuilder();
            foreach (var item in animals1)
            {
                sb.AppendLine(item.Phrase);
                sb.AppendLine();
            }

            return sb.Remove(sb.Length - 4, 4).ToString();
        }
    }
}
