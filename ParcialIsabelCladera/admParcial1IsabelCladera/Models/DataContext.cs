﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace admParcial1IsabelCladera.Models
{
    using System.Data.Entity;
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<admParcial1IsabelCladera.Models.Country> Countries { get; set; }
    }
}