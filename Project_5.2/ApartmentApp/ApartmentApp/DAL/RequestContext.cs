using ApartmentApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApartmentApp.DAL
{
    public class RequestContext : DbContext
    {
        public RequestContext() : base("name=RequestData")
        {


        }

        public virtual DbSet<Request> Requests { get; set; }

    }
}