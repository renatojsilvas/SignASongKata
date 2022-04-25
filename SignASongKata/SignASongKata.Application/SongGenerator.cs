using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignASongKata.Core
{
    public class SongGenerator
    {
        private readonly Animals animals;

        public SongGenerator(List<string> animals)
        {
            this.animals = new Animals(animals);
        }

        public string GenerateSong()
        {
            var sb = new StringBuilder();
            foreach (var item in animals.GetAnimals())
            {
                sb.AppendLine(item.Phrase);
                sb.AppendLine();
            }
            return RemoveExtraSpacesAtTheEnd(sb.ToString());
        }

        private string RemoveExtraSpacesAtTheEnd(string song)
        {
            return song.TrimEnd(new char[] { '\r', '\n' });
        }
    }
}
