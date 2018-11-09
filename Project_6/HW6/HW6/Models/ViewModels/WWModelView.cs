using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace HW6.Models.ViewModels
{
    public class WWModelView
    {
        public Person MyPerson { get; set; }

        public Customer MyCustomer { get; set; }

        public List<InvoiceLine> MyInvoiceLine { get; set; }
    }
}