using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignASongKata.Core
{
    public class Spider : Animal
    {
        public override int Size => 2;
        public override string Name => "spider";
        protected override string GetRhyme() => "That wriggled and wiggled and tickled inside her.";
    }
}
