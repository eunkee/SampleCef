using CefSharp;
using CefSharp.WinForms;
using System;
using System.Windows.Forms;

namespace TestGoogleAPIMAp
{
    public partial class Form1 : Form
    {
        public ChromiumWebBrowser browser;
        private string apiKey = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestUrl();
        }

        private void TestUrl()
        {
            string url = $"https://www.google.com/maps/search/?api=1&key={apiKey}&query=47.5951518%2C-122.3316393&map_action=map";
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser("");
            this.panel1.Controls.Add(browser);    // panel에 크롬 browser 컨트롤 추가
            browser.Dock = DockStyle.Fill;
            browser.Load(url);
        }
    }
}
