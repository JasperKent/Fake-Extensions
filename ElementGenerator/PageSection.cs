namespace ElementGenerator
{
    internal class PageSection : ElementBase
    {
        public override void Initialize(string parameter)
        {
            CssClass = $"level-{parameter}";
        }
    }
}
