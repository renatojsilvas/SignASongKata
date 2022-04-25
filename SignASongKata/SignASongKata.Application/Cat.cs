using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Cat : Animal
    {
        public override int Size => 4;
        public override string Name => "cat";
        protected override string GetPhrase()
        {
            return @$"There was an old lady who swallowed a cat;
Fancy that to swallow a cat!
{BuildSequenceOfAnimals()}I don't know why she swallowed a {SmallestAnimal.Name} - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a cat...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a cat;
I don't know why she swallowed a cat - perhaps she'll die!";
        }
    }
}
