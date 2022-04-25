using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Cow : Animal
    {
        public override int Size => 6;
        public override string Name => "cow";
        protected override string GetPhrase()
        {
            return @$"There was an old lady who swallowed a cow;
I don't know how she swallowed a cow!
{BuildSequenceOfAnimals()}I don't know why she swallowed a {SmallestAnimal.Name} - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a cow...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a cow;
I don't know why she swallowed a cow - perhaps she'll die!";
        }
    }
}
