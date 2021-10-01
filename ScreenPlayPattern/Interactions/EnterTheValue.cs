using System;
using System.Collections.Generic;
using System.Text;
using Boa.Constrictor.Screenplay;
using Boa.Constrictor.WebDriver;
namespace ScreenPlayPattern.Interactions
{
    public class EnterTheValue : ITask
    {

        private string text;
        private IWebLocator target;

        public EnterTheValue(string text, IWebLocator target)
        {
            this.text = text;
            this.target = target;
        }

        public void PerformAs(IActor actor)
        {
            var driver = actor.Using<BrowseTheWeb>().WebDriver;
            driver.FindElement(target.Query).SendKeys(text);
        }
    }

    public class Enter
    {
        private string text;

        public Enter(string text)
        {
            this.text = text;
        }

        public static Enter TheValue(string text)
        {
            return new Enter(text);
        }

        public EnterTheValue Into(IWebLocator target)
        {
            return new EnterTheValue(text, target);
        }
    }
}
