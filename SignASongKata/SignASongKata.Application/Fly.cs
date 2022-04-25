using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Fly : Animal
    {
        public override int Size => 1;
        public override string Name => "fly";
        protected override string GetPhrase()
        {
            return @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a fly...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";
        }
    }
}
