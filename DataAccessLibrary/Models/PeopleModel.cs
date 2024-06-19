using System.ComponentModel.DataAnnotations;

namespace LibraryManagementApp.Models
{
    public class PeopleModel
    {
            [Required]
            [MaxLength(50, ErrorMessage = "FirstName too long")]
            [MinLength(1,ErrorMessage ="Firstname too short")]
            public string FirstName { get; set; }

		    [Required]
		    [MaxLength(50, ErrorMessage = "Lastname too long")]
		    [MinLength(1, ErrorMessage = "Lastname too short")]
		    public string LastName { get; set; }

            [Required]
		    [MaxLength(12, ErrorMessage = "Contact Number too long")]
		    public string ContactNumber { get; set; }

		    [Required]
		    [MaxLength(100, ErrorMessage = "Address too long")]
		    public string Address { get; set; }

            [Required]
            public string Gender { get; set; }

			[Required]
			[EmailAddress]
			public string Email { get; set; }

    }
}