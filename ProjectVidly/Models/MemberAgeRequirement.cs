using System;
using System.ComponentModel.DataAnnotations;

namespace ProjectVidly.Models
{
    public class MemberAgeRequirement : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;

            // If membership is an "unknown" val or "Pay as you Go", then age is valid.
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo) { return ValidationResult.Success; }
            
            // If no birthdate is applied, throw an error
            if (customer.Birthdate == null) { return new ValidationResult("Birthdate is required."); }

            // Calculate age
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer must be at least 18 years old to apply for membership.");
        }
    }
}