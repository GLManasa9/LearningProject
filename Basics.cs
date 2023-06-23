﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System;

namespace BankProject
{
    public class Basics
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new EdgeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test(Author = "Manasa"), Order(2)]
        [TestCase("Hellow Manasa")]
        [Ignore("Ignore this test due to open bug")]
        public void Test1(String printText)
        {
            Console.WriteLine(printText);
            Console.WriteLine("Hello World");
            driver.Navigate().GoToUrl("https://www.google.com/");
            String title = driver.Title;
            Console.WriteLine("Title:" + title);
            driver.Close();
        }

        [Test(Author = "Manasa"), Order(2)]
        [TestCase("Hellow Manasa")]
        public void First(String printText)
        {
            Console.WriteLine(printText);
            Console.WriteLine("Hello World");
            driver.Navigate().GoToUrl("https://www.google.com/");
            String title = driver.Title;
            Console.WriteLine("Title:" + title);
            driver.Close();
        }

        [Test,Order(1)]
        public void Test2([Values("C# Selenium")]string text)
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            By searchBoxLocator = By.CssSelector("textarea#APjFqb");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(searchBoxLocator).SendKeys(text);
            driver.SwitchTo().ActiveElement().SendKeys(Keys.Enter);
            driver.Close();
        }
    }
}