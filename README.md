# Portfolio Website - ASP.NET Core MVC

A clean, professional, and responsive portfolio website built with **ASP.NET Core MVC** and **Bootstrap 5**. Features dark mode by default with a toggle to switch to light mode.

![Portfolio Preview](https://img.shields.io/badge/ASP.NET%20Core-10.0-purple)
![Bootstrap](https://img.shields.io/badge/Bootstrap-5.3-blue)
![License](https://img.shields.io/badge/License-MIT-green)

---

## Features

- **Modern & Clean Design** - Minimal, professional developer portfolio look
- **Dark Mode by Default** - Easy on the eyes with light mode toggle
- **Fully Responsive** - Works perfectly on mobile, tablet, and desktop
- **Smooth Scrolling** - Elegant navigation between sections
- **Form Validation** - Client-side validation for the contact form
- **Beginner-Friendly Code** - Well-commented and easy to customize

---

## Project Structure

```
Portfolio/
├── Controllers/
│   └── HomeController.cs       # Main controller with all actions
├── Models/
│   ├── ContactForm.cs          # Contact form model with validation
│   ├── HomeViewModel.cs        # Main view model with all data
│   ├── Project.cs              # Project model
│   ├── Service.cs              # Service model
│   └── Skill.cs                # Skill model
├── Views/
│   ├── Home/
│   │   └── Index.cshtml        # Main portfolio page (all sections)
│   ├── Shared/
│   │   ├── _Layout.cshtml      # Master page template
│   │   └── _ValidationScriptsPartial.cshtml
│   ├── _ViewImports.cshtml     # Common using statements
│   └── _ViewStart.cshtml       # Default layout setting
├── wwwroot/
│   ├── css/
│   │   └── site.css            # Main stylesheet with dark/light modes
│   ├── js/
│   │   └── site.js             # JavaScript for theme toggle & scrolling
│   └── images/                 # Place your images here
├── appsettings.json            # App configuration
├── Program.cs                  # App entry point
└── Portfolio.csproj            # Project file
```

---

## Prerequisites

Before running this project, make sure you have:

- [.NET 10.0 SDK](https://dotnet.microsoft.com/download/dotnet/10.0) or later
- Any code editor (Visual Studio, VS Code, or Rider)

---

## How to Run Locally

### Option 1: Using Command Line

1. **Clone or download** this repository

2. **Navigate to the project folder**:
   ```bash
   cd Portfolio
   ```

3. **Restore NuGet packages**:
   ```bash
   dotnet restore
   ```

4. **Run the application**:
   ```bash
   dotnet run
   ```

5. **Open your browser** and navigate to:
   - HTTP: `http://localhost:5000`
   - HTTPS: `https://localhost:7000`

### Option 2: Using Visual Studio

1. **Open** the `Portfolio.sln` file (or create one)
2. **Press F5** or click the "Run" button
3. The website will open automatically in your default browser

### Option 3: Using VS Code

1. **Open** the project folder in VS Code
2. **Open terminal** (Ctrl + `)
3. **Run**:
   ```bash
   dotnet run
   ```

---

## Customization Guide

### 1. Update Personal Information

Open `Models/HomeViewModel.cs` and update:

```csharp
public string Name { get; set; } = "Your Name";
public string Title { get; set; } = "Your Title";
public string Email { get; set; } = "your.email@example.com";
public string GitHubUrl { get; set; } = "https://github.com/yourusername";
public string LinkedInUrl { get; set; } = "https://linkedin.com/in/yourprofile";
public string CvUrl { get; set; } = "https://your-cv-link.pdf";
```

### 2. Add Your Profile Picture

1. Place your image in `wwwroot/images/`
2. Rename it to `profile.jpg` (or update the path in `HomeViewModel.cs`)
3. Uncomment the image tag in `Views/Home/Index.cshtml` (About section)

### 3. Update Skills

In `Models/HomeViewModel.cs`, modify the `InitializeSkills()` method:

```csharp
Skills.Add(new Skill("Your Skill", "Backend", 90, "bi bi-code-square"));
```

Categories: `Backend`, `Frontend`, `Tools`

### 4. Add Your Projects

In `Models/HomeViewModel.cs`, modify the `InitializeProjects()` method:

```csharp
Projects.Add(new Project(
    1,
    "Your Project Name",
    "Description of your project...",
    "/images/your-project.jpg",
    "https://github.com/yourusername/repo",
    new List<string> { "C#", "ASP.NET Core", "SQL Server" }
));
```

### 5. Update Services

In `Models/HomeViewModel.cs`, modify the `InitializeServices()` method:

```csharp
Services.Add(new Service(
    "Service Name",
    "Service description...",
    "bi bi-icon-name"
));
```

### 6. Update About Section

In `Models/HomeViewModel.cs`, modify the `InitializeAboutData()` method:

```csharp
AboutText = "Your about text here...";
AboutPoints = new List<string>
{
    "Education: Your education",
    "Training: Your training",
    "Interests: Your interests"
};
```

---

## Adding Real Project Images

1. Take screenshots of your projects
2. Save them in `wwwroot/images/` folder
3. Name them: `project1.jpg`, `project2.jpg`, etc.
4. In `Views/Home/Index.cshtml`, uncomment the image tags:

```html
<img src="@project.ImageUrl" alt="@project.Title" class="img-fluid">
```

And remove or comment out the placeholder div.

---

## Color Customization

To change the accent color (currently purple), edit `wwwroot/css/site.css`:

```css
:root {
    --accent-color: #your-color;      /* Main accent color */
    --accent-hover: #your-hover-color; /* Hover state */
}
```

---

## Dark/Light Mode

- **Default**: Dark mode
- **Toggle**: Click the moon/sun icon in the navbar
- **Persistence**: User preference is saved in browser's localStorage

---

## Contact Form

The contact form currently shows a success message without sending emails. To add email functionality:

1. Install a NuGet package like `MailKit` or use `System.Net.Mail`
2. Update the `Contact` action in `Controllers/HomeController.cs`
3. Add your SMTP settings in `appsettings.json`

Example SMTP configuration:
```json
"SmtpSettings": {
    "Host": "smtp.gmail.com",
    "Port": 587,
    "Username": "your-email@gmail.com",
    "Password": "your-app-password",
    "EnableSsl": true
}
```

---

## Deployment

### Deploy to Azure

1. Right-click on the project in Visual Studio
2. Select **Publish**
3. Choose **Azure** as the target
4. Follow the wizard to complete deployment

### Deploy to IIS

1. Publish the project:
   ```bash
   dotnet publish -c Release
   ```
2. Copy files from `bin/Release/net8.0/publish/` to your IIS server
3. Configure IIS to run the application

### Deploy to Shared Hosting

1. Publish the project:
   ```bash
   dotnet publish -c Release
   ```
2. Upload all files from `bin/Release/net8.0/publish/` to your hosting
3. Ensure your hosting supports .NET 8.0

---

## Technologies Used

- **ASP.NET Core 8.0** - Web framework
- **Bootstrap 5.3** - CSS framework
- **Bootstrap Icons** - Icon library
- **jQuery Validation** - Form validation

---

## Browser Support

- Chrome (latest)
- Firefox (latest)
- Safari (latest)
- Edge (latest)

---

## Troubleshooting

### Port already in use
```bash
dotnet run --urls "http://localhost:5001"
```

### Missing dependencies
```bash
dotnet restore
```

### Clean and rebuild
```bash
dotnet clean
dotnet build
```

---

## License

This project is open source and available under the [MIT License](LICENSE).

---

## Author

**Ahmad Mahmoud**

- GitHub: [@AhmadMahmoud2005](https://github.com/AhmadMahmoud2005)
- LinkedIn: [Ahmad Mahmoud Medhat](https://www.linkedin.com/in/ahmad-mahmoud-medhat)
- Email: ahmad.mahmoud.medhat@gmail.com

---

## Support

If you found this project helpful, please give it a ⭐ on GitHub!

For questions or issues, feel free to open an issue on GitHub or contact me directly.

---

## Acknowledgments

- [Bootstrap](https://getbootstrap.com/) - For the amazing CSS framework
- [Bootstrap Icons](https://icons.getbootstrap.com/) - For the beautiful icons
- [Microsoft](https://dotnet.microsoft.com/) - For .NET Core

---

**Happy Coding! 🚀**
