namespace SignASongKata.Core
{
    public class Bird : Animal
    {
        public override int Size => 3;
        public override string Name => "bird";
        protected override string GetRhyme() => "How absurd to swallow a bird.";
    }
}
