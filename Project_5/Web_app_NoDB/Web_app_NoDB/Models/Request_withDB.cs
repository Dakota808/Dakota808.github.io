using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_app_NoDB.Models
{
    public class Request_withDB
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(12)]
        public string FirstName { get; set; }

        [Required, StringLength(12)]
        public string LastName { get; set; }
       
        [Required]
        [Phone]
        public string phoneNumber { get; set; }

        [Required]
        [StringLength(32)]
        public string apartmentName { get; set; }

        [Required]
        [Range(int.MinValue,int.MaxValue)]
        public int apartmentUnit { get; set; }

        [Required]
        [StringLength(128)]
        public string Request { get; set; }

        [Required]
        public DateTime RequestSubmitted { get; set; }

        [Required]
        public bool submitRequest { get; set; }

        public override string ToString()
        {

            return $"{base.ToString()}: {FirstName} {LastName} {phoneNumber} {apartmentName} {apartmentUnit} {Request} {RequestSubmitted}";
        }
    }

 
}