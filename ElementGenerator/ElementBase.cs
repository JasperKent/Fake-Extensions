namespace ElementGenerator
{
    internal abstract class ElementBase
    {
        public string CssClass { get; protected set; }

        public abstract void Initialize(string parameter);
    }
}
