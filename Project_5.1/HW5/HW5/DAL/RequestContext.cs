using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HW5.Models;

namespace HW5.DAL
{
    public class RequestContext : DbContext
    {
        public RequestContext() : base("name=HW5DB")
        {


        }

        public virtual DbSet<Request> Requests { get; set; }

    }
}