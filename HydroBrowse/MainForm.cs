using System;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace HydroBrowse
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        ChromiumWebBrowser browser;

        private void MainForm_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser(AddressBar.Text)
            {
                Dock = DockStyle.Fill
            };
            PageContainer.Controls.Add(browser);
            browser.AddressChanged += Browser_AddressChanged;
        }

        private void Browser_AddressChanged(object sender, CefSharp.AddressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(() =>
            {
                AddressBar.Text = e.Address;
            }));
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void BtnForward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                browser.Forward();
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.Back();
            }
        }

        private void AddressBar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                browser.Load(AddressBar.Text);
            }
        }
    }
}
