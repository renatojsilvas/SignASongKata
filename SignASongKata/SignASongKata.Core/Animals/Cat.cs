namespace SignASongKata.Core
{
    public class Cat : Animal
    {
        public override int Size => 4;
        public override string Name => "cat";
        protected override string GetRhyme() => "Fancy that to swallow a cat!";
    }
}
