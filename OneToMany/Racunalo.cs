using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
  public class Racunalo
    {

        public int Id { get; set; }
        public string Naziv { get; set; }
        public string  Marka { get; set; }

        //navigation property
        public int UcionicaId { get; set; }
        public  virtual  Ucionica Ucionica { get; set; }
    }
}
