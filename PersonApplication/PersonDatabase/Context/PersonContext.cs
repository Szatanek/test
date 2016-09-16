﻿using PersonDatabase.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonDatabase.Context
{
    class PersonContext : DbContext
    {
      public  DbSet<Person> Persons { get; set; }
        
    }
}
