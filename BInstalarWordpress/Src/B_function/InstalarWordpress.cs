using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace BInstalarWordpress
{
	class InstalarWordpress
	{
		public static string lg = AVar.lg;
		public static string dbnu = AVar.dbnu;
		public static string dbp = AVar.dbp;
		public static string host = AVar.host;
		public static string mail = AVar.mail;
		public static string pref = AVar.pref;
		public static string url = AVar.url;
		public static string wptitle = AVar.wptitle;
		public static string wppass = AVar.wppass;
		public static string selectLg = "//option[@value='es_ES']";
		public static string saveLg = "//form[@id='setup']/p/input";
		public static string continuar = "//p[5]/a";
		public static string dbname = "//input[@id='dbname']";
		public static string dbuser = "//input[@id='uname']";
		public static string dbpass = "//input[@id='pwd']";
		public static string dbhost = "//input[@id='dbhost']";
		public static string dbpref = "//input[@id='prefix']";
		public static string dbSave = "//p[2]/input";
		public static string dbInstall = "//p[3]/a";
		public static string wpTitle = "//input[@id='weblog_title']";
		public static string wpUser = "//input[@id='user_login']";
		public static string wpPass = "//input[@id='pass1-text']";
		public static string tbPsHide = "/table/tbody/tr[3]/td";
		public static string wpPsHide = "//form[@id='setup']" + tbPsHide + "/div/button/span[2]";
		public static string wpMail = "//input[@id='admin_email']";
		public static string wpTrack = "//input[@id='blog_public']";
		public static string wpInstall = "//input[@id='submit']";
		public static string wpLogin = "//a[@href='http://localhost/wordpress/wp-login.php']";
		public static string mpWordpress = "//a[@href='" + url + "']";
		public static string XPathObtenido = "//header[@id='masthead']/div/div/h1/a";
		public static EdgeDriver d = BEdge.Driver();

		public static void Main()
		{
			d.Navigate().GoToUrl(url);
			IWebElement wSelLg = d.FindElementByXPath(selectLg);
			wSelLg.Click();
			IWebElement wSaveLg = d.FindElementByXPath(saveLg);
			wSaveLg.Click();
			IWebElement wContinue = d.FindElementByXPath(continuar);
			wContinue.Click();
			IWebElement wDbName = d.FindElementByXPath(dbname);
			wDbName.Clear();
			wDbName.SendKeys(dbnu);
			IWebElement wDbUser = d.FindElementByXPath(dbuser);
			wDbUser.Clear();
			wDbUser.SendKeys(dbnu);
			IWebElement wDbPass = d.FindElementByXPath(dbpass);
			wDbPass.Clear();
			wDbPass.SendKeys(dbp);
			IWebElement wDbHost = d.FindElementByXPath(dbhost);
			wDbHost.Clear();
			wDbHost.SendKeys(host);
			IWebElement wDbPref = d.FindElementByXPath(dbpref);
			wDbPref.Clear();
			wDbPref.SendKeys(pref);
			IWebElement wDbSave = d.FindElementByXPath(dbSave);
			wDbSave.Click();
			IWebElement wDbInstall = d.FindElementByXPath(dbInstall);
			wDbInstall.Click();
			IWebElement wTitle = d.FindElementByXPath(wpTitle);
			wTitle.Clear();
			wTitle.SendKeys(wptitle);
			IWebElement wUser = d.FindElementByXPath(wpUser);
			wUser.Clear();
			wUser.SendKeys(dbnu);
			IWebElement wPass = d.FindElementByXPath(wpPass);
			wPass.Clear();
			wPass.SendKeys(wppass);
			IWebElement wPsHide = d.FindElementByXPath(wpPsHide);
			wPsHide.Click();
			IWebElement wMail = d.FindElementByXPath(wpMail);
			wMail.Clear();
			wMail.SendKeys(mail);
			IWebElement wTrack = d.FindElementByXPath(wpTrack);
			wTrack.Click();
			IWebElement wInstall = d.FindElementByXPath(wpInstall);
			wInstall.Click();
			Thread.Sleep(AVar.sim);
			IWebElement wLogin = d.FindElementByXPath(wpLogin);
			wLogin.Click();
			Thread.Sleep(AVar.sim);
			IWebElement wWordpress = d.FindElementByXPath(mpWordpress);
			wWordpress.Click();
			Thread.Sleep(AVar.sim);
			IWebElement wObtenido = d.FindElementByXPath(XPathObtenido);
			string obtenido = wObtenido.Text;
			Assert.AreEqual(wptitle, obtenido);
			d.Quit();
		}
	}
}