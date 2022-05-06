using System;
using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        
        [Required(ErrorMessage = "Please enter a first name.")]
        public string Firstname { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string Lastname { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter an email address.")]
        public string Email { get; set; }

        public string Organization { get; set; }
        public DateTime DateAdded { get; set; }        
        
        [Range(1, 100000000, ErrorMessage = "Please select a category.")] 
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string Slug => Firstname?.Replace(' ', '-').ToLower()
           + '-' + Lastname?.Replace(' ', '-').ToLower();

    }
}
