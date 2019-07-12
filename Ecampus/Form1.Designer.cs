using System.Windows.Forms;

namespace Ecampus
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ecampus = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // ecampus
            // 
            this.ecampus.AllowWebBrowserDrop = false;
            this.ecampus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ecampus.Location = new System.Drawing.Point(0, 0);
            this.ecampus.MinimumSize = new System.Drawing.Size(20, 20);
            this.ecampus.Name = "ecampus";
            this.ecampus.ScriptErrorsSuppressed = true;
            this.ecampus.Size = new System.Drawing.Size(1350, 403);
            this.ecampus.TabIndex = 0;
            this.ecampus.Url = new System.Uri("http://ecampus.pelitabangsa.ac.id", System.UriKind.Absolute);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1350, 403);
            this.Controls.Add(this.ecampus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Ecampus Pelitabangsa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private WebBrowser ecampus;
    }
}

