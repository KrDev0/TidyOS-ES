namespace TidyOS.Views
{
    partial class ExperienceView
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.lblExperienceCategory = new System.Windows.Forms.Label();
            this.flowPanelCategories = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRevert = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.clbFeatures = new System.Windows.Forms.CheckedListBox();
            this.cbToggleDescription = new System.Windows.Forms.CheckBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.AllowDrop = true;
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelHeader.Controls.Add(this.textSearch);
            this.panelHeader.Controls.Add(this.lblExperienceCategory);
            this.panelHeader.Controls.Add(this.flowPanelCategories);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(561, 108);
            this.panelHeader.TabIndex = 323;
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.Font = new System.Drawing.Font("Segoe UI Variable Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(168)))), ((int)(((byte)(173)))));
            this.textSearch.Location = new System.Drawing.Point(34, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(423, 27);
            this.textSearch.TabIndex = 2;
            this.textSearch.TabStop = false;
            this.textSearch.Text = "Type here to search";
            this.textSearch.Click += new System.EventHandler(this.textSearch_Click);
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            // 
            // lblExperienceCategory
            // 
            this.lblExperienceCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExperienceCategory.AutoEllipsis = true;
            this.lblExperienceCategory.Font = new System.Drawing.Font("Segoe UI Variable Text Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExperienceCategory.ForeColor = System.Drawing.Color.Black;
            this.lblExperienceCategory.Location = new System.Drawing.Point(34, 50);
            this.lblExperienceCategory.Name = "lblExperienceCategory";
            this.lblExperienceCategory.Size = new System.Drawing.Size(272, 23);
            this.lblExperienceCategory.TabIndex = 7;
            this.lblExperienceCategory.Text = "Start";
            this.lblExperienceCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExperienceCategory.UseCompatibleTextRendering = true;
            // 
            // flowPanelCategories
            // 
            this.flowPanelCategories.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.flowPanelCategories.AutoSize = true;
            this.flowPanelCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.flowPanelCategories.Font = new System.Drawing.Font("Segoe MDL2 Assets", 7.25F);
            this.flowPanelCategories.ForeColor = System.Drawing.Color.DarkGray;
            this.flowPanelCategories.Location = new System.Drawing.Point(177, 75);
            this.flowPanelCategories.Name = "flowPanelCategories";
            this.flowPanelCategories.Size = new System.Drawing.Size(190, 24);
            this.flowPanelCategories.TabIndex = 324;
            // 
            // btnRevert
            // 
            this.btnRevert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRevert.AutoEllipsis = true;
            this.btnRevert.BackColor = System.Drawing.Color.Transparent;
            this.btnRevert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevert.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevert.FlatAppearance.BorderSize = 0;
            this.btnRevert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnRevert.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRevert.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.btnRevert.ForeColor = System.Drawing.Color.Black;
            this.btnRevert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevert.Location = new System.Drawing.Point(259, 598);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(130, 32);
            this.btnRevert.TabIndex = 502;
            this.btnRevert.TabStop = false;
            this.btnRevert.Text = "Deactivate All";
            this.btnRevert.UseCompatibleTextRendering = true;
            this.btnRevert.UseVisualStyleBackColor = false;
            this.btnRevert.Click += new System.EventHandler(this.btnRevert_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.AutoEllipsis = true;
            this.btnApply.BackColor = System.Drawing.Color.Transparent;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnApply.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(395, 598);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(119, 32);
            this.btnApply.TabIndex = 500;
            this.btnApply.TabStop = false;
            this.btnApply.Text = "Activate All";
            this.btnApply.UseCompatibleTextRendering = true;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // tt
            // 
            this.tt.IsBalloon = true;
            // 
            // clbFeatures
            // 
            this.clbFeatures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbFeatures.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.clbFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFeatures.Font = new System.Drawing.Font("Segoe UI Variable Display", 11.25F);
            this.clbFeatures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.clbFeatures.FormattingEnabled = true;
            this.clbFeatures.Location = new System.Drawing.Point(48, 113);
            this.clbFeatures.Name = "clbFeatures";
            this.clbFeatures.Size = new System.Drawing.Size(477, 462);
            this.clbFeatures.TabIndex = 325;
            this.clbFeatures.UseCompatibleTextRendering = true;
            this.clbFeatures.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbFeatures_ItemCheck);
            // 
            // cbToggleDescription
            // 
            this.cbToggleDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbToggleDescription.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbToggleDescription.AutoEllipsis = true;
            this.cbToggleDescription.BackColor = System.Drawing.Color.Transparent;
            this.cbToggleDescription.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbToggleDescription.Font = new System.Drawing.Font("Segoe UI Variable Display", 10.25F);
            this.cbToggleDescription.ForeColor = System.Drawing.Color.Black;
            this.cbToggleDescription.Location = new System.Drawing.Point(34, 598);
            this.cbToggleDescription.Name = "cbToggleDescription";
            this.cbToggleDescription.Size = new System.Drawing.Size(159, 32);
            this.cbToggleDescription.TabIndex = 326;
            this.cbToggleDescription.TabStop = false;
            this.cbToggleDescription.Text = "Toggle Feature Insights";
            this.cbToggleDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbToggleDescription.UseCompatibleTextRendering = true;
            this.cbToggleDescription.UseVisualStyleBackColor = false;
            this.cbToggleDescription.CheckedChanged += new System.EventHandler(this.cbToggleDescription_CheckedChanged);
            // 
            // ExperienceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(247)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.cbToggleDescription);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.clbFeatures);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.panelHeader);
            this.Name = "ExperienceView";
            this.Size = new System.Drawing.Size(561, 645);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button btnRevert;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblExperienceCategory;
        private System.Windows.Forms.FlowLayoutPanel flowPanelCategories;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.CheckedListBox clbFeatures;
        private System.Windows.Forms.CheckBox cbToggleDescription;
    }
}
