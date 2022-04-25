namespace SignASongKata.Core
{
    public class Cow : Animal
    {
        public override int Size => 6;
        public override string Name => "cow";
        protected override string GetRhyme() => "I don't know how she swallowed a cow!";
    }
}
