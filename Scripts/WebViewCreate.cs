using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KeyStore.Scripts
{
    public class WebViewCreate
    {
        public WebView2 web = new WebView2();

        public void RunWeb()
        {
            web.Dock = DockStyle.Fill;
            web.Source = new Uri ("https://www.youtube.com/watch?v=7LhwRtwEDvw");
        }

        public void OnChargeWeb()
        {
            Console.WriteLine();
        }
    }
}
