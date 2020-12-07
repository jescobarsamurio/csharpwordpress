using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace DNewPostWordpress
{
	class CLogin
	{
		public static string user = AVar.user;
		public static string url = AVar.url;
		public static string pass = AVar.pass;
		public static string loginEsperado = AVar.loginEsperado;
		public static string logoutEsperado = AVar.logoutEsperado;
		public static string LVerSite = "//li[@id='wp-admin-bar-site-name']/a";
		public static string Alogin = "//section[@id='meta-2']/ul/li/a";
		public static string ALogout = "//section[@id='meta-2']/ul/li[2]/a";
		public static string LUser = "//input[@id='user_login']";
		public static string LPass = "//input[@id='user_pass']";
		public static string LRemember = "//input[@id='rememberme']";
		public static string LIngresar = "//input[@id='wp-submit']";
		public static string LObtenido = "//div[@id='login']/p";
		public static string strLoginObtenido = "//div[@id='wpbody-content']/div[4]/h1";
		public static EdgeDriver d = BEdge.Driver();

		public void LoguearIn()
		{
			d.Navigate().GoToUrl(url);
			Thread.Sleep(AVar.sim);
			By byALogin = By.XPath(Alogin);
			d.FindElement(byALogin).Click();
			Thread.Sleep(AVar.sim);
			By byLUser = By.XPath(LUser);
			Thread.Sleep(AVar.sim);
			d.FindElement(byLUser).Clear();
			d.FindElement(byLUser).SendKeys(user);
			Thread.Sleep(AVar.sim);
			By byLPass = By.XPath(LPass);
			d.FindElement(byLPass).Clear();
			d.FindElement(byLPass).SendKeys(pass);
			Thread.Sleep(AVar.sim);
			By byLRemember = By.XPath(LRemember);
			d.FindElement(byLRemember).Click();
			Thread.Sleep(AVar.sim);
			By byLIngresar = By.XPath(LIngresar);
			d.FindElement(byLIngresar).Click();
			Thread.Sleep(AVar.sim);
			By byLoginObtenido = By.XPath(strLoginObtenido);
			string loginObtenido = d.FindElement(byLoginObtenido).Text;
			Assert.AreEqual(loginEsperado, loginObtenido);
		}

		public void LoguearOutMain()
		{
			By byALogout = By.XPath(ALogout);
			d.FindElement(byALogout).Click();
			Thread.Sleep(AVar.sim);
			By byObtenido = By.XPath(LObtenido);
			string obtenido = d.FindElement(byObtenido).Text;
			Assert.AreEqual(logoutEsperado, obtenido);
			d.Quit();
		}

		public void LoguearOutAdmin()
		{
			By byLVerSite = By.XPath(LVerSite);
			d.FindElement(byLVerSite).Click();
			Thread.Sleep(AVar.sim);
			LoguearOutMain();
		}
	}
}