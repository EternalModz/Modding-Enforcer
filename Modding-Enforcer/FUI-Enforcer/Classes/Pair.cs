namespace FUI_Enforcer
{
    public class Pair<T> where T : struct
    {
        public T X { get; private set; }
        public T Y { get; private set; }
        public Pair(T x, T y)
        {
            this.X = x;
            this.Y = y;
        }
        private Pair() { }
        public override string ToString() => $"X {{{X}}} | {{{Y}}}";
    }
}