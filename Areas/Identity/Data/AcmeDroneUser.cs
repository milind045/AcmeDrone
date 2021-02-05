using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AcmeDrone.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the AcmeDroneUser class
    public class AcmeDroneUser : IdentityUser
    {
        [PersonalData]
        [Required]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        public string FamilyName { get; set; }

        [PersonalData]
        public string Address { get; set; }

        [PersonalData]
        public string PostalCode { get; set; }
    }
}
