using System.Linq;

namespace TidyOS
{
    public abstract class FeatureBase
    {
        public abstract string ID();

        public abstract string Info();

        public abstract bool CheckFeature();

        public abstract bool DoFeature();

        public abstract bool UndoFeature();

        public abstract string GetRegistryKey();

        public string GetCategory()
        {
            // Extracts the category from the namespace (e.g., "Ads" from "Settings.Ads")
            return GetType().Namespace?.Split('.').Last() ?? "Unknown";
        }
    }
}