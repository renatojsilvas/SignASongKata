using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Spider : Animal
    {
        public override int Size => 2;
        public override string Name => "spider";
        protected override string GetPhrase()
        {
            return @$"There was an old lady who swallowed a spider;
That wriggled and wiggled and tickled inside her.
{BuildSequenceOfAnimals()}I don't know why she swallowed a {SmallestAnimal.Name} - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a spider...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a spider;
I don't know why she swallowed a spider - perhaps she'll die!";
        }
    }
}
