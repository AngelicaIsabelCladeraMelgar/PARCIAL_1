using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParcialIsabelCladera.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialIsabelCladera.Models.Country> Countries { get; set; }
    }
}