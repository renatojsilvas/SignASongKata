namespace SignASongKata.Core
{
    public class Dog : Animal
    {
        public override int Size => 5;
        public override string Name => "dog";
        protected override string GetRhyme() => "What a hog, to swallow a dog!";
    }
}
