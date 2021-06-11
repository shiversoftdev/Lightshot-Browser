using LightshotBrowser.UI.Application;
using Refract.UI.Core.Interfaces;
using Refract.UI.Core.Singletons;
using SMC.UI.Core.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightshotBrowser
{
    public partial class MainForm : Form, IThemeableControl
    {
        public static int RequestId { get; private set; }
        private string CurrentTarget = "";
        private const string Charset = "0123456789abcdefghijklmnopqrstuvwxyz";
        private List<CURLImageTarget> ImageTargets = new List<CURLImageTarget>();
        public MainForm()
        {
            InitializeComponent();
            UIThemeManager.OnThemeChanged(this, OnThemeChanged_Implementation);
            this.SetThemeAware();
            MaximizeBox = true;
            MinimizeBox = true;
            cBorderedForm1.TitleBarTitle = "Serious' Lightshot Browser";

            CURLImageTarget prev = null;
            // populate image targets
            for (int r = 0; r < TableContents.RowCount; r++)
            {
                for(int c = 0; c < TableContents.ColumnCount; c++)
                {
                    CURLImageTarget target = new CURLImageTarget();
                    if(prev != null)
                    {
                        prev.Next = target;
                    }
                    prev = target;
                    target.Dock = DockStyle.Fill;
                    TableContents.Controls.Add(target, c, r);
                    ImageTargets.Add(target);
                }
            }
        }

        public IEnumerable<Control> GetThemedControls()
        {
            yield return GotoButton;
            yield return urlText;
            yield return PrevButton;
            yield return NextButton;
            yield return RefreshBtn;
        }

        private void OnThemeChanged_Implementation(UIThemeInfo currentTheme)
        {

        }

        private void cBorderedForm1_ControlContents_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GotoButton_Click(object sender, EventArgs e)
        {
            urlText.Text = urlText.Text.ToLower();
            if (!urlText.Text.StartsWith("https://prnt.sc/"))
            {
                new CErrorDialog("Invalid URL", "URL must start with https://prnt.sc/").ShowDialog();
                return;
            }
            var target = urlText.Text.Substring("https://prnt.sc/".Length);
            if(!ValidateURLTarget(target))
            {
                new CErrorDialog("Invalid URL", "URL has an invalid target").ShowDialog();
                return;
            }
            CurrentTarget = target;
            LoadNewImageTarget();
        }

        private void LoadNewImageTarget()
        {
            urlText.Text = $"https://prnt.sc/{CurrentTarget}";
            RequestId++;
            var index = 0;
            foreach(var target in ImageTargets)
            {
                target.SetImageTarget($"https://prnt.sc/{OffsetCurrentTarget(index++)}", 0);
            }
            ImageTargets[0].Load();
        }

        private string OffsetCurrentTarget(int offset)
        {
            ulong curr = NumFromTarget(CurrentTarget);
            if(offset < 0)
            {
                uint _offset = (uint)Math.Abs(offset);
                if (_offset > curr)
                {
                    curr = 0;
                }
                else
                {
                    curr -= _offset;
                }
            }
            else
            {
                curr += (uint)offset;
            }

            return TargetFromNum(curr, (uint)CurrentTarget.Length - 1);
        }

        private ulong NumFromTarget(string target)
        {
            ulong result = 0;
            uint power = 0;
            for(int i = target.Length - 1; i > -1; i--, power++)
            {
                result += (ulong)Math.Pow(Charset.Length, power) * (uint)Charset.IndexOf(target[i]);
            }
            return result;
        }

        private string TargetFromNum(ulong num, uint power)
        {
            string result = "";
            while(true)
            {
                ulong curr = (ulong)Math.Pow(Charset.Length, power);
                uint divresult = (uint)(num / curr);
                result += Charset[(int)divresult];
                num -= divresult * curr;
                if (power == 0)
                {
                    break;
                }
                power--;
            }
            return result;
        }

        private void NextPage()
        {
            if (CurrentTarget == "") return;
            CurrentTarget = OffsetCurrentTarget(ImageTargets.Count);
            LoadNewImageTarget();
        }

        private void PreviousPage()
        {
            if (CurrentTarget == "") return;
            CurrentTarget = OffsetCurrentTarget(ImageTargets.Count * -1);
            LoadNewImageTarget();
        }

        private bool ValidateURLTarget(string target)
        {
            if (target.Length > 8)
            {
                return false;
            }
            if(target.Length < 2)
            {
                return false;
            }
            foreach(char c in target)
            {
                if(!char.IsLetterOrDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            PreviousPage();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            NextPage();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            if (CurrentTarget == "") return;
            LoadNewImageTarget();
        }
    }
}
