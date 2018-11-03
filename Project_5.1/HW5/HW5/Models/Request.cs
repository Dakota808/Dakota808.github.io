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
        [StringLength(64)]
        public string FirstName { get; set; }

        [Required, StringLength(128)]
        public string LastName { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(64)]
        public string ApartementName { get; set; }

        [Required]
        [Range(int.MinValue, int.MaxValue)]
        public int Unit { get; set; }

        [Required]
        [StringLength(256)]
        public string RequestReport { get; set; }

        [Required]
        public DateTime RequestTime { get; set; }

        [Required]
        public bool SubmitRequest { get; set; }

        public override string ToString()
        {

            return $"{base.ToString()}: {FirstName} {LastName} {PhoneNumber} {ApartementName} {Unit} {RequestReport} {RequestTime}";
        }
    }
}