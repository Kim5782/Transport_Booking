using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;

namespace YourAppNamespace.Pages
{
    public class ServicesPageModel : PageModel
    {
        [BindProperty]
        public ServiceRequest ServiceRequest { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // The form has validation errors, return the same page to show validation messages.
                return Page();
            }

            // TODO: Process the validated data, such as storing in a database or sending an email.

            // Redirect to a confirmation page or display a success message.
            return RedirectToPage("ConfirmationPage");
        }
    }

    public class ServiceRequest
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Contact number is required.")]
        [Phone(ErrorMessage = "Invalid phone number.")]
        public string ContactNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

      
    }
}
