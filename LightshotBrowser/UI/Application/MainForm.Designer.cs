
namespace LightshotBrowser
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cBorderedForm1 = new Refract.UI.Core.Controls.CBorderedForm();
            this.GotoButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.urlText = new SMC.UI.Core.Controls.CThemedTextbox();
            this.TableContents = new System.Windows.Forms.TableLayoutPanel();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.cBorderedForm1.ControlContents.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBorderedForm1
            // 
            this.cBorderedForm1.BackColor = System.Drawing.Color.DodgerBlue;
            // 
            // cBorderedForm1.ControlContents
            // 
            this.cBorderedForm1.ControlContents.Controls.Add(this.RefreshBtn);
            this.cBorderedForm1.ControlContents.Controls.Add(this.PrevButton);
            this.cBorderedForm1.ControlContents.Controls.Add(this.NextButton);
            this.cBorderedForm1.ControlContents.Controls.Add(this.GotoButton);
            this.cBorderedForm1.ControlContents.Controls.Add(this.panel1);
            this.cBorderedForm1.ControlContents.Controls.Add(this.urlText);
            this.cBorderedForm1.ControlContents.Controls.Add(this.TableContents);
            this.cBorderedForm1.ControlContents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBorderedForm1.ControlContents.Enabled = true;
            this.cBorderedForm1.ControlContents.Location = new System.Drawing.Point(0, 32);
            this.cBorderedForm1.ControlContents.Name = "ControlContents";
            this.cBorderedForm1.ControlContents.Size = new System.Drawing.Size(1496, 864);
            this.cBorderedForm1.ControlContents.TabIndex = 1;
            this.cBorderedForm1.ControlContents.Visible = true;
            this.cBorderedForm1.ControlContents.Paint += new System.Windows.Forms.PaintEventHandler(this.cBorderedForm1_ControlContents_Paint);
            this.cBorderedForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cBorderedForm1.Location = new System.Drawing.Point(0, 0);
            this.cBorderedForm1.Name = "cBorderedForm1";
            this.cBorderedForm1.Size = new System.Drawing.Size(1500, 900);
            this.cBorderedForm1.TabIndex = 0;
            this.cBorderedForm1.TitleBarTitle = "Title";
            this.cBorderedForm1.UseTitleBar = true;
            // 
            // GotoButton
            // 
            this.GotoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GotoButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GotoButton.Location = new System.Drawing.Point(1419, 837);
            this.GotoButton.Name = "GotoButton";
            this.GotoButton.Size = new System.Drawing.Size(75, 25);
            this.GotoButton.TabIndex = 3;
            this.GotoButton.Text = "Load URL";
            this.GotoButton.UseVisualStyleBackColor = true;
            this.GotoButton.Click += new System.EventHandler(this.GotoButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(0, 834);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1500, 1);
            this.panel1.TabIndex = 2;
            // 
            // urlText
            // 
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.BorderColor = System.Drawing.Color.Red;
            this.urlText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.Location = new System.Drawing.Point(1247, 837);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(170, 25);
            this.urlText.TabIndex = 1;
            this.urlText.Text = "https://prnt.sc/i6eob2";
            // 
            // TableContents
            // 
            this.TableContents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableContents.ColumnCount = 4;
            this.TableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableContents.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TableContents.Location = new System.Drawing.Point(0, 0);
            this.TableContents.Name = "TableContents";
            this.TableContents.RowCount = 3;
            this.TableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableContents.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TableContents.Size = new System.Drawing.Size(1495, 835);
            this.TableContents.TabIndex = 0;
            // 
            // NextButton
            // 
            this.NextButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NextButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(786, 837);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 25);
            this.NextButton.TabIndex = 4;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PrevButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PrevButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrevButton.Location = new System.Drawing.Point(632, 837);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(75, 25);
            this.PrevButton.TabIndex = 5;
            this.PrevButton.Text = "Previous";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(709, 837);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 25);
            this.RefreshBtn.TabIndex = 6;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.cBorderedForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Lightshot browser";
            this.cBorderedForm1.ControlContents.ResumeLayout(false);
            this.cBorderedForm1.ControlContents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Refract.UI.Core.Controls.CBorderedForm cBorderedForm1;
        private System.Windows.Forms.TableLayoutPanel TableContents;
        private SMC.UI.Core.Controls.CThemedTextbox urlText;
        private System.Windows.Forms.Button GotoButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button RefreshBtn;
    }
}

