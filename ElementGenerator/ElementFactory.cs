using System;
using System.Collections.Generic;

namespace ElementGenerator
{
    public class ElementFactory
    {
        private Dictionary<string, Func<ElementBase>> _elements;

        public ElementFactory()
        {
            _elements = new Dictionary<string, Func<ElementBase>>
            {
                ["ps"] = () => new PageSection(),
                ["hs"] = () => new HeaderSection(),
            };
        }

        public string CreateElement(string name, string content)
        {
            string[] splits = name.Split('/');

            ElementBase element = _elements[splits[0]]();

            element.Initialize(splits[1]);

            string tag = element.GetType().Name.ToKebab();
            string cssClass = element.CssClass;

            return $"<{tag} class='{cssClass}'>{content}</{tag}>";
        }
    }
}
