using OpenQA.Selenium;
using OpenQA.Selenium.Appium.Android;



namespace iHaul.HelperClass
{
    public class FlutterBy : By
    {
        private readonly string finderType;
        private readonly string value;

        private FlutterBy(string finderType, string value)
        {
            this.finderType = finderType;
            this.value = value;
        }

        public static By ByValueKey(string key) => new FlutterBy("ByValueKey", key);
        public static By Text(string text) => new FlutterBy("ByText", text);
        public static By Tooltip(string tooltip) => new FlutterBy("ByTooltipMessage", tooltip);
        public static By SemanticsLabel(string label) => new FlutterBy("BySemanticsLabel", label);

        public override IWebElement FindElement(ISearchContext context)
        {
            var executor = context as IJavaScriptExecutor;
            if (executor == null)
                throw new ArgumentException("Context must be a driver that supports IJavaScriptExecutor");

            var args = new Dictionary<string, object>
            {
                ["finderType"] = finderType,
                ["keyValueString"] = value
            };

            return (IWebElement)executor.ExecuteScript("flutter:findElement", args);
        }

        public override System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> FindElements(ISearchContext context)
        {
            var executor = context as IJavaScriptExecutor;
            if (executor == null)
                throw new ArgumentException("Context must be a driver that supports IJavaScriptExecutor");

            var args = new Dictionary<string, object>
            {
                ["finderType"] = finderType,
                ["keyValueString"] = value
            };

            var result = executor.ExecuteScript("flutter:findElements", args) as IEnumerable<IWebElement>;
            return new System.Collections.ObjectModel.ReadOnlyCollection<IWebElement>(new List<IWebElement>(result));
        }
    }
}