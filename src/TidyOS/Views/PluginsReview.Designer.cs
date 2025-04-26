namespace TidyOS.Views
{
    partial class PluginsReview
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblHeader = new System.Windows.Forms.Label();
            this.btnViewScript = new System.Windows.Forms.Button();
            this.textSummary = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(34, 22);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(489, 29);
            this.lblHeader.TabIndex = 263;
            this.lblHeader.Text = "Review your selections";
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // btnViewScript
            // 
            this.btnViewScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewScript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnViewScript.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnViewScript.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnViewScript.Font = new System.Drawing.Font("Segoe UI Variable Display", 8.5F);
            this.btnViewScript.ForeColor = System.Drawing.Color.White;
            this.btnViewScript.Location = new System.Drawing.Point(408, 532);
            this.btnViewScript.Margin = new System.Windows.Forms.Padding(4);
            this.btnViewScript.Name = "btnViewScript";
            this.btnViewScript.Size = new System.Drawing.Size(115, 27);
            this.btnViewScript.TabIndex = 264;
            this.btnViewScript.TabStop = false;
            this.btnViewScript.Text = "View script";
            this.btnViewScript.UseCompatibleTextRendering = true;
            this.btnViewScript.UseVisualStyleBackColor = false;
            this.btnViewScript.Click += new System.EventHandler(this.btnViewScript_Click);
            // 
            // textSummary
            // 
            this.textSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textSummary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textSummary.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.textSummary.ForeColor = System.Drawing.Color.Black;
            this.textSummary.Location = new System.Drawing.Point(33, 91);
            this.textSummary.Margin = new System.Windows.Forms.Padding(4);
            this.textSummary.Multiline = true;
            this.textSummary.Name = "textSummary";
            this.textSummary.ReadOnly = true;
            this.textSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textSummary.Size = new System.Drawing.Size(494, 433);
            this.textSummary.TabIndex = 262;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRun.AutoEllipsis = true;
            this.btnRun.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRun.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRun.FlatAppearance.BorderSize = 2;
            this.btnRun.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRun.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnRun.ForeColor = System.Drawing.Color.Black;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(408, 598);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(115, 31);
            this.btnRun.TabIndex = 261;
            this.btnRun.Text = "Run";
            this.btnRun.UseCompatibleTextRendering = true;
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(561, 71);
            this.panelHeader.TabIndex = 324;
            // 
            // PluginsReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnViewScript);
            this.Controls.Add(this.textSummary);
            this.Controls.Add(this.btnRun);
            this.Name = "PluginsReview";
            this.Size = new System.Drawing.Size(561, 645);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Button btnViewScript;
        private System.Windows.Forms.TextBox textSummary;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Panel panelHeader;
    }
}
