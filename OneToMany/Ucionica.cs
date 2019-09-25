using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    public class Ucionica
    {
        public int Id { get; set; }
        public string NazivUcionice { get; set; }
        public int BrojMjesta { get; set; }

        //navigation property
        public virtual List<Racunalo>Racunala  { get; set; }

        public Ucionica()
        {
            Racunala = new List<Racunalo>();
        }
    }
}
