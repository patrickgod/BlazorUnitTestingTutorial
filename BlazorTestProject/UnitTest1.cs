using BlazorUnitTestingTutorial.Pages;
using Bunit;

namespace BlazorTestProject
{
    public class UnitTest1 : TestContext
    {
        [Fact]
        public void CounterShouldIncrementWhenClicked()
        {
            var cut = RenderComponent<Counter>();

            cut.Find("button").Click();

            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 1</p>");
        }

        [Fact]
        public void CounterShouldIncrementByValueWhenClicked()
        {
            var cut = RenderComponent<Counter>(parameters => parameters.Add(p => p.Value, 2));

            cut.Find("button").Click();

            cut.Find("p").MarkupMatches("<p role=\"status\">Current count: 2</p>");
        }
    }
}