using Microsoft.QualityTools.Testing.Fakes;
using Xunit;

namespace ElementGenerator.Tests
{
    public class ElementFactoryTests
    {
        [Fact]
        public void Creation()
        {
            var factory = new ElementFactory();

            Assert.NotNull(factory);
        }

        [Fact]
        public void CreatePageSection()
        {
            using (ShimsContext.Create())
            {
                ElementGenerator.Fakes.ShimExtensions.ToKebabString = s => s;

                var factory = new ElementFactory();

                string element = factory.CreateElement("ps/3", "Hello World");

                Assert.Equal("<PageSection class='level-3'>Hello World</PageSection>", element);
            }
        }
    }
}
