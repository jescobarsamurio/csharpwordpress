using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using System;

namespace CDefaultsWordpress
{
	class Defaults
	{
		static string check = "//input[@id='cb-select-all-1']";
		static string select = "//select[@id='bulk-action-selector-top']";
		static string accion = "//input[@id='doaction']";
		static string xpCommObt = "//div[@id='moderated']/p";
		static string xpObtenido = "//div[@id='message']/p";
		static CLogin L = new CLogin();
		static EdgeDriver d;

		public static void Borrar1Comment()
		{
			L.LoguearIn();
			d = CLogin.d;
			d.Navigate().GoToUrl(AVar.urlComments);
			Eliminar(AVar.moveTrash);
			d.Navigate().GoToUrl(AVar.urlCommentsTrash);
			Eliminar(AVar.delForever);
			By byObtenido = By.XPath(xpCommObt);
			String obtenido = d.FindElement(byObtenido).Text;
			Assert.AreEqual(AVar.espComment, obtenido);
			d.Navigate().GoToUrl(AVar.urlDashboard);
		}

		public static void Borrar2Page()
		{
			d.Navigate().GoToUrl(AVar.urlPage);
			Eliminar(AVar.moveTrash);
			d.Navigate().GoToUrl(AVar.urlPageTrash);
			Eliminar(AVar.delForever);
			By byObtenido = By.XPath(xpObtenido);
			String obtenido = d.FindElement(byObtenido).Text;
			Assert.AreEqual(AVar.espPage, obtenido);
			d.Navigate().GoToUrl(AVar.urlDashboard);
		}


		public static void Borrar3Post()
		{
			d.Navigate().GoToUrl(AVar.urlPost);
			Eliminar(AVar.moveTrash);
			d.Navigate().GoToUrl(AVar.urlPostTrash);
			Eliminar(AVar.delForever);
			By byObtenido = By.XPath(xpObtenido);
			String obtenido = d.FindElement(byObtenido).Text;
			Assert.AreEqual(AVar.espPost, obtenido);
			d.Navigate().GoToUrl(AVar.urlDashboard);
			L.LoguearOutAdmin();
		}

		public static void Eliminar(string l)
		{
			By byCheck = By.XPath(check);
			d.FindElement(byCheck).Click();
			SelectElement s = new SelectElement(d.FindElement(By.XPath(select)));
			s.SelectByText(l);
			By byAction = By.XPath(accion);
			d.FindElement(byAction).Click();
		}
	}
}