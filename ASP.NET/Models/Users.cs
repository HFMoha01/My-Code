using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CIS_420_Project.Models
{
    public partial class Users
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string UserId { get; set; }

        [Required]
        public string UserTypeId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public string Organization { get; set; }

        public string WebsiteUrl { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
