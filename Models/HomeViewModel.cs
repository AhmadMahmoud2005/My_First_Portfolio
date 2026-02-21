// ============================================================
// Home ViewModel
// ============================================================
// This ViewModel combines all data needed for the Home page.
// It passes skills, projects, services, and contact form to the view.
// ============================================================

namespace Portfolio.Models
{
    public class HomeViewModel
    {
        // Personal Information
        public string Name { get; set; } = "Ahmad Mahmoud";
        public string Title { get; set; } = ".NET Full Stack Developer (Trainee)";
        public string AboutText { get; set; } = string.Empty;
        public string ProfileImageUrl { get; set; } = "/images/profile.jpg";
        public string CvUrl { get; set; } = "https://github.com/AhmadMahmoud2005/AhmadMahmoud2005/blob/main/Ahmad-Mahmoud-CV.pdf";
        
        // Social Links
        public string GitHubUrl { get; set; } = "https://github.com/AhmadMahmoud2005";
        public string LinkedInUrl { get; set; } = "https://www.linkedin.com/in/ahmad-mahmoud-medhat";
        public string Email { get; set; } = "ahmad.mahmoud.medhat@gmail.com";

        // Collections for different sections
        public List<Skill> Skills { get; set; } = new List<Skill>();
        public List<Project> Projects { get; set; } = new List<Project>();
        public List<Service> Services { get; set; } = new List<Service>();
        public ContactForm ContactForm { get; set; } = new ContactForm();

        // About section bullet points
        public List<string> AboutPoints { get; set; } = new List<string>();

        // Constructor - Initialize with sample data
        public HomeViewModel()
        {
            InitializeSkills();
            InitializeProjects();
            InitializeServices();
            InitializeAboutData();
        }

        // Initialize Skills data
        private void InitializeSkills()
        {
            // Backend Skills
            Skills.Add(new Skill("C#", "Backend", 85, "bi bi-code-square"));
            Skills.Add(new Skill("ASP.NET Core", "Backend", 80, "bi bi-server"));
            Skills.Add(new Skill("Entity Framework", "Backend", 75, "bi bi-database"));

            // Frontend Skills
            Skills.Add(new Skill("HTML", "Frontend", 90, "bi bi-filetype-html"));
            Skills.Add(new Skill("CSS", "Frontend", 85, "bi bi-filetype-css"));
            Skills.Add(new Skill("JavaScript", "Frontend", 75, "bi bi-filetype-js"));

            // Tools
            Skills.Add(new Skill("Git", "Tools", 80, "bi bi-git"));
            Skills.Add(new Skill("SQL Server", "Tools", 75, "bi bi-database-fill"));
            Skills.Add(new Skill("REST APIs", "Tools", 70, "bi bi-arrow-left-right"));
        }

        // Initialize Projects data (placeholders)
        private void InitializeProjects()
        {
            Projects.Add(new Project(
                1,
                "E-Commerce Application",
                "A full-stack e-commerce web application built with ASP.NET Core MVC, featuring product catalog, shopping cart, and user authentication.",
                "/images/project1.jpg",
                "https://github.com/AhmadMahmoud2005",
                new List<string> { "ASP.NET Core", "Entity Framework", "SQL Server", "Bootstrap" }
            ));

            Projects.Add(new Project(
                2,
                "Task Management System",
                "A task management web application that allows users to create, organize, and track their daily tasks and projects.",
                "/images/project2.jpg",
                "https://github.com/AhmadMahmoud2005",
                new List<string> { "C#", "ASP.NET Core", "JavaScript", "CSS" }
            ));

            Projects.Add(new Project(
                3,
                "Portfolio Website",
                "A responsive personal portfolio website built with ASP.NET Core to showcase skills and projects.",
                "/images/project3.jpg",
                "https://github.com/AhmadMahmoud2005",
                new List<string> { "HTML", "CSS", "JavaScript", "Bootstrap" }
            ));

            Projects.Add(new Project(
                4,
                "API Development Project",
                "RESTful API built with ASP.NET Core Web API for managing resources with CRUD operations.",
                "/images/project4.jpg",
                "https://github.com/AhmadMahmoud2005",
                new List<string> { "ASP.NET Core Web API", "Entity Framework", "SQL Server" }
            ));
        }

        // Initialize Services data
        private void InitializeServices()
        {
            Services.Add(new Service(
                "Web Development",
                "Building responsive and modern websites using ASP.NET Core, HTML, CSS, and JavaScript.",
                "bi bi-laptop"
            ));

            Services.Add(new Service(
                "API Development",
                "Creating RESTful APIs with ASP.NET Core Web API for seamless data communication.",
                "bi bi-arrow-left-right"
            ));

            Services.Add(new Service(
                "Database Design",
                "Designing and implementing efficient database structures using SQL Server and Entity Framework.",
                "bi bi-database"
            ));

            Services.Add(new Service(
                "Bug Fixing",
                "Debugging and fixing issues in existing applications to improve performance and stability.",
                "bi bi-bug"
            ));
        }

        // Initialize About section data
        private void InitializeAboutData()
        {
            AboutText = "I am a passionate .NET Full Stack Developer trainee with a strong foundation in web development. Currently undergoing intensive training at DEPI, I am dedicated to building scalable and efficient web applications. I enjoy learning new technologies and solving complex problems through clean and maintainable code.";

            AboutPoints = new List<string>
            {
                "Education: Bachelor's degree in Computer Science / Related field",
                "Training: DEPI Full Stack .NET Program",
                "Interests: Web Development, Problem Solving, Learning New Technologies"
            };
        }
    }
}
