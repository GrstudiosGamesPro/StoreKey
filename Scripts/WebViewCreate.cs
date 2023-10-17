using Microsoft.Web.WebView2.Core;
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
        string webPath = "Data/Web/";
        string htmlIndex = "";
        string htmlCSS = "";
        string newIndex = "";

        public void RunWeb()
        {
            htmlIndex = File.ReadAllText ("Data\\Web\\HMTL/index.html");
            htmlCSS = File.ReadAllText("Data\\Web\\CSS/styles.css");

            newIndex = htmlIndex.Replace ("/*HERE INSTALL NEW STYLE CSS*/", htmlCSS);

            Console.WriteLine ("Web content: " + newIndex);

            web.Dock = DockStyle.Fill;
            web.CoreWebView2InitializationCompleted += OnChargeWeb;
            web.EnsureCoreWebView2Async (null);
        }

        public void OnChargeWeb (object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                web.NavigateToString(newIndex);
                Console.WriteLine ("Web started");
            }
            else
            {
                MessageBox.Show ("ERROR WHEN CREATING APP WINDOW", "ERROR 3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine ("Error on start web");
            }
        }
    }
}
