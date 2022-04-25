using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Bird : Animal
    {
        public override int Size => 3;
        public override string Name => "bird";

        protected override string GetPhrase()
        {
            return @$"There was an old lady who swallowed a bird;
How absurd to swallow a bird.
{BuildSequenceOfAnimals()}I don't know why she swallowed a {SmallestAnimal.Name} - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a bird...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a bird;
I don't know why she swallowed a bird - perhaps she'll die!";
        }
    }
}
