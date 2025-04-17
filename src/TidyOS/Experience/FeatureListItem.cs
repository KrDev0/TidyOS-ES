using TidyOS;

public class FeatureListItem
{
    public FeatureBase Feature { get; }
    public string DisplayText { get; set; }  // Dynamic display text

    public FeatureListItem(FeatureBase feature)
    {
        Feature = feature;
        DisplayText = feature.ID();  // Default to feature ID
    }

    public override string ToString()
    {
        return DisplayText;  // Return the dynamic text based on the checkbox state
    }
}
