﻿using ModelValidationsExample.CustomValidators;
using System.ComponentModel.DataAnnotations;

namespace ModelValidationsExample.Models
{
    public class Person
    {
        [Required(ErrorMessage ="{0} can't be empty or null")]
        [Display(Name = "Person Name")]
        [StringLength(40,MinimumLength =3,ErrorMessage ="{0} should be between {2} and {1} characters long")]
        [RegularExpression("^[A-Za-z]$",ErrorMessage ="{0} should contain only alphabets, space and dot (.)")]
        public string? PersonName { get; set; }
        [EmailAddress(ErrorMessage ="{0} should be a proper email address")]
        [Required(ErrorMessage ="{0} can't be blank")]
        public string? Email { get; set; }
        [Phone(ErrorMessage ="{0} should contain 10 digits")]
        public string? Phone { get; set; }
        [Required(ErrorMessage ="{0} can't be blank")]
        public string? Password { get; set; }
        [Required(ErrorMessage ="{0} can't be blank")]
        [Compare("Password",ErrorMessage ="{0} and {1} do not match")]
        [Display(Name ="Re-enter password")]
        public string? ConfirmPassword { get; set; }
        [Range(0,999.99,ErrorMessage ="{0} should be between {1} and {2}")]
        public double? Price { get; set; }

        [MinimunYearValidatorAttribute(2002,ErrorMessage ="Date of Birth should not be newer than Jan 01, {0} ")]

        public DateTime? DateOfBirth { get; set; }
        public override string ToString()
        {
            return $"Person object - Person name: {PersonName}," +
                $" Email: {Email}, Phone: {Phone}, Password: {Password}," +
                $" ConfirmPassword: {ConfirmPassword}, Price: {Price}, DateOfBirth: {DateOfBirth}";
        }
    }
}
