namespace SignASongKata.Core
{
    public class Fly : Animal
    {
        public override int Size => 1;
        public override string Name => "fly";
        protected override string GetRhyme() => "";
        protected override string GetPhraseWhenIsTheSmallest()
        {
            return @"There was an old lady who swallowed a fly.
I don't know why she swallowed a fly - perhaps she'll die!";
        }
    }
}
