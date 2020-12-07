using System.Diagnostics;
using System.Threading;

namespace ABatWordpress
{
    class BatWordpress
    {
        public static void Main()
        {
            Process.Start("wordpress.bat");
            Thread.Sleep(60000);
        }
    }
}