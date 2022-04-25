namespace SignASongKata.Core
{
    public class Horse : Animal
    {
        public override int Size => 7;
        public override string Name => "horse";
        protected override string GetRhyme() => "";
        protected override string GetPhraseWhenIsTheGreatest()
        {
            return @"There was an old lady who swallowed a horse...
...She's dead, of course!";
        }
    }
}
