
namespace LightshotBrowser.UI.Application
{
    partial class CURLImageTarget
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureContent = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.PictureContent)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureContent
            // 
            this.PictureContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureContent.Location = new System.Drawing.Point(0, 0);
            this.PictureContent.Name = "PictureContent";
            this.PictureContent.Size = new System.Drawing.Size(150, 150);
            this.PictureContent.TabIndex = 0;
            this.PictureContent.TabStop = false;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(150, 150);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // CURLImageTarget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.PictureContent);
            this.Name = "CURLImageTarget";
            ((System.ComponentModel.ISupportInitialize)(this.PictureContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureContent;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
