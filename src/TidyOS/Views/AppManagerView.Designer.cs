namespace TidyOS.Views
{
    partial class AppManagerView
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.textFilter = new System.Windows.Forms.TextBox();
            this.checkedListBoxApps = new System.Windows.Forms.CheckedListBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnAppsFeed = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnShowAllInstalled = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeader.AutoEllipsis = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHeader.Location = new System.Drawing.Point(34, 14);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(317, 33);
            this.lblHeader.TabIndex = 332;
            this.lblHeader.Text = "These Start menu apps are unnecessary. Add or remove apps by entering names separ" +
    "ated by commas.";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textFilter
            // 
            this.textFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.textFilter.Font = new System.Drawing.Font("Segoe UI Variable Display", 9F);
            this.textFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.textFilter.Location = new System.Drawing.Point(37, 60);
            this.textFilter.Multiline = true;
            this.textFilter.Name = "textFilter";
            this.textFilter.Size = new System.Drawing.Size(491, 96);
            this.textFilter.TabIndex = 333;
            this.textFilter.TextChanged += new System.EventHandler(this.textFilter_TextChanged);
            // 
            // checkedListBoxApps
            // 
            this.checkedListBoxApps.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxApps.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.checkedListBoxApps.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxApps.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.75F);
            this.checkedListBoxApps.FormattingEnabled = true;
            this.checkedListBoxApps.Location = new System.Drawing.Point(37, 203);
            this.checkedListBoxApps.Name = "checkedListBoxApps";
            this.checkedListBoxApps.Size = new System.Drawing.Size(491, 380);
            this.checkedListBoxApps.Sorted = true;
            this.checkedListBoxApps.TabIndex = 335;
            this.checkedListBoxApps.ThreeDCheckBoxes = true;
            // 
            // lblResults
            // 
            this.lblResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblResults.AutoEllipsis = true;
            this.lblResults.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblResults.Location = new System.Drawing.Point(37, 168);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(274, 23);
            this.lblResults.TabIndex = 338;
            this.lblResults.Text = "Results";
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tt.SetToolTip(this.lblResults, "Detected bloatware on your system");
            this.lblResults.UseCompatibleTextRendering = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.AutoEllipsis = true;
            this.btnSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelect.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSelect.FlatAppearance.BorderSize = 0;
            this.btnSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold);
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(110)))));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSelect.Location = new System.Drawing.Point(294, 603);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(80, 26);
            this.btnSelect.TabIndex = 337;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseCompatibleTextRendering = true;
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.AutoEllipsis = true;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FlatAppearance.BorderSize = 2;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemove.Location = new System.Drawing.Point(386, 598);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(142, 35);
            this.btnRemove.TabIndex = 336;
            this.btnRemove.Text = "Remove selected";
            this.btnRemove.UseCompatibleTextRendering = true;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // btnAppsFeed
            // 
            this.btnAppsFeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAppsFeed.AutoEllipsis = true;
            this.btnAppsFeed.BackColor = System.Drawing.Color.Transparent;
            this.btnAppsFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAppsFeed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAppsFeed.FlatAppearance.BorderSize = 0;
            this.btnAppsFeed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnAppsFeed.Font = new System.Drawing.Font("Segoe UI Variable Display", 9.25F);
            this.btnAppsFeed.ForeColor = System.Drawing.Color.Black;
            this.btnAppsFeed.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAppsFeed.Location = new System.Drawing.Point(372, 19);
            this.btnAppsFeed.Name = "btnAppsFeed";
            this.btnAppsFeed.Size = new System.Drawing.Size(112, 28);
            this.btnAppsFeed.TabIndex = 343;
            this.btnAppsFeed.Text = "Add from feed...";
            this.tt.SetToolTip(this.btnAppsFeed, "Add from GitHub feed");
            this.btnAppsFeed.UseVisualStyleBackColor = false;
            this.btnAppsFeed.Click += new System.EventHandler(this.btnAppsFeed_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.AutoEllipsis = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.Black;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(490, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 28);
            this.btnRefresh.TabIndex = 344;
            this.btnRefresh.Text = "...";
            this.tt.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.btnAppsFeed);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(561, 54);
            this.panelHeader.TabIndex = 341;
            // 
            // btnShowAllInstalled
            // 
            this.btnShowAllInstalled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnShowAllInstalled.AutoEllipsis = true;
            this.btnShowAllInstalled.BackColor = System.Drawing.Color.Transparent;
            this.btnShowAllInstalled.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowAllInstalled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnShowAllInstalled.FlatAppearance.BorderSize = 0;
            this.btnShowAllInstalled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnShowAllInstalled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowAllInstalled.Font = new System.Drawing.Font("Segoe UI Variable Display", 10F, System.Drawing.FontStyle.Bold);
            this.btnShowAllInstalled.ForeColor = System.Drawing.Color.Black;
            this.btnShowAllInstalled.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnShowAllInstalled.Location = new System.Drawing.Point(31, 603);
            this.btnShowAllInstalled.Name = "btnShowAllInstalled";
            this.btnShowAllInstalled.Size = new System.Drawing.Size(133, 26);
            this.btnShowAllInstalled.TabIndex = 342;
            this.btnShowAllInstalled.Text = "Show all installed";
            this.btnShowAllInstalled.UseCompatibleTextRendering = true;
            this.btnShowAllInstalled.UseVisualStyleBackColor = false;
            this.btnShowAllInstalled.Click += new System.EventHandler(this.btnShowAllInstalled_Click);
            // 
            // AppManagerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnShowAllInstalled);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.checkedListBoxApps);
            this.Controls.Add(this.textFilter);
            this.Name = "AppManagerView";
            this.Size = new System.Drawing.Size(561, 645);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox textFilter;
        private System.Windows.Forms.CheckedListBox checkedListBoxApps;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnShowAllInstalled;
        private System.Windows.Forms.Button btnAppsFeed;
        private System.Windows.Forms.Button btnRefresh;
    }
}
