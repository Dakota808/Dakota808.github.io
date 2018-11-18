using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using HW7v2.Models;

namespace HW7v2.DAL
{
    public class SearchLogContext : DbContext
    {
        public SearchLogContext() : base("name=UserDB") { }

        public virtual DbSet<SearchLog> SearchLogs { get; set; }
    }
}