// ============================================================
// Portfolio Website - Main JavaScript File
// ============================================================
// This file contains all JavaScript functionality for the portfolio:
// - Dark/Light mode toggle
// - Smooth scrolling for navigation links
// - Navbar background change on scroll
// - Active navigation highlighting
// ============================================================

// ============================================================
// DARK MODE TOGGLE FUNCTIONALITY
// ============================================================
// Handles switching between dark and light themes
// Saves user preference to localStorage
// ============================================================

(function() {
    'use strict';

    // Get references to DOM elements
    const themeToggle = document.getElementById('themeToggle');
    const themeIcon = document.getElementById('themeIcon');
    const htmlElement = document.documentElement;

    // ============================================================
    // Initialize Theme on Page Load
    // ============================================================
    function initTheme() {
        // Check if user has a saved preference
        const savedTheme = localStorage.getItem('theme');
        
        if (savedTheme) {
            // Apply saved theme
            htmlElement.setAttribute('data-bs-theme', savedTheme);
            updateThemeIcon(savedTheme);
        } else {
            // Default to dark mode (no saved preference)
            htmlElement.setAttribute('data-bs-theme', 'dark');
            updateThemeIcon('dark');
            localStorage.setItem('theme', 'dark');
        }
    }

    // ============================================================
    // Update Theme Icon
    // Changes the icon based on current theme
    // ============================================================
    function updateThemeIcon(theme) {
        if (theme === 'dark') {
            // Show moon icon for dark mode
            themeIcon.className = 'bi bi-moon-fill';
        } else {
            // Show sun icon for light mode
            themeIcon.className = 'bi bi-sun-fill';
        }
    }

    // ============================================================
    // Toggle Theme Function
    // Switches between dark and light modes
    // ============================================================
    function toggleTheme() {
        const currentTheme = htmlElement.getAttribute('data-bs-theme');
        const newTheme = currentTheme === 'dark' ? 'light' : 'dark';
        
        // Apply new theme
        htmlElement.setAttribute('data-bs-theme', newTheme);
        
        // Save preference to localStorage
        localStorage.setItem('theme', newTheme);
        
        // Update icon
        updateThemeIcon(newTheme);
        
        // Log for debugging
        console.log(`Theme switched to: ${newTheme}`);
    }

    // ============================================================
    // Event Listener for Theme Toggle Button
    // ============================================================
    if (themeToggle) {
        themeToggle.addEventListener('click', toggleTheme);
    }

    // Initialize theme on page load
    initTheme();

})();

// ============================================================
// SMOOTH SCROLLING FOR NAVIGATION LINKS
// ============================================================
// Adds smooth scrolling behavior to anchor links
// ============================================================

(function() {
    'use strict';

    // Get all navigation links that point to sections
    const navLinks = document.querySelectorAll('a[href^="#"]');

    // Add click event listener to each link
    navLinks.forEach(link => {
        link.addEventListener('click', function(e) {
            // Get the target section ID from the href
            const targetId = this.getAttribute('href');
            
            // Skip if href is just "#"
            if (targetId === '#') return;
            
            const targetSection = document.querySelector(targetId);
            
            if (targetSection) {
                // Prevent default anchor behavior
                e.preventDefault();
                
                // Calculate offset for fixed navbar
                const navbarHeight = document.getElementById('mainNavbar').offsetHeight;
                const targetPosition = targetSection.offsetTop - navbarHeight - 20;
                
                // Smooth scroll to target
                window.scrollTo({
                    top: targetPosition,
                    behavior: 'smooth'
                });
                
                // Close mobile menu if open
                const navbarCollapse = document.querySelector('.navbar-collapse');
                if (navbarCollapse.classList.contains('show')) {
                    navbarCollapse.classList.remove('show');
                }
            }
        });
    });

})();

// ============================================================
// NAVBAR BACKGROUND ON SCROLL
// ============================================================
// Changes navbar appearance when user scrolls down
// ============================================================

(function() {
    'use strict';

    const navbar = document.getElementById('mainNavbar');
    
    function handleScroll() {
        if (window.scrollY > 50) {
            // Add shadow and make more opaque when scrolled
            navbar.style.boxShadow = '0 2px 20px rgba(0, 0, 0, 0.3)';
        } else {
            // Reset to default at top of page
            navbar.style.boxShadow = '0 2px 10px rgba(0, 0, 0, 0.1)';
        }
    }

    // Listen for scroll events
    window.addEventListener('scroll', handleScroll);

})();

// ============================================================
// ACTIVE NAVIGATION HIGHLIGHTING
// ============================================================
// Highlights the current section in the navbar
// ============================================================

(function() {
    'use strict';

    const sections = document.querySelectorAll('section[id]');
    const navLinks = document.querySelectorAll('.nav-link[href^="#"]');
    const navbarHeight = document.getElementById('mainNavbar').offsetHeight;

    function highlightActiveSection() {
        const scrollPosition = window.scrollY + navbarHeight + 100;

        sections.forEach(section => {
            const sectionTop = section.offsetTop;
            const sectionHeight = section.offsetHeight;
            const sectionId = section.getAttribute('id');

            // Check if current scroll position is within this section
            if (scrollPosition >= sectionTop && scrollPosition < sectionTop + sectionHeight) {
                // Remove active class from all links
                navLinks.forEach(link => {
                    link.classList.remove('active');
                });

                // Add active class to current section link
                const activeLink = document.querySelector(`.nav-link[href="#${sectionId}"]`);
                if (activeLink) {
                    activeLink.classList.add('active');
                }
            }
        });
    }

    // Listen for scroll events
    window.addEventListener('scroll', highlightActiveSection);

})();

// ============================================================
// FORM VALIDATION ENHANCEMENTS
// ============================================================
// Adds visual feedback for form validation
// ============================================================

(function() {
    'use strict';

    // Get all forms with validation
    const forms = document.querySelectorAll('form');

    forms.forEach(form => {
        form.addEventListener('submit', function(event) {
            if (!form.checkValidity()) {
                event.preventDefault();
                event.stopPropagation();
            }
            form.classList.add('was-validated');
        });
    });

})();

// ============================================================
// CONSOLE WELCOME MESSAGE
// ============================================================
// Fun console message for developers who open the console
// ============================================================

console.log('%c👋 Hello Developer!', 'font-size: 24px; font-weight: bold; color: #6366f1;');
console.log('%cWelcome to my portfolio website!', 'font-size: 14px; color: #94a3b8;');
console.log('%cFeel free to explore the code and reach out if you have any questions.', 'font-size: 12px; color: #64748b;');
console.log('%cGitHub: https://github.com/AhmadMahmoud2005', 'font-size: 12px; color: #6366f1;');
