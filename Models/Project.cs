// ============================================================
// Project Model
// ============================================================
// This model represents a portfolio project.
// Each project has a title, description, image, and links.
// ============================================================

namespace Portfolio.Models
{
    public class Project
    {
        // Unique identifier for the project
        public int Id { get; set; }

        // Project title
        public string Title { get; set; } = string.Empty;

        // Short description of the project
        public string Description { get; set; } = string.Empty;

        // Path to project image/screenshot
        public string ImageUrl { get; set; } = string.Empty;

        // GitHub repository link
        public string GitHubUrl { get; set; } = string.Empty;

        // Live demo link (optional)
        public string? LiveUrl { get; set; }

        // Technologies used in the project
        public List<string> Technologies { get; set; } = new List<string>();

        // Constructor for easy creation
        public Project(int id, string title, string description, string imageUrl, string githubUrl, List<string> technologies, string? liveUrl = null)
        {
            Id = id;
            Title = title;
            Description = description;
            ImageUrl = imageUrl;
            GitHubUrl = githubUrl;
            Technologies = technologies;
            LiveUrl = liveUrl;
        }
    }
}
