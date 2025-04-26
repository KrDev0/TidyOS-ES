namespace TidyOS.Views
{
    partial class AboutView
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
            this.lblAppname = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.assetAppSymbol = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpenLog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.assetAppSymbol)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAppname
            // 
            this.lblAppname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblAppname.AutoEllipsis = true;
            this.lblAppname.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppname.ForeColor = System.Drawing.Color.Black;
            this.lblAppname.Location = new System.Drawing.Point(89, 241);
            this.lblAppname.Name = "lblAppname";
            this.lblAppname.Size = new System.Drawing.Size(398, 26);
            this.lblAppname.TabIndex = 320;
            this.lblAppname.Text = "App";
            this.lblAppname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppname.UseCompatibleTextRendering = true;
            // 
            // lblCopyright
            // 
            this.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Segoe UI Variable Text", 9.5F);
            this.lblCopyright.ForeColor = System.Drawing.Color.Black;
            this.lblCopyright.Location = new System.Drawing.Point(30, 94);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(351, 21);
            this.lblCopyright.TabIndex = 319;
            this.lblCopyright.Text = "Publisher: (C) 2025 A Belim app creation";
            this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCopyright.UseCompatibleTextRendering = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdate.AutoEllipsis = true;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(336, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 33);
            this.btnUpdate.TabIndex = 318;
            this.btnUpdate.TabStop = false;
            this.btnUpdate.Text = "Check Now";
            this.btnUpdate.UseCompatibleTextRendering = true;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGitHub.AutoEllipsis = true;
            this.btnGitHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(27)))), ((int)(((byte)(26)))));
            this.btnGitHub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGitHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGitHub.FlatAppearance.BorderSize = 0;
            this.btnGitHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btnGitHub.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGitHub.ForeColor = System.Drawing.Color.White;
            this.btnGitHub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGitHub.Location = new System.Drawing.Point(10, 148);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(388, 33);
            this.btnGitHub.TabIndex = 317;
            this.btnGitHub.TabStop = false;
            this.btnGitHub.Text = "GitHub";
            this.btnGitHub.UseVisualStyleBackColor = false;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAppVersion.AutoEllipsis = true;
            this.lblAppVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblAppVersion.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblAppVersion.ForeColor = System.Drawing.Color.Black;
            this.lblAppVersion.Location = new System.Drawing.Point(30, 64);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(351, 23);
            this.lblAppVersion.TabIndex = 315;
            this.lblAppVersion.Text = "Version ";
            this.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAppVersion.UseCompatibleTextRendering = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.panel1.Controls.Add(this.assetAppSymbol);
            this.panel1.Controls.Add(this.lblCopyright);
            this.panel1.Controls.Add(this.lblAppVersion);
            this.panel1.Controls.Add(this.btnGitHub);
            this.panel1.Location = new System.Drawing.Point(79, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 203);
            this.panel1.TabIndex = 321;
            // 
            // assetAppSymbol
            // 
            this.assetAppSymbol.Image = global::TidyOS.Properties.Resources.AppIcon24;
            this.assetAppSymbol.Location = new System.Drawing.Point(195, 15);
            this.assetAppSymbol.Name = "assetAppSymbol";
            this.assetAppSymbol.Size = new System.Drawing.Size(31, 29);
            this.assetAppSymbol.TabIndex = 329;
            this.assetAppSymbol.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(89, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 322;
            this.label1.Text = "Updates";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(89, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 323;
            this.label2.Text = "Logs";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // btnOpenLog
            // 
            this.btnOpenLog.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOpenLog.AutoEllipsis = true;
            this.btnOpenLog.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOpenLog.FlatAppearance.BorderSize = 0;
            this.btnOpenLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnOpenLog.Font = new System.Drawing.Font("Segoe UI Variable Display Semib", 11F, System.Drawing.FontStyle.Bold);
            this.btnOpenLog.ForeColor = System.Drawing.Color.Black;
            this.btnOpenLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenLog.Location = new System.Drawing.Point(336, 349);
            this.btnOpenLog.Name = "btnOpenLog";
            this.btnOpenLog.Size = new System.Drawing.Size(154, 33);
            this.btnOpenLog.TabIndex = 324;
            this.btnOpenLog.TabStop = false;
            this.btnOpenLog.Text = "Open Log";
            this.btnOpenLog.UseCompatibleTextRendering = true;
            this.btnOpenLog.UseVisualStyleBackColor = false;
            this.btnOpenLog.Click += new System.EventHandler(this.btnOpenLog_Click);
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.btnOpenLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAppname);
            this.Controls.Add(this.panel1);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(561, 645);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.assetAppSymbol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAppname;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnGitHub;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpenLog;
        private System.Windows.Forms.PictureBox assetAppSymbol;
    }
}
