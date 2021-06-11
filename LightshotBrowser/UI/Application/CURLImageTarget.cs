using Refract.UI.Core.Interfaces;
using Refract.UI.Core.Singletons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace LightshotBrowser.UI.Application
{
    public partial class CURLImageTarget : UserControl, IThemeableControl
    {
        private delegate void BoxUpdater(string text);
        private BoxUpdater UpdateBox;
        private BoxUpdater DelayUpdate;
        private string CurrentSelectedUrl = null;
        private string WantedURL = null;
        private int WantedDelay = 0;
        private int invokeId = 0;

        public CURLImageTarget Next;
        public CURLImageTarget()
        {
            InitializeComponent();
            webBrowser1.Visible = false;
            PictureContent.Visible = false;
            PictureContent.Cursor = Cursors.Hand;
            PictureContent.Click += PictureContent_Click;
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
            UIThemeManager.OnThemeChanged(this, (theme) => { BackColor = theme.BackColor; });
            UpdateBox = (s) =>
            {
                CurrentSelectedUrl = s;
                try
                {
                    webBrowser1.Visible = false;
                    PictureContent.Visible = true;
                    PictureContent.SizeMode = PictureBoxSizeMode.Zoom;
                    PictureContent.LoadAsync(s);
                }
                catch
                {
                    PictureContent.Image = PictureContent.ErrorImage;
                }
            };

            DelayUpdate = (url) =>
            {
                try
                {
                    webBrowser1.Visible = true;
                    webBrowser1.Navigate(new Uri(url));
                }
                catch { }
            };
        }

        private void PictureContent_Click(object sender, EventArgs e)
        {
            if(CurrentSelectedUrl != null && CurrentSelectedUrl.StartsWith("https://"))
            {
                Process.Start(CurrentSelectedUrl);
            }
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Document.Body.MouseDown += Body_MouseDown;
            foreach (HtmlElement image in webBrowser1.Document.GetElementsByTagName("img").OfType<HtmlElement>())
            {
                if (image.Id == "screenshot-image")
                {
                    UpdateBox?.Invoke(image.GetAttribute("src"));
                    Next?.Load();
                    break;
                }
            }
        }

        private void Body_MouseDown(object sender, HtmlElementEventArgs e)
        {
            SetImageTarget(WantedURL, 0);
        }

        public IEnumerable<Control> GetThemedControls()
        {
            yield break;
        }

        public void SetImageTarget(string url, int delay)
        {
            WantedURL = url;
            WantedDelay = delay;
            webBrowser1.Visible = false;
            PictureContent.Visible = false;            
        }

        public void Load()
        {
            invokeId++;
            var cached = invokeId;
            new Task(() =>
            {
                System.Threading.Thread.Sleep(WantedDelay);
                if (invokeId == cached)
                {
                    Invoke(DelayUpdate, WantedURL);
                }
            }).Start();
        }
    }
}
