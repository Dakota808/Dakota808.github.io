using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Web_app_NoDB.Models;

namespace Web_app_NoDB.DAL
{
    public class RequestContext : DbContext
    {
        public RequestContext() : base("name=Request")
        {


        }

        public virtual DbSet<Request_withDB> submittedForms { get; set; }

    }
}