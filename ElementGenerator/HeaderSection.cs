namespace ElementGenerator
{
    internal class HeaderSection : ElementBase
    {
        public override void Initialize(string parameter)
        {
            CssClass = $"indent-{parameter}";
        }
    }
}
