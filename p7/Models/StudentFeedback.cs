using System.ComponentModel.DataAnnotations;

namespace WebApplication5.Models
{
    public class StudentFeedbackModel
    {
        [Required(ErrorMessage = "Student Name is required.")]
        [Display(Name = "Student Name")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string StudentName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Course / Department is required.")]
        [Display(Name = "Course / Department")]
        public string Course { get; set; }

        [Required(ErrorMessage = "Feedback is required.")]
        [StringLength(1000, MinimumLength = 5, ErrorMessage = "Feedback must be at least 5 characters long.")]
        [Display(Name = "Feedback")]
        public string FeedbackText { get; set; }
    }
}
