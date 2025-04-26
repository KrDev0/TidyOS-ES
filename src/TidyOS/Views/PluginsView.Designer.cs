namespace TidyOS.Views
{
    partial class PluginsView
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
            this.treePlugins = new System.Windows.Forms.TreeView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnPluginsDir = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.panelContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // treePlugins
            // 
            this.treePlugins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treePlugins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.treePlugins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treePlugins.CheckBoxes = true;
            this.treePlugins.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.treePlugins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.treePlugins.FullRowSelect = true;
            this.treePlugins.HotTracking = true;
            this.treePlugins.ItemHeight = 22;
            this.treePlugins.Location = new System.Drawing.Point(48, 89);
            this.treePlugins.Margin = new System.Windows.Forms.Padding(4);
            this.treePlugins.Name = "treePlugins";
            this.treePlugins.ShowLines = false;
            this.treePlugins.ShowNodeToolTips = true;
            this.treePlugins.ShowPlusMinus = false;
            this.treePlugins.Size = new System.Drawing.Size(477, 488);
            this.treePlugins.TabIndex = 256;
            this.treePlugins.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treePlugins_AfterCheck);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(79)))), ((int)(((byte)(203)))));
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.5F);
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(408, 598);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(115, 31);
            this.btnNext.TabIndex = 320;
            this.btnNext.TabStop = false;
            this.btnNext.Text = "Next";
            this.btnNext.UseCompatibleTextRendering = true;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.BackColor = System.Drawing.Color.Transparent;
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnImport.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.5F);
            this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnImport.Location = new System.Drawing.Point(349, 19);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(93, 30);
            this.btnImport.TabIndex = 325;
            this.btnImport.Text = "Import";
            this.tt.SetToolTip(this.btnImport, "Import from folder");
            this.btnImport.UseCompatibleTextRendering = true;
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnPluginsDir
            // 
            this.btnPluginsDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPluginsDir.BackColor = System.Drawing.Color.Transparent;
            this.btnPluginsDir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPluginsDir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnPluginsDir.FlatAppearance.BorderSize = 0;
            this.btnPluginsDir.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPluginsDir.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnPluginsDir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnPluginsDir.Location = new System.Drawing.Point(448, 19);
            this.btnPluginsDir.Name = "btnPluginsDir";
            this.btnPluginsDir.Size = new System.Drawing.Size(36, 30);
            this.btnPluginsDir.TabIndex = 324;
            this.btnPluginsDir.TabStop = false;
            this.btnPluginsDir.Text = "...";
            this.tt.SetToolTip(this.btnPluginsDir, "Open plugins folder");
            this.btnPluginsDir.UseMnemonic = false;
            this.btnPluginsDir.UseVisualStyleBackColor = false;
            this.btnPluginsDir.Click += new System.EventHandler(this.btnPluginsDir_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(241)))), ((int)(((byte)(249)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe MDL2 Assets", 12F);
            this.btnRefresh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.btnRefresh.Location = new System.Drawing.Point(490, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 30);
            this.btnRefresh.TabIndex = 323;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.Text = "...";
            this.tt.SetToolTip(this.btnRefresh, "Refresh");
            this.btnRefresh.UseMnemonic = false;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.panelContainer.Controls.Add(this.treePlugins);
            this.panelContainer.Controls.Add(this.panelHeader);
            this.panelContainer.Controls.Add(this.btnNext);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(561, 645);
            this.panelContainer.TabIndex = 328;
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Controls.Add(this.btnRefresh);
            this.panelHeader.Controls.Add(this.btnPluginsDir);
            this.panelHeader.Controls.Add(this.btnImport);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(561, 71);
            this.panelHeader.TabIndex = 326;
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
            this.lblHeader.Size = new System.Drawing.Size(306, 39);
            this.lblHeader.TabIndex = 326;
            this.lblHeader.Text = "Plugins";
            this.lblHeader.UseCompatibleTextRendering = true;
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // PluginsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContainer);
            this.Name = "PluginsView";
            this.Size = new System.Drawing.Size(561, 645);
            this.Load += new System.EventHandler(this.PluginsView_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treePlugins;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnImport;
        public System.Windows.Forms.Button btnPluginsDir;
        public System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolTip tt;
    }
}
