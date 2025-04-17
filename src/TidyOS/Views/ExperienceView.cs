using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Views;

namespace TidyOS.Views
{
    public partial class ExperienceView : UserControl
    {
        private FeatureCatalog experienceManager;
        private List<FeatureBase> allFeatures;
        private int selectedCategoryIndex = 0; //Store the index of the selected category

        public ExperienceView()
        {
            InitializeComponent();
            experienceManager = new FeatureCatalog();
            PopulateCategories();
            LoadFeatures("Start");
        }

        private void LoadFeatures(string category)
        {
            allFeatures = experienceManager.GetFeatures(category);
            UpdateFeatureList(allFeatures);
        }

        private void UpdateFeatureList(List<FeatureBase> features)
        {
            clbFeatures.Items.Clear();

            foreach (var feature in features)
            {
                var item = new FeatureListItem(feature);
                clbFeatures.Items.Add(item, feature.CheckFeature());
            }
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {
            string search = textSearch.Text.ToLower();

            var filtered = allFeatures
                .Where(f =>
                    f.ID().ToLower().Contains(search) ||
                    f.Info().ToLower().Contains(search))
                .ToList();

            UpdateFeatureList(filtered);
        }

        // Update the category label with the selected category's name
        private void UpdateCategoryLabel(int categoryIndex)
        {
            lblExperienceCategory.Text = experienceManager.GetCategories()[categoryIndex]; // Update label to show selected category
        }

        // Load the features of the selected category into the CheckedListBox
        private void LoadExperienceFeatures(int categoryIndex)
        {
            clbFeatures.Items.Clear();

            // Get features for the selected category
            var features = experienceManager.GetFeatures(experienceManager.GetCategories()[categoryIndex]);

            foreach (var feature in features)
            {
                var item = new FeatureListItem(feature);
                int index = clbFeatures.Items.Add(item);
                clbFeatures.SetItemChecked(index, feature.CheckFeature()); // Set checked state based on feature status
            }
        }

        // Populate categories into the FlowPanel with circular buttons
        private void PopulateCategories()
        {
            // Clear any previous category buttons
            flowPanelCategories.Controls.Clear();

            // Get the list of categories
            var categories = experienceManager.GetCategories();

            // Loop through categories to create buttons
            for (int i = 0; i < categories.Count; i++)
            {
                var btn = new Button
                {
                    Text = "●",  
                    Width = 25,
                    Height = 25,
                    FlatStyle = FlatStyle.Flat,
                    FlatAppearance = { BorderSize = 0 },
                    Tag = i  // Store the index for category selection
                };

                if (i == 0)
                {
                    btn.ForeColor = Color.Magenta; // Highlight the default (first) category
                }
                else
                {
                    btn.ForeColor = Color.Gray; // Standard color for other buttons
                }

                // Set the tooltip to show the category name
                tt.SetToolTip(btn, categories[i]);

                // Add the button's click event handler
                btn.Click += CategoryButton_Click;

                // Add the button to the FlowPanel
                flowPanelCategories.Controls.Add(btn);
            }

            // Initialize the first category by default
            selectedCategoryIndex = 0;
            UpdateCategoryLabel(0);
            LoadExperienceFeatures(0);  // Load features for the first category
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int categoryIndex = (int)clickedButton.Tag;

            // Update selected category index
            selectedCategoryIndex = categoryIndex;

            // Update the category label with the new category name
            UpdateCategoryLabel(categoryIndex);

            // Highlight the selected button
            HighlightSelectedCategoryButton(categoryIndex);

            // Load features of the selected category into the CheckedListBox
            LoadExperienceFeatures(categoryIndex);
        }

        // Highlight the button for the selected category
        private void HighlightSelectedCategoryButton(int selectedIndex)
        {
            for (int i = 0; i < flowPanelCategories.Controls.Count; i++)
            {
                if (flowPanelCategories.Controls[i] is Button btn)
                {
                    btn.ForeColor = (i == selectedIndex) ? Color.Magenta : Color.Gray;
                }
            }
        }

        private void clbFeatures_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (clbFeatures.Items[e.Index] is FeatureListItem item)
            {
                FeatureBase feature = item.Feature;
                bool enable = (e.NewValue == CheckState.Checked);

                bool success = enable ? feature.DoFeature() : feature.UndoFeature();

                if (!success)
                {
                    // MessageBox.Show("Action failed", "Fehler");
                    Logger.Log($"Failed to {(enable ? "enable" : "disable")} {feature.ID()}", LogLevel.Error);
                    // Reset the checkbox to its previous state
                    clbFeatures.SetItemCheckState(e.Index, e.CurrentValue); // old value
                }
                else
                {
                    Logger.Log($"{feature.ID()} {(enable ? "enabled" : "disabled")}", LogLevel.Info);
                }
            }
        }

        private void textSearch_Click(object sender, EventArgs e)
        {
            textSearch.Clear();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Get the features for the selected category
            var features = experienceManager.GetFeatures(experienceManager.GetCategories()[selectedCategoryIndex]);

            // Loop through all features and activate them
            foreach (var feature in features)
            {
                if (!feature.CheckFeature())
                {
                    feature.DoFeature();
                }
            }

            // Reload the features to update the UI
            LoadExperienceFeatures(selectedCategoryIndex);
        }

        private void btnRevert_Click(object sender, EventArgs e)
        {
            // Get the features for the selected category
            var features = experienceManager.GetFeatures(experienceManager.GetCategories()[selectedCategoryIndex]);

            // Loop through all features and deactivate them
            foreach (var feature in features)
            {
                if (feature.CheckFeature())
                {
                    feature.UndoFeature();
                }
            }

            // Reload the features to update the UI
            LoadExperienceFeatures(selectedCategoryIndex);
        }

        /// <summary>
        /// Handles the CheckedChanged event for switching between showing the feature ID and description.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbToggleDescription_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < clbFeatures.Items.Count; i++)
            {
                if (clbFeatures.Items[i] is FeatureListItem item)
                {
                    if (cbToggleDescription.Checked)
                    {
                        // Show the description when checked
                        clbFeatures.Items[i] = new FeatureListItem(item.Feature) { DisplayText = item.Feature.Info() };
                    }
                    else
                    {
                        // Show the ID when unchecked
                        clbFeatures.Items[i] = new FeatureListItem(item.Feature) { DisplayText = item.Feature.ID() };
                    }
                }
            }

            // Refresh the CheckedListBox to show the changes
            clbFeatures.Refresh();
        }
    }
}