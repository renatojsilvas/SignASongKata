using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Dog : Animal
    {
        public override int Size => 5;
        public override string Name => "dog";
        protected override string GetPhrase()
        {
            return @$"There was an old lady who swallowed a dog;
What a hog, to swallow a dog!
{BuildSequenceOfAnimals()}I don't know why she swallowed a {SmallestAnimal.Name} - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a dog...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a dog;
I don't know why she swallowed a dog - perhaps she'll die!";
        }
    }
}
