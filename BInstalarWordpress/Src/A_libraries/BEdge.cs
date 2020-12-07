using OpenQA.Selenium.Edge;
using System;

namespace BInstalarWordpress
{
    class BEdge
    {
        public static long t = AVar.tois;
        public static EdgeDriver Driver()
        {
            string EDD = AVar.edd;
            string EDE = AVar.ede;
            EdgeDriverService service = EdgeDriverService.CreateDefaultService(EDD, EDE);
            EdgeDriver ed = new EdgeDriver(service: service);
            ed.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(t);
            ed.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(t);
            ed.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(t);
            ed.Manage().Window.Maximize();
            return ed;
        }
    }
}