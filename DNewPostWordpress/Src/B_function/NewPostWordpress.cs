using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace DNewPostWordpress
{
	class NewPostWordpress
	{
		public static string postTitle = AVar.postTitle;
		public static string postText = AVar.postText;
		public static string urlNewPost = AVar.urlNewPost;

		static CLogin L = new CLogin();
		static string div2div2 = "/div[2]/div[2]";
		static string divs3 = "/div/div/div";
		static string divs4 = divs3 + "/div";
		static string divs5 = divs4 + "/div";
		static string divs7 = divs5 + "/div/div";
		static string sma = "/section/main/article";
		static string hideTip = "//div[@id='editor']" + divs3 + "/div[6]" + divs4 + "/button";
		static string title = "//div[@id='editor']" + divs3 + div2div2 + divs7 + "/textarea";
		static string bloque = "//div[@id='editor']" + divs3 + divs4 + "/button";
		static string parrafo = "//div[@id='editor']" + divs3 + "/div[6]" + divs3 + divs4 + "/ul/li/button";
		static string text = "//div[@id='editor']" + divs3 + div2div2 + divs3 + "/div[2]/div/div[3]" + divs3 + divs3 + "/p";
		static string publish1 = "button.components-button.editor-post-publish-panel__toggle.is-button.is-primary";
		static string publish2 = "//div[@id='editor']" + divs3 + "/div[3]" + divs4 + "/button";
		static string obTitle = "//div[@id='content']" + sma + "/header/h2/a";
		static string obText = "//div[@id='content']" + sma + "/div/p";
		static string verPost = AVar.url;
		static EdgeDriver d;

		public static void Main()
		{
			L.LoguearIn();
			d = CLogin.d;
			d.Navigate().GoToUrl(urlNewPost);
			By byHideTip = By.XPath(hideTip);
			Thread.Sleep(AVar.sim);
			d.FindElement(byHideTip).Click();
			By byTitle = By.XPath(title);
			Thread.Sleep(AVar.sim);
			d.FindElement(byTitle).Clear();
			d.FindElement(byTitle).SendKeys(postTitle);
			By byBloque = By.XPath(bloque);
			Thread.Sleep(AVar.sim);
			d.FindElement(byBloque).Click();
			By byParrafo = By.XPath(parrafo);
			Thread.Sleep(AVar.sim);
			d.FindElement(byParrafo).Click();
			By byText = By.XPath(text);
			Thread.Sleep(AVar.sim);
			d.FindElement(byText).Clear();
			d.FindElement(byText).SendKeys(postText);
			Thread.Sleep(AVar.sim);
			By byPublish1 = By.CssSelector(publish1);
			Thread.Sleep(AVar.sim);
			d.FindElement(byPublish1).Click();
			Thread.Sleep(AVar.sim);
			By byPublish2 = By.XPath(publish2);
			Thread.Sleep(AVar.sim);
			d.FindElement(byPublish2).Click();
			Thread.Sleep(AVar.sim);
			d.Navigate().GoToUrl(verPost);
			By byObTitle = By.XPath(obTitle);
			Thread.Sleep(AVar.sim);
			string oTitle = d.FindElement(byObTitle).Text;
			Assert.AreEqual(postTitle, oTitle);
			By byObText = By.XPath(obText);
			Thread.Sleep(AVar.sim);
			string oText = d.FindElement(byObText).Text;
			Assert.AreEqual(postText, oText);
			L.LoguearOutMain();
		}
	}
}