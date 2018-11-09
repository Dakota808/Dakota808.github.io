using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ApartmentApp.Models
{
    public class Request
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(64)] 
        [Display(Name ="First Name")]
        public string FirstName { get; set; }

        [Required, StringLength(128)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(64)]
        [Display(Name = "Apartment Name")]
        public string ApartmentName { get; set; }

        [Required]
        [Range(int.MinValue, int.MaxValue)]
        [Display(Name = "Apartment Unit")]
        public int Unit { get; set; }

        [Required]
        [StringLength(256)]
        [Display(Name = "Request")]
        public string RequestReport { get; set; }

        [Required]
        [Display(Name ="Date of Request")]
        public DateTime RequestTime { get; set; }

        [Required]
        [Display(Name ="Submit") ]
        public bool SubmitRequest { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}: First Name = {FirstName} Last Name = {LastName} Phone Number = {PhoneNumber} Apartment = {ApartmentName} Unit = {Unit} Request = {RequestReport} Submission ={RequestTime} Submit = {SubmitRequest}";
        }
    }
}