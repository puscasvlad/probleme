using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FermaAnimalelor.Infrastructura;
using FermaAnimalelor.Hrana;

namespace FermaAnimalelor
{
    class Oi : Animal
    {

        public string rasa;
        public IHrana hranaPreferata;

        public Oi()
        {
            this.rasa = "Alba";
            this.hranaPreferata = new Fan();
        }


       public override string Rasa

        {
            get
            {
                return this.rasa;
            }
        }

        public override IHrana HranaPreferata
        {
            get
            {
                return this.hranaPreferata;
            }
        }

        public override IResursa ColecteazaResurse()
        {
            return new Lapte(50);
        }
    }
}
