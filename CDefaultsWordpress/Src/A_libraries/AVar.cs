using System;

namespace CDefaultsWordpress
{
    class AVar
    {
        public static long tois = 120;
        public static int sim = 90000;
        public static string dirusr = @"C:\Users\jesco\.nuget\packages\";
        public static string edd = dirusr + @"selenium.webdriver.msedgedriver\86.0.622.38\driver\win64";
        public static string ede = @"msedgedriver.exe";
        public static string loginEsperado = "Dashboard";
        public static string logoutEsperado = "You are now logged out.";
        public static string url = "http://localhost/wordpress/";
        public static string wptitle = "AUTOMATIZACION DE WORPRESS 5";
        public static string wppass = "7610JcEs3024";
        public static string delForever = "Delete Permanently";
        public static string espComment = "1 comment permanently deleted";
        public static string espPage = "2 pages permanently deleted.";
        public static string espPost = "1 post permanently deleted.";
        public static string moveTrash = "Move to Trash";
        public static string pass = "7610JcEs3024";
        public static string urlComments = url + "wp-admin/edit-comments.php";
        public static string urlCommentsTrash = url + "wp-admin/edit-comments.php?comment_status=trash";
        public static string urlDashboard = url + "wp-admin/index.php";
        public static string urlPage = url + "wp-admin/edit.php?post_type=page";
        public static string urlPageTrash = url + "wp-admin/edit.php?post_status=trash&post_type=page";
        public static string urlPost = url + "wp-admin/edit.php?post_type=post";
        public static string urlPostTrash = url + "wp-admin/edit.php?post_status=trash&post_type=post";
        public static string user = "wordpress";
        public static TimeSpan ts = TimeSpan.FromSeconds(tois);
    }
}