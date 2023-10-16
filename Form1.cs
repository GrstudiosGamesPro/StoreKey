using KeyStore.Scripts;

namespace KeyStore
{
    public partial class Form1 : Form
    {

        ServerNode node = new ServerNode();
        WebViewCreate web = new WebViewCreate();

        public Form1()
        {
            InitializeComponent();
            node.RunServer();
            web.RunWeb();

            this.Controls.Add (web.web);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }
    }
}