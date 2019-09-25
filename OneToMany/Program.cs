using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToMany
{
    class Program
    {
        static void Main(string[] args)
        {
            UcionicaContext db = new UcionicaContext();
            Ucionica I1 = new Ucionica();
            I1.NazivUcionice = "Informatika1";
            I1.BrojMjesta = 30;

            Racunalo R1 = new Racunalo();
            R1.Naziv = "Racunalo1";
            R1.Marka = "Lenovo";

            Racunalo R2 = new Racunalo();
            R2.Naziv = "Racunalo2";
            R2.Marka = "Lenovo";

            Racunalo R3 = new Racunalo();
            R3.Naziv = "Racunalo3";
            R3.Marka = "Lenovo";
            I1.Racunala.Add(R1);
            I1.Racunala.Add(R2);
            I1.Racunala.Add(R3);

            Ucionica I2 = new Ucionica();
            I2.NazivUcionice = "Informatika2";
            I2.BrojMjesta = 30;

            Racunalo Nastavnicko = new Racunalo();
            Nastavnicko.Naziv = "Nastavnicko racunalo";
            Nastavnicko.Marka = "Dell";
            I2.Racunala.Add(Nastavnicko);
            db.Ucionice.Add(I1);
            db.Ucionice.Add(I2);
            //db.SaveChanges();

            foreach (var u in db.Ucionice) {
                Console.WriteLine(u.NazivUcionice + " " + u.BrojMjesta);
                foreach (var r in u.Racunala) {
                    Console.WriteLine("    " + r.Naziv);
                }
            }
            Console.Read();
        }
    }
}
