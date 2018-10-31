using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW5.Models
{
    public class Request
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
        [Range(int.MinValue, int.MaxValue)]
        public int apartmentUnit { get; set; }

        [Required]
        [StringLength(128)]
        public string RequestReport { get; set; }

        [Required]
        public DateTime RequestTime { get; set; }

        [Required]
        public bool submitRequest { get; set; }

        public override string ToString()
        {

            return $"{base.ToString()}: {FirstName} {LastName} {phoneNumber} {apartmentName} {apartmentUnit} {RequestReport} {RequestTime}";
        }
    }
}