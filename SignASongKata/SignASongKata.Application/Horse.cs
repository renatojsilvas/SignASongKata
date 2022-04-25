using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Application
{
    public class Horse : Animal
    {
        public override int Size => 7;
        public override string Name => "horse";
        protected override string GetPhrase()
        {
            throw new NotImplementedException();
        }

        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a horse...
...She's dead, of course!";
        }

        protected override string GetPhraseWhenIsTheSmallest()
        {
            throw new NotImplementedException();
        }
    }
}
