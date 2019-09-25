using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class UcionicaContext:DbContext
    {
        public  DbSet<Ucionica>Ucionice { get; set; }
        public  DbSet<Racunalo>Racunala { get; set; }
    }
}
