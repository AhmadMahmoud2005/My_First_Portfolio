// ============================================================
// Home Controller
// ============================================================
// This controller handles all requests for the main pages of the portfolio.
// It includes actions for the Home page and Contact form submission.
// ============================================================

using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        // Logger for debugging and error tracking
        private readonly ILogger<HomeController> _logger;

        // Constructor with dependency injection
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ============================================================
        // GET: / or /Home/Index
        // Main portfolio page - displays all sections
        // ============================================================
        public IActionResult Index()
        {
            // Create the ViewModel with all data
            var viewModel = new HomeViewModel();
            
            // Pass the model to the view
            return View(viewModel);
        }

        // ============================================================
        // POST: /Home/Contact
        // Handles contact form submission
        // ============================================================
        [HttpPost]
        [ValidateAntiForgeryToken] // Security feature to prevent CSRF attacks
        public IActionResult Contact(ContactForm contactForm)
        {
            // Check if the form data is valid
            if (ModelState.IsValid)
            {
                // Log the contact attempt (for debugging)
                _logger.LogInformation($"Contact form submitted by: {contactForm.Name}, Email: {contactForm.Email}");

                // TODO: Add your email sending logic here
                // Example: Send email using SMTP or email service
                // For now, we'll just show a success message

                // Set success message in TempData (persists after redirect)
                TempData["SuccessMessage"] = "Thank you for your message! I will get back to you soon.";

                // Redirect to prevent form resubmission on refresh
                return RedirectToAction(nameof(Index));
            }

            // If validation fails, return to the page with errors
            // Recreate the full ViewModel to display all sections
            var viewModel = new HomeViewModel
            {
                ContactForm = contactForm
            };

            // Return the Index view with the model containing validation errors
            return View("Index", viewModel);
        }

        // ============================================================
        // GET: /Home/Error
        // Error handling page
        // ============================================================
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}
