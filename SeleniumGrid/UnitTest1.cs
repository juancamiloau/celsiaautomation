using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using System;
namespace SeleniumGrid
{
    [Parallelizable(scope: ParallelScope.All)]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(10000);
                
            }catch(Exception e)
            {
                Console.Write(e.Message);
            }
            if(driver != null)
                driver.Quit();

        }

        [Test]
        public void Test2()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test3()
        {
            RemoteWebDriver driver = null;
            try
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test4()
        {
            RemoteWebDriver driver = null;
            try
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test5()
        {
            RemoteWebDriver driver = null;
            try
            {
                FirefoxOptions options = new FirefoxOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test6()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test7()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test8()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }

        [Test]
        public void Test9()
        {
            RemoteWebDriver driver = null;
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddAdditionalOption("platform", "WIN10");
                Console.WriteLine(options.ToString());
                driver = new RemoteWebDriver(new Uri("http://localhost:4444/"), options);
                driver.Url = "https://celsia.com";
                Thread.Sleep(20000);

            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
            if (driver != null)
                driver.Quit();

        }



    }
}