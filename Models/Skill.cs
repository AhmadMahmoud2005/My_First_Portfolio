// ============================================================
// Skill Model
// ============================================================
// This model represents a single skill with its category.
// Used to organize skills into Backend, Frontend, and Tools.
// ============================================================

namespace Portfolio.Models
{
    public class Skill
    {
        // Name of the skill (e.g., "C#", "HTML")
        public string Name { get; set; } = string.Empty;

        // Category: "Backend", "Frontend", or "Tools"
        public string Category { get; set; } = string.Empty;

        // Proficiency level (0-100) for progress bars
        public int Proficiency { get; set; }

        // Icon class (Bootstrap Icons or custom icons)
        public string IconClass { get; set; } = string.Empty;

        // Constructor for easy creation
        public Skill(string name, string category, int proficiency, string iconClass)
        {
            Name = name;
            Category = category;
            Proficiency = proficiency;
            IconClass = iconClass;
        }
    }
}
