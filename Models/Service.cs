// ============================================================
// Service Model
// ============================================================
// This model represents a freelance service offering.
// Used in the Services section of the portfolio.
// ============================================================

namespace Portfolio.Models
{
    public class Service
    {
        // Service title (e.g., "Web Development")
        public string Title { get; set; } = string.Empty;

        // Description of the service
        public string Description { get; set; } = string.Empty;

        // Icon class for visual representation
        public string IconClass { get; set; } = string.Empty;

        // Constructor for easy creation
        public Service(string title, string description, string iconClass)
        {
            Title = title;
            Description = description;
            IconClass = iconClass;
        }
    }
}
